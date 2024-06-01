using AutoMapper;
using data;

namespace server;

public class FishSpeciesResponse
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required ICollection<CloseSeasonResponse> CloseSeasons { get; set; }
}

public class FishSpeciesResponseProfile : Profile
{
    public FishSpeciesResponseProfile()
    {
        this.CreateMap<FishSpecies, FishSpeciesResponse>();
    }
}
