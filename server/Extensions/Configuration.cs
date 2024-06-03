using data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace server;

public static class Configuration
{
    public static void RegisterEndpoint(this WebApplication app)
    {
        app.RegisterIdentity();
        app.RegisterCloseSeasons();
        app.RegisterFishSpecies();
    }

    public static void RegisterMiddlewares(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins(app.Configuration.GetValue<string>("ClientAddress") ?? ""));

        app.UseHttpsRedirection();
        app.UseAuthorization();
    }

    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthorization();

        builder.Services.AddDbContext<FishInfoContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("FishInfo")));

        builder.Services
            .AddIdentityApiEndpoints<ApplicationUser>()
            .AddEntityFrameworkStores<FishInfoContext>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo { Title = "Fish Info API", Version = "v1" });
            opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "bearer"
            });

            opt.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            Array.Empty<string>()
        }
            });
        });

        builder.Services.AddAutoMapper(typeof(Program));

        builder.Services.AddCors();

        builder.WebHost.UseUrls("http://localhost:5001");
    }
}
