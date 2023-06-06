using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesCollection.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColomnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameDbModelId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ReviewId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_GameDbModelId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "GameDbModelId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "Testimonial",
                table: "Reviews",
                newName: "Review");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ReviewId",
                table: "Reviews",
                newName: "IX_Reviews_GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Games_GameId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "Review",
                table: "Reviews",
                newName: "Testimonial");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Reviews",
                newName: "ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                newName: "IX_Reviews_ReviewId");

            migrationBuilder.AddColumn<int>(
                name: "GameDbModelId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameDbModelId",
                table: "Reviews",
                column: "GameDbModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Games_GameDbModelId",
                table: "Reviews",
                column: "GameDbModelId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviews_ReviewId",
                table: "Reviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id");
        }
    }
}
