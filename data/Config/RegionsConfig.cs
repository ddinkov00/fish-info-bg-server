using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data;

public class RegionsConfig : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.HasData(
            new Region
            {
                Id = 1,
                Name = "Пловдив"
            },
            new Region
            {
                Id = 2,
                Name = "София"
            },
            new Region
            {
                Id = 3,
                Name = "Варна"
            }
        );
    }
}
