using AutoMapper;
using data;

namespace server;

public class WaterSourceProhibitionResponse
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public WaterSourceProhibitionType Type { get; set; }

    public string RegionName { get; set; }

    public ICollection<MarkerData> Markers { get; set; }
}

public class WaterSourceProhibitionResponseProfile : Profile
{
    public WaterSourceProhibitionResponseProfile()
    {
        this.CreateMap<WaterSourceProhibition, WaterSourceProhibitionResponse>();
    }
}
