using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace s20511Kolos1.Migrations
{
    public partial class addedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Championships",
                columns: table => new
                {
                    IdChampionship = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championships", x => x.IdChampionship);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    IdPlayer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.IdPlayer);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    IdTeam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaxAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.IdTeam);
                });

            migrationBuilder.CreateTable(
                name: "Championship_Teams",
                columns: table => new
                {
                    IdChampionshipTeam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeam = table.Column<int>(type: "int", nullable: false),
                    IdChampionship = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championship_Teams", x => x.IdChampionshipTeam);
                    table.ForeignKey(
                        name: "FK_Championship_Teams_Championships_IdChampionship",
                        column: x => x.IdChampionship,
                        principalTable: "Championships",
                        principalColumn: "IdChampionship",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Championship_Teams_Teams_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Teams",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Player_Teams",
                columns: table => new
                {
                    IdPlayerTeam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlayer = table.Column<int>(type: "int", nullable: false),
                    IdTeam = table.Column<int>(type: "int", nullable: false),
                    NumOnShirt = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player_Teams", x => x.IdPlayerTeam);
                    table.ForeignKey(
                        name: "FK_Player_Teams_Players_IdPlayer",
                        column: x => x.IdPlayer,
                        principalTable: "Players",
                        principalColumn: "IdPlayer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Player_Teams_Teams_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Teams",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Championships",
                columns: new[] { "IdChampionship", "OfficialName", "Year" },
                values: new object[,]
                {
                    { 1, "Champions League", 2015 },
                    { 2, "Europe League", 2017 },
                    { 3, "Super League", 2020 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "IdPlayer", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne", "Rooney" },
                    { 2, new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristiano", "Ronaldo" },
                    { 3, new DateTime(1991, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Messi", "Lionel" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "IdTeam", "MaxAge", "TeamName" },
                values: new object[,]
                {
                    { 1, 45, "Barcelona" },
                    { 2, 34, "Chelsea" },
                    { 3, 36, "Liverpool" }
                });

            migrationBuilder.InsertData(
                table: "Championship_Teams",
                columns: new[] { "IdChampionshipTeam", "IdChampionship", "IdTeam", "Score" },
                values: new object[,]
                {
                    { 2, 3, 1, 2.2f },
                    { 1, 1, 2, 2f },
                    { 3, 2, 3, 3.1f }
                });

            migrationBuilder.InsertData(
                table: "Player_Teams",
                columns: new[] { "IdPlayerTeam", "Comment", "IdPlayer", "IdTeam", "NumOnShirt" },
                values: new object[,]
                {
                    { 3, "oqiwueyrt", 3, 1, 10 },
                    { 2, "kalsjdhfg", 1, 2, 7 },
                    { 1, "qwertyui", 2, 3, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Championship_Teams_IdChampionship",
                table: "Championship_Teams",
                column: "IdChampionship");

            migrationBuilder.CreateIndex(
                name: "IX_Championship_Teams_IdTeam",
                table: "Championship_Teams",
                column: "IdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Teams_IdPlayer",
                table: "Player_Teams",
                column: "IdPlayer");

            migrationBuilder.CreateIndex(
                name: "IX_Player_Teams_IdTeam",
                table: "Player_Teams",
                column: "IdTeam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Championship_Teams");

            migrationBuilder.DropTable(
                name: "Player_Teams");

            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
