using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_film_ticket.Migrations
{
    /// <inheritdoc />
    public partial class FirstApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Aid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pictureYRL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Aid);
                });

            migrationBuilder.CreateTable(
                name: "cinemas",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinemas", x => x.Cid);
                });

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Mid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					MovieCatagory = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false),
				},
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Mid);
                    table.ForeignKey(
                        name: "FK_Movies_cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "cinemas",
                        principalColumn: "Cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "producers",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "actorMovies",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actorMovies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_actorMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Aid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actorMovies_MovieId",
                table: "actorMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actorMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "cinemas");

            migrationBuilder.DropTable(
                name: "producers");
        }
    }
}
