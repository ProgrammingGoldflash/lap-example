using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LAPExercise.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Premiere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieDirectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDirectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieDirectors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieDirectors_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Komödie" },
                    { 2, "Drama" },
                    { 3, "Thriller" },
                    { 4, "SciFi" },
                    { 5, "Zeichentrick" },
                    { 6, "Krimi" },
                    { 7, "Musical" },
                    { 8, "Dokumentation" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName", "SecondFirstName" },
                values: new object[,]
                {
                    { 9, "Zack", "Snyder", null },
                    { 8, "Rich", "Moor", null },
                    { 7, "Byron", "Howard", null },
                    { 6, "Margot", "Robbie", null },
                    { 2, "Henry", "Cavill", null },
                    { 4, "Helena", "Carter", "Bonham" },
                    { 3, "William", "Binney", null },
                    { 10, "Friedrich", "Moser", null },
                    { 1, "Ben", "Affleck", null },
                    { 5, "Saorise", "Ronan", null },
                    { 11, "Josie", "Rourke", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "GenreId", "Premiere", "Title1", "Title2" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maria Stuart", "Königin von Schottland" },
                    { 5, 2, new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Der Herr der Ringe", "Die Gefährten" },
                    { 6, 2, new DateTime(2002, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Der Herr der Ringe", "Die zwei Türme" },
                    { 7, 2, new DateTime(2003, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Der Herr der Ringe", "Die Rückkehr des Königs" },
                    { 2, 4, new DateTime(2016, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman V Superman: Daw of Justice", null },
                    { 1, 5, new DateTime(2016, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoomania", null },
                    { 3, 8, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Good American", "NSA" }
                });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "MovieId", "PersonId" },
                values: new object[,]
                {
                    { 4, 4, 6 },
                    { 1, 2, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "MovieDirectors",
                columns: new[] { "Id", "MovieId", "PersonId" },
                values: new object[,]
                {
                    { 5, 4, 11 },
                    { 3, 2, 9 },
                    { 1, 1, 7 },
                    { 2, 1, 8 },
                    { 4, 3, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_PersonId",
                table: "MovieActors",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDirectors_MovieId",
                table: "MovieDirectors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDirectors_PersonId",
                table: "MovieDirectors",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "MovieDirectors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
