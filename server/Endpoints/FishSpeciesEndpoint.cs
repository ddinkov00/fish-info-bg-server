using AutoMapper;
using data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace server;

public static class FishSpeciesEndpoint
{
    private static readonly string groupPrefix = "/fishSpecies";
    private static readonly string openApiTagName = "FishSpecies";

    public static void RegisterFishSpecies(this IEndpointRouteBuilder routes)
    {
        var group = routes
            .MapGroup(groupPrefix)
            .RequireAuthorization()
            .WithOpenApi(operation => new(operation)
            {
                Tags = [new OpenApiTag { Name = openApiTagName }]
            });

        group.MapGet("", async (FishInfoContext context, IMapper mapper) =>
            await context.FishSpecies
                .Include(x => x.CloseSeasons)
                .Select(x => mapper.Map<FishSpeciesResponse>(x))
                .ToListAsync());
    }
}
