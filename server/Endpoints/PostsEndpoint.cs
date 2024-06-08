using AutoMapper;
using data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Npgsql.Replication;
using System.Security.Claims;

namespace server;

public static class PostsEndpoint
{
    private static readonly string groupPrefix = "/post";
    private static readonly string openApiTagName = "Post";

    public static void RegisterPosts(this IEndpointRouteBuilder routes)
    {
        var group = routes
            .MapGroup(groupPrefix)
            .RequireAuthorization()
            .WithOpenApi(operation => new(operation)
            {
                Tags = [new OpenApiTag { Name = openApiTagName }]
            });

        group.MapGet("", async (FishInfoContext context, IMapper mapper, HttpContext http) =>
            await context.Posts
                    .Include(x => x.ApplicationUser)
                    .Include(x => x.Images)
                    .Include(x => x.Likes)
                    .OrderByDescending(x => x.Created)
                    .Select(x => mapper.Map<PostResponse>(x))
                    .ToListAsync());

        group.MapPost("", async (FishInfoContext context, IMapper mapper, HttpContext http, PostRequest request) =>
        {
            var userId = http.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var post = mapper.Map<Post>(request, opt => opt
                .AfterMap((src, dest) => dest.ApplicationUserId = new Guid(userId)));

            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();
        });
    }
}
