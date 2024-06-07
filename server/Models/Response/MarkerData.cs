using AutoMapper;
using data;

namespace server;

public class MarkerData
{
    public double Latitude { get; set; }

    public double Longitude { get; set; }
}

public class MarkerDataProfile : Profile
{
    public MarkerDataProfile()
    {
        this.CreateMap<WaterSourceProhibitionMarker, MarkerData>();
    }
}