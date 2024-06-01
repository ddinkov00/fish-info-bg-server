namespace data;

public class CloseSeason
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int? AltitudeMin { get; set; }

    public int? AltitudeMax { get; set; }

    public int FishSpeciesId { get; set; }

    public FishSpecies FishSpecies { get; set; }
}
