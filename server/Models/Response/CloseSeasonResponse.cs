using AutoMapper;
using data;

namespace server;

public class CloseSeasonResponse
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int? AltitudeMin { get; set; }

    public int? AltitudeMax { get; set; }
}

public class CloseSeasonResponseProfile : Profile
{
    public CloseSeasonResponseProfile()
    {
        this.CreateMap<CloseSeason, CloseSeasonResponse>();
    }
}
