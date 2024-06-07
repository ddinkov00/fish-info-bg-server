using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data;

public class WaterSourceProhibitionConfig : IEntityTypeConfiguration<WaterSourceProhibition>
{
    public void Configure(EntityTypeBuilder<WaterSourceProhibition> builder)
    {
        builder.HasData(
            new WaterSourceProhibition
            {
                Id = 1,
                Name = "р. Белишка",
                Description = "от извора до моста на разклона за с. Борово (местността Паткарника - старото пъстървово стопанство)",
                Type = WaterSourceProhibitionType.Prohibited,
                RegionId = 1
            },
            new WaterSourceProhibition
            {
                Id = 2,
                Name = "р. Палеш (Падеш)",
                Description = "от пътния мост (с координати 42.669393° N, 24.497495° Е) до вливането на р. Дебелоделещица в р. Права (с координати 42.654704° N, 24.487501 ° Е)",
                Type = WaterSourceProhibitionType.Prohibited,
                RegionId = 1,
            },
            new WaterSourceProhibition
            {
                Id = 3,
                Name = "р. Чепеларска (Чая)",
                Description = "в участъка от стария римски мост над с. Бачково до първия тунел посока гр. Пловдив (с координати 41.959979° N, 24.861136° Е)",
                Type = WaterSourceProhibitionType.CatchAndRelease,
                RegionId = 1,
            },
            new WaterSourceProhibition
            {
                Id = 4,
                Name = "р. Искър",
                Description = "от стената на яз. Искър до ВЕЦ при Долни Пасарел",
                Type = WaterSourceProhibitionType.CatchAndRelease,
                RegionId = 2,
            }
        );
    }
}
