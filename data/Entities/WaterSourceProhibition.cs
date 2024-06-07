namespace data;

public class WaterSourceProhibition
{
    public WaterSourceProhibition()
    {
        this.Markers = [];
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public WaterSourceProhibitionType Type { get; set; }

    public int RegionId { get; set; }

    public Region Region { get; set; }

    public ICollection<WaterSourceProhibitionMarker> Markers { get; set; }
}
