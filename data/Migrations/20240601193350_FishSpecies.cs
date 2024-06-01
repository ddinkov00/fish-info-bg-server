using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class FishSpecies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FishSpecies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishSpecies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CloseSeasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AltitudeMin = table.Column<int>(type: "integer", nullable: true),
                    AltitudeMax = table.Column<int>(type: "integer", nullable: true),
                    FishSpeciesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloseSeasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CloseSeasons_FishSpecies_FishSpeciesId",
                        column: x => x.FishSpeciesId,
                        principalTable: "FishSpecies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FishSpecies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Речна (балканска) пъстърва, сивен, сиг, пелед и езерна сьомга" },
                    { 2, "Липан" },
                    { 3, "Щука" },
                    { 4, "Распер" },
                    { 5, "Пролетно-лятно размножаващи се риби" },
                    { 6, "Бяла риба" },
                    { 7, "Калкан във водите на Черно море" }
                });

            migrationBuilder.InsertData(
                table: "CloseSeasons",
                columns: new[] { "Id", "AltitudeMax", "AltitudeMin", "EndDate", "FishSpeciesId", "StartDate" },
                values: new object[,]
                {
                    { 1, null, null, new DateOnly(2025, 1, 31), 1, new DateOnly(2024, 10, 1) },
                    { 2, null, null, new DateOnly(2024, 3, 31), 2, new DateOnly(2024, 1, 1) },
                    { 3, null, null, new DateOnly(2024, 4, 30), 3, new DateOnly(2024, 2, 15) },
                    { 4, null, null, new DateOnly(2024, 4, 30), 4, new DateOnly(2024, 3, 1) },
                    { 5, 500, null, new DateOnly(2024, 5, 31), 5, new DateOnly(2024, 4, 15) },
                    { 6, 1500, 500, new DateOnly(2024, 6, 15), 5, new DateOnly(2024, 5, 1) },
                    { 7, null, 1500, new DateOnly(2025, 1, 31), 5, new DateOnly(2024, 10, 1) },
                    { 8, null, null, new DateOnly(2024, 5, 15), 6, new DateOnly(2024, 3, 15) },
                    { 9, null, null, new DateOnly(2024, 6, 15), 7, new DateOnly(2024, 4, 15) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CloseSeasons_FishSpeciesId",
                table: "CloseSeasons",
                column: "FishSpeciesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CloseSeasons");

            migrationBuilder.DropTable(
                name: "FishSpecies");
        }
    }
}
