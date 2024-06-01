using Microsoft.EntityFrameworkCore;

namespace data;

public class FishSpecies
{
    public FishSpecies()
    {
        this.CloseSeasons = [];
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<CloseSeason> CloseSeasons { get; set; }
}
