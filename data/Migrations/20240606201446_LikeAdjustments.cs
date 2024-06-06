using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace data.Migrations
{
    /// <inheritdoc />
    public partial class LikeAdjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_AspNetUsers_UserId1",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "UseId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Likes",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_UserId1",
                table: "Likes",
                newName: "IX_Likes_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_AspNetUsers_ApplicationUserId",
                table: "Likes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_AspNetUsers_ApplicationUserId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Likes",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_ApplicationUserId",
                table: "Likes",
                newName: "IX_Likes_UserId1");

            migrationBuilder.AddColumn<Guid>(
                name: "UseId",
                table: "Likes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Likes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_AspNetUsers_UserId1",
                table: "Likes",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
