using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;

namespace server;

public static class IdentityEndpoint
{
    private static readonly string groupPrefix = "/identity";
    private static readonly string tagName = "Identity";

    public static void RegisterIdentity(this IEndpointRouteBuilder router)
    {
        router
            .MapGroup(groupPrefix)
            .MapIdentityApi<IdentityUser>()
            .WithOpenApi(operation => new(operation)
            {
                Tags = [new OpenApiTag { Name = tagName }]
            });
    }
}
