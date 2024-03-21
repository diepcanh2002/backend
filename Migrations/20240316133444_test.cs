using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PitchManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxMembers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamCode);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LeftTeamCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RightTeamCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefereeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FooballFieldCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TournamentCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchCode);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_LeftTeamCode",
                        column: x => x.LeftTeamCode,
                        principalTable: "Teams",
                        principalColumn: "TeamCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_RightTeamCode",
                        column: x => x.RightTeamCode,
                        principalTable: "Teams",
                        principalColumn: "TeamCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weigth = table.Column<float>(type: "real", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerCode);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamCode",
                        column: x => x.TeamCode,
                        principalTable: "Teams",
                        principalColumn: "TeamCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballFields",
                columns: table => new
                {
                    FootballFieldCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FootballFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballFieldDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballFieldType = table.Column<int>(type: "int", nullable: false),
                    FootballFieldLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballFields", x => x.FootballFieldCode);
                    table.ForeignKey(
                        name: "FK_FootballFields_Matches_FootballFieldCode",
                        column: x => x.FootballFieldCode,
                        principalTable: "Matches",
                        principalColumn: "MatchCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Referees",
                columns: table => new
                {
                    RefereeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referees", x => x.RefereeCode);
                    table.ForeignKey(
                        name: "FK_Referees_Matches_RefereeCode",
                        column: x => x.RefereeCode,
                        principalTable: "Matches",
                        principalColumn: "MatchCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatchCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TimeSet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardCode);
                    table.ForeignKey(
                        name: "FK_Cards_Matches_MatchCode",
                        column: x => x.MatchCode,
                        principalTable: "Matches",
                        principalColumn: "MatchCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Players_PlayerCode",
                        column: x => x.PlayerCode,
                        principalTable: "Players",
                        principalColumn: "PlayerCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GoalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatchCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TimeSet = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalCode);
                    table.ForeignKey(
                        name: "FK_Goals_Matches_MatchCode",
                        column: x => x.MatchCode,
                        principalTable: "Matches",
                        principalColumn: "MatchCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goals_Players_PlayerCode",
                        column: x => x.PlayerCode,
                        principalTable: "Players",
                        principalColumn: "PlayerCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_MatchCode",
                table: "Cards",
                column: "MatchCode");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PlayerCode",
                table: "Cards",
                column: "PlayerCode");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_MatchCode",
                table: "Goals",
                column: "MatchCode");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_PlayerCode",
                table: "Goals",
                column: "PlayerCode");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_LeftTeamCode",
                table: "Matches",
                column: "LeftTeamCode");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_RightTeamCode",
                table: "Matches",
                column: "RightTeamCode");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamCode",
                table: "Players",
                column: "TeamCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "FootballFields");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Referees");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
