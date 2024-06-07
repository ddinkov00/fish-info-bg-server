using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class WaterSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterSourceProhibitionMarkers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<int>(type: "integer", nullable: false),
                    Longitude = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterSourceProhibitionMarkers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterSourceProhibitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    RegionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterSourceProhibitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterSourceProhibitions_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterSourceProhibitionWaterSourceProhibitionMarker",
                columns: table => new
                {
                    MarkersId = table.Column<int>(type: "integer", nullable: false),
                    WaterSourceProhibitionsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterSourceProhibitionWaterSourceProhibitionMarker", x => new { x.MarkersId, x.WaterSourceProhibitionsId });
                    table.ForeignKey(
                        name: "FK_WaterSourceProhibitionWaterSourceProhibitionMarker_WaterSou~",
                        column: x => x.MarkersId,
                        principalTable: "WaterSourceProhibitionMarkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterSourceProhibitionWaterSourceProhibitionMarker_WaterSo~1",
                        column: x => x.WaterSourceProhibitionsId,
                        principalTable: "WaterSourceProhibitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaterSourceProhibitions_RegionId",
                table: "WaterSourceProhibitions",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterSourceProhibitionWaterSourceProhibitionMarker_WaterSou~",
                table: "WaterSourceProhibitionWaterSourceProhibitionMarker",
                column: "WaterSourceProhibitionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterSourceProhibitionWaterSourceProhibitionMarker");

            migrationBuilder.DropTable(
                name: "WaterSourceProhibitionMarkers");

            migrationBuilder.DropTable(
                name: "WaterSourceProhibitions");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
