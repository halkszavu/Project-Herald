using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Concertes",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    LocationID = table.Column<string>(type: "text", nullable: false),
                    Time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concertes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Concertes_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Composers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PeriodID = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Composers_Periods_PeriodID",
                        column: x => x.PeriodID,
                        principalTable: "Periods",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orchestras",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ConcertID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orchestras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orchestras_Concertes_ConcertID",
                        column: x => x.ConcertID,
                        principalTable: "Concertes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Pieces",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ComposerID = table.Column<string>(type: "text", nullable: false),
                    GenreID = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ConcertID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pieces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pieces_Composers_ComposerID",
                        column: x => x.ComposerID,
                        principalTable: "Composers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Concertes_ConcertID",
                        column: x => x.ConcertID,
                        principalTable: "Concertes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Pieces_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Composers_PeriodID",
                table: "Composers",
                column: "PeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_Concertes_LocationID",
                table: "Concertes",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Orchestras_ConcertID",
                table: "Orchestras",
                column: "ConcertID");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_ComposerID",
                table: "Pieces",
                column: "ComposerID");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_ConcertID",
                table: "Pieces",
                column: "ConcertID");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_GenreID",
                table: "Pieces",
                column: "GenreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orchestras");

            migrationBuilder.DropTable(
                name: "Pieces");

            migrationBuilder.DropTable(
                name: "Composers");

            migrationBuilder.DropTable(
                name: "Concertes");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
