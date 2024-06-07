using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class WaterSourceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Пловдив" },
                    { 2, "София" },
                    { 3, "Варна" }
                });

            migrationBuilder.InsertData(
                table: "WaterSourceProhibitions",
                columns: new[] { "Id", "Description", "Name", "RegionId", "Type" },
                values: new object[,]
                {
                    { 1, "от извора до моста на разклона за с. Борово (местността Паткарника - старото пъстървово стопанство)", "р. Белишка", 1, 0 },
                    { 2, "от пътния мост (с координати 42.669393° N, 24.497495° Е) до вливането на р. Дебелоделещица в р. Права (с координати 42.654704° N, 24.487501 ° Е)", "р. Палеш (Падеш)", 1, 0 },
                    { 3, "в участъка от стария римски мост над с. Бачково до първия тунел посока гр. Пловдив (с координати 41.959979° N, 24.861136° Е)", "р. Чепеларска (Чая)", 1, 1 },
                    { 4, "от стената на яз. Искър до ВЕЦ при Долни Пасарел", "р. Искър", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "WaterSourceProhibitionMarkers",
                columns: new[] { "Id", "Latitude", "Longitude", "WaterSourceProhibitionId" },
                values: new object[,]
                {
                    { 1, 41.844003000000001, 24.847173999999999, 1 },
                    { 2, 42.669392999999999, 24.497495000000001, 2 },
                    { 3, 42.654704000000002, 24.487501000000002, 2 },
                    { 4, 41.959978999999997, 24.861135999999998, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitionMarkers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitionMarkers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitionMarkers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitionMarkers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WaterSourceProhibitions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
