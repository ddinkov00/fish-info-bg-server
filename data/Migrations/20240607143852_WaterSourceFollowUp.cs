using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class WaterSourceFollowUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaterSourceProhibitionWaterSourceProhibitionMarker");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WaterSourceProhibitions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "WaterSourceProhibitions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "WaterSourceProhibitionMarkers",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "WaterSourceProhibitionMarkers",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "WaterSourceProhibitionId",
                table: "WaterSourceProhibitionMarkers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WaterSourceProhibitionMarkers_WaterSourceProhibitionId",
                table: "WaterSourceProhibitionMarkers",
                column: "WaterSourceProhibitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_WaterSourceProhibitionMarkers_WaterSourceProhibitions_Water~",
                table: "WaterSourceProhibitionMarkers",
                column: "WaterSourceProhibitionId",
                principalTable: "WaterSourceProhibitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WaterSourceProhibitionMarkers_WaterSourceProhibitions_Water~",
                table: "WaterSourceProhibitionMarkers");

            migrationBuilder.DropIndex(
                name: "IX_WaterSourceProhibitionMarkers_WaterSourceProhibitionId",
                table: "WaterSourceProhibitionMarkers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "WaterSourceProhibitions");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "WaterSourceProhibitions");

            migrationBuilder.DropColumn(
                name: "WaterSourceProhibitionId",
                table: "WaterSourceProhibitionMarkers");

            migrationBuilder.AlterColumn<int>(
                name: "Longitude",
                table: "WaterSourceProhibitionMarkers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "Latitude",
                table: "WaterSourceProhibitionMarkers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
                name: "IX_WaterSourceProhibitionWaterSourceProhibitionMarker_WaterSou~",
                table: "WaterSourceProhibitionWaterSourceProhibitionMarker",
                column: "WaterSourceProhibitionsId");
        }
    }
}
