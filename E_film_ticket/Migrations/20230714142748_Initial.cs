using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_film_ticket.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "producers",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "producerId");

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "producers",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
