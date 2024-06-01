using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data;

public class CloseSeasonConfig : IEntityTypeConfiguration<CloseSeason>
{
    public void Configure(EntityTypeBuilder<CloseSeason> builder)
    {
        builder.HasData(
            new CloseSeason
            {
                Id = 1,
                StartDate = new DateOnly(2024, 10, 01),
                EndDate = new DateOnly(2025, 01, 31),
                FishSpeciesId = 1,
            },
            new CloseSeason
            {
                Id = 2,
                StartDate = new DateOnly(2024, 01, 01),
                EndDate = new DateOnly(2024, 03, 31),
                FishSpeciesId = 2,
            },
            new CloseSeason
            {
                Id = 3,
                StartDate = new DateOnly(2024, 02, 15),
                EndDate = new DateOnly(2024, 04, 30),
                FishSpeciesId = 3,
            },
            new CloseSeason
            {
                Id = 4,
                StartDate = new DateOnly(2024, 03, 01),
                EndDate = new DateOnly(2024, 04, 30),
                FishSpeciesId = 4,
            }, new CloseSeason
            {
                Id = 5,
                StartDate = new DateOnly(2024, 04, 15),
                EndDate = new DateOnly(2024, 05, 31),
                AltitudeMax = 500,
                FishSpeciesId = 5,
            },
            new CloseSeason
            {
                Id = 6,
                StartDate = new DateOnly(2024, 05, 01),
                EndDate = new DateOnly(2024, 06, 15),
                AltitudeMin = 500,
                AltitudeMax = 1500,
                FishSpeciesId = 5,
            },
            new CloseSeason
            {
                Id = 7,
                StartDate = new DateOnly(2024, 10, 01),
                EndDate = new DateOnly(2025, 01, 31),
                AltitudeMin = 1500,
                FishSpeciesId = 5,
            },
            new CloseSeason
            {
                Id = 8,
                StartDate = new DateOnly(2024, 03, 15),
                EndDate = new DateOnly(2024, 05, 15),
                FishSpeciesId = 6,
            },
            new CloseSeason
            {
                Id = 9,
                StartDate = new DateOnly(2024, 04, 15),
                EndDate = new DateOnly(2024, 06, 15),
                FishSpeciesId = 7,
            });
    }
}
