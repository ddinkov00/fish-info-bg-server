using AutoMapper;
using data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace server;

public static class CloseSeasonsEndpoint
{
    private static readonly string groupPrefix = "/closeSeasons";
    private static readonly string openApiTagName = "CloseSeasons";

    public static void RegisterCloseSeasons(this IEndpointRouteBuilder routes)
    {
        var group = routes
            .MapGroup(groupPrefix)
            .RequireAuthorization()
            .WithOpenApi(operation => new(operation)
            {
                Tags = [new OpenApiTag { Name = openApiTagName }]
            });

        group.MapGet("", async (FishInfoContext context, IMapper mapper) =>
            await context.CloseSeasons
                .Include(x => x.FishSpecies)
                .Select(x => mapper.Map<CloseSeasonResponse>(x))
                .ToListAsync());
    }
}
