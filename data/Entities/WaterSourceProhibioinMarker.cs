namespace data;

public class WaterSourceProhibitionMarker
{
    public int Id { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int WaterSourceProhibitionId { get; set; }

    public WaterSourceProhibition WaterSourceProhibition { get; set; }
}
