namespace data;

public class Region
{
    public Region()
    {
        this.WaterSourceProhibitions = [];
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<WaterSourceProhibition> WaterSourceProhibitions { get; set; }
}
