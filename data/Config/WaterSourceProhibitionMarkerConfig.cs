using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data;

public class WaterSourceProhibitionMarkerConfig : IEntityTypeConfiguration<WaterSourceProhibitionMarker>
{
    public void Configure(EntityTypeBuilder<WaterSourceProhibitionMarker> builder)
    {
        builder.HasData(
            new WaterSourceProhibitionMarker
            {
                Id = 1,
                Latitude = 41.844003,
                Longitude = 24.847174,
                WaterSourceProhibitionId = 1
            },
            new WaterSourceProhibitionMarker
            {
                Id = 2,
                Latitude = 42.669393,
                Longitude = 24.497495,
                WaterSourceProhibitionId = 2
            },
            new WaterSourceProhibitionMarker
            {
                Id = 3,
                Latitude = 42.654704,
                Longitude = 24.487501,
                WaterSourceProhibitionId = 2
            },
            new WaterSourceProhibitionMarker
            {
                Id = 4,
                Latitude = 41.959979,
                Longitude = 24.861136,
                WaterSourceProhibitionId = 3
            }
        );
    }
}
