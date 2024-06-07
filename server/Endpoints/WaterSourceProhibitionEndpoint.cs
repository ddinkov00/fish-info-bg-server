using AutoMapper;
using data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace server;

public static class WaterSourceProhibitionEndpoint
{
    private static readonly string groupPrefix = "/waterSourceProhibitions";
    private static readonly string openApiTagName = "WaterSourceProhibitions";

    public static void RegisterWaterSourceProhibitions(this IEndpointRouteBuilder routes)
    {
        var group = routes
            .MapGroup(groupPrefix)
            .RequireAuthorization()
            .WithOpenApi(operation => new(operation)
            {
                Tags = [new OpenApiTag { Name = openApiTagName }]
            });

        group.MapGet("", async (FishInfoContext context, IMapper mapper) =>
            await context.WaterSourceProhibitions
                .Include(x => x.Region)
                .Include(x => x.Markers)
                .Select(x => mapper.Map<WaterSourceProhibitionResponse>(x))
                .ToListAsync());
    }
}
