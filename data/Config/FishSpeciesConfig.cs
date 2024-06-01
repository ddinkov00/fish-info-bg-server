using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data;

public class FishSpeciesConfig : IEntityTypeConfiguration<FishSpecies>
{
    public void Configure(EntityTypeBuilder<FishSpecies> builder)
    {
        builder.HasData(
            new FishSpecies
            {
                Id = 1,
                Name = "Речна (балканска) пъстърва, сивен, сиг, пелед и езерна сьомга",
            },
            new FishSpecies
            {
                Id = 2,
                Name = "Липан",
            },
            new FishSpecies
            {
                Id = 3,
                Name = "Щука",
            },
            new FishSpecies
            {
                Id = 4,
                Name = "Распер",
            },
            new FishSpecies
            {
                Id = 5,
                Name = "Пролетно-лятно размножаващи се риби",
            },
            new FishSpecies
            {
                Id = 6,
                Name = "Бяла риба",
            },
            new FishSpecies
            {
                Id = 7,
                Name = "Калкан във водите на Черно море",
            }
        );
    }
}
