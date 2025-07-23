using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewTablesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(type: "TEXT", nullable: true),
                    TableName = table.Column<string>(type: "TEXT", nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KeyValues = table.Column<string>(type: "TEXT", nullable: true),
                    OldValues = table.Column<string>(type: "TEXT", nullable: true),
                    NewValues = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HomeTeamId = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayTeamId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamsCoachesLeagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false),
                    CoachId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsCoachesLeagues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamsCoachesLeagues_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsCoachesLeagues_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamsCoachesLeagues_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Audits",
                columns: new[] { "Id", "Action", "DateTime", "KeyValues", "NewValues", "OldValues", "TableName" },
                values: new object[,]
                {
                    { 1, "Insert", new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6752), "{Id:1}", null, null, "Team" },
                    { 2, "Insert", new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6788), "{Id:2}", null, null, "Team" },
                    { 3, "Insert", new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6791), "{Id:3}", null, null, "Team" },
                    { 4, "Insert", new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6792), "{Id:4}", null, null, "Team" },
                    { 5, "Insert", new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6794), "{Id:5}", null, null, "Team" },
                    { 6, "Insert", new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6797), "{Id:6}", null, null, "Team" },
                    { 7, "Insert", new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6798), "{Id:7}", null, null, "Team" },
                    { 8, "Insert", new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6800), "{Id:8}", null, null, "Team" },
                    { 9, "Insert", new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6802), "{Id:9}", null, null, "Team" },
                    { 10, "Insert", new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6804), "{Id:10}", null, null, "Team" },
                    { 11, "Insert", new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6806), "{Id:11}", null, null, "Team" },
                    { 12, "Insert", new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6808), "{Id:12}", null, null, "Team" },
                    { 13, "Insert", new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6809), "{Id:13}", null, null, "Team" },
                    { 14, "Insert", new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6811), "{Id:14}", null, null, "Team" },
                    { 15, "Insert", new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6812), "{Id:15}", null, null, "Team" },
                    { 16, "Insert", new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6814), "{Id:16}", null, null, "Team" },
                    { 17, "Insert", new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6815), "{Id:17}", null, null, "Team" },
                    { 18, "Insert", new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6818), "{Id:18}", null, null, "Team" },
                    { 19, "Insert", new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6819), "{Id:19}", null, null, "Team" },
                    { 20, "Insert", new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6821), "{Id:20}", null, null, "Team" },
                    { 21, "Insert", new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6822), "{Id:21}", null, null, "Team" },
                    { 22, "Insert", new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6824), "{Id:22}", null, null, "Team" },
                    { 23, "Insert", new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6826), "{Id:23}", null, null, "Team" },
                    { 24, "Insert", new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6827), "{Id:24}", null, null, "Team" },
                    { 25, "Insert", new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6829), "{Id:25}", null, null, "Team" },
                    { 26, "Insert", new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6830), "{Id:26}", null, null, "Team" },
                    { 27, "Insert", new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6831), "{Id:27}", null, null, "Team" },
                    { 28, "Insert", new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6833), "{Id:28}", null, null, "Team" },
                    { 29, "Insert", new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6835), "{Id:29}", null, null, "Team" },
                    { 30, "Insert", new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6836), "{Id:30}", null, null, "Team" },
                    { 31, "Insert", new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6838), "{Id:31}", null, null, "Team" },
                    { 32, "Insert", new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6839), "{Id:32}", null, null, "Team" },
                    { 33, "Insert", new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6841), "{Id:33}", null, null, "Team" },
                    { 34, "Insert", new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6843), "{Id:34}", null, null, "Team" },
                    { 35, "Insert", new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6845), "{Id:35}", null, null, "Team" },
                    { 36, "Insert", new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6846), "{Id:36}", null, null, "Team" },
                    { 37, "Insert", new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6848), "{Id:37}", null, null, "Team" },
                    { 38, "Insert", new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6849), "{Id:38}", null, null, "Team" },
                    { 39, "Insert", new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6851), "{Id:39}", null, null, "Team" },
                    { 40, "Insert", new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6852), "{Id:40}", null, null, "Team" },
                    { 41, "Insert", new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6854), "{Id:41}", null, null, "Team" },
                    { 42, "Insert", new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6855), "{Id:42}", null, null, "Team" },
                    { 43, "Insert", new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6857), "{Id:43}", null, null, "Team" },
                    { 44, "Insert", new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6858), "{Id:44}", null, null, "Team" },
                    { 45, "Insert", new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6860), "{Id:45}", null, null, "Team" },
                    { 46, "Insert", new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6861), "{Id:46}", null, null, "Team" },
                    { 47, "Insert", new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6869), "{Id:47}", null, null, "Team" },
                    { 48, "Insert", new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6871), "{Id:48}", null, null, "Team" },
                    { 49, "Insert", new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6873), "{Id:49}", null, null, "Team" },
                    { 50, "Insert", new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6874), "{Id:50}", null, null, "Team" },
                    { 51, "Insert", new DateTime(2025, 5, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6876), "{Id:51}", null, null, "Team" },
                    { 52, "Insert", new DateTime(2025, 5, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6877), "{Id:52}", null, null, "Team" },
                    { 53, "Insert", new DateTime(2025, 5, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6879), "{Id:53}", null, null, "Team" },
                    { 54, "Insert", new DateTime(2025, 5, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6880), "{Id:54}", null, null, "Team" },
                    { 55, "Insert", new DateTime(2025, 5, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6882), "{Id:55}", null, null, "Team" },
                    { 56, "Insert", new DateTime(2025, 5, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6883), "{Id:56}", null, null, "Team" },
                    { 57, "Insert", new DateTime(2025, 5, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6884), "{Id:57}", null, null, "Team" },
                    { 58, "Insert", new DateTime(2025, 5, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6886), "{Id:58}", null, null, "Team" },
                    { 59, "Insert", new DateTime(2025, 5, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6887), "{Id:59}", null, null, "Team" },
                    { 60, "Insert", new DateTime(2025, 5, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6889), "{Id:60}", null, null, "Team" },
                    { 61, "Insert", new DateTime(2025, 5, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6891), "{Id:61}", null, null, "Team" },
                    { 62, "Insert", new DateTime(2025, 5, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6892), "{Id:62}", null, null, "Team" },
                    { 63, "Insert", new DateTime(2025, 5, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6893), "{Id:63}", null, null, "Team" },
                    { 64, "Insert", new DateTime(2025, 5, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6895), "{Id:64}", null, null, "Team" },
                    { 65, "Insert", new DateTime(2025, 5, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6896), "{Id:65}", null, null, "Team" },
                    { 66, "Insert", new DateTime(2025, 5, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6899), "{Id:66}", null, null, "Team" },
                    { 67, "Insert", new DateTime(2025, 5, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6900), "{Id:67}", null, null, "Team" },
                    { 68, "Insert", new DateTime(2025, 5, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6902), "{Id:68}", null, null, "Team" },
                    { 69, "Insert", new DateTime(2025, 5, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6903), "{Id:69}", null, null, "Team" },
                    { 70, "Insert", new DateTime(2025, 5, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6905), "{Id:70}", null, null, "Team" },
                    { 71, "Insert", new DateTime(2025, 5, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6906), "{Id:71}", null, null, "Team" },
                    { 72, "Insert", new DateTime(2025, 5, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6908), "{Id:72}", null, null, "Team" },
                    { 73, "Insert", new DateTime(2025, 5, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6909), "{Id:73}", null, null, "Team" },
                    { 74, "Insert", new DateTime(2025, 4, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6911), "{Id:74}", null, null, "Team" },
                    { 75, "Insert", new DateTime(2025, 4, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6912), "{Id:75}", null, null, "Team" },
                    { 76, "Insert", new DateTime(2025, 4, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6913), "{Id:76}", null, null, "Team" },
                    { 77, "Insert", new DateTime(2025, 4, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6915), "{Id:77}", null, null, "Team" },
                    { 78, "Insert", new DateTime(2025, 4, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6916), "{Id:78}", null, null, "Team" },
                    { 79, "Insert", new DateTime(2025, 4, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6918), "{Id:79}", null, null, "Team" },
                    { 80, "Insert", new DateTime(2025, 4, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6919), "{Id:80}", null, null, "Team" },
                    { 81, "Insert", new DateTime(2025, 4, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6921), "{Id:81}", null, null, "Team" },
                    { 82, "Insert", new DateTime(2025, 4, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6922), "{Id:82}", null, null, "Team" },
                    { 83, "Insert", new DateTime(2025, 4, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6924), "{Id:83}", null, null, "Team" },
                    { 84, "Insert", new DateTime(2025, 4, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6925), "{Id:84}", null, null, "Team" },
                    { 85, "Insert", new DateTime(2025, 4, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6926), "{Id:85}", null, null, "Team" },
                    { 86, "Insert", new DateTime(2025, 4, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6928), "{Id:86}", null, null, "Team" },
                    { 87, "Insert", new DateTime(2025, 4, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6929), "{Id:87}", null, null, "Team" },
                    { 88, "Insert", new DateTime(2025, 4, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6931), "{Id:88}", null, null, "Team" },
                    { 89, "Insert", new DateTime(2025, 4, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6932), "{Id:89}", null, null, "Team" },
                    { 90, "Insert", new DateTime(2025, 4, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6934), "{Id:90}", null, null, "Team" },
                    { 91, "Insert", new DateTime(2025, 4, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6935), "{Id:91}", null, null, "Team" },
                    { 92, "Insert", new DateTime(2025, 4, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6937), "{Id:92}", null, null, "Team" },
                    { 93, "Insert", new DateTime(2025, 4, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6938), "{Id:93}", null, null, "Team" },
                    { 94, "Insert", new DateTime(2025, 4, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6940), "{Id:94}", null, null, "Team" },
                    { 95, "Insert", new DateTime(2025, 4, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6941), "{Id:95}", null, null, "Team" },
                    { 96, "Insert", new DateTime(2025, 4, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6943), "{Id:96}", null, null, "Team" },
                    { 97, "Insert", new DateTime(2025, 4, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6944), "{Id:97}", null, null, "Team" },
                    { 98, "Insert", new DateTime(2025, 4, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6945), "{Id:98}", null, null, "Team" },
                    { 99, "Insert", new DateTime(2025, 4, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6947), "{Id:99}", null, null, "Team" },
                    { 100, "Insert", new DateTime(2025, 4, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6948), "{Id:100}", null, null, "Team" }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 7, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6598), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premier League" },
                    { 2, null, new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6601), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La Liga" },
                    { 3, null, new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6602), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serie A" },
                    { 4, null, new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6609), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bundesliga" },
                    { 5, null, new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6610), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ligue 1" },
                    { 6, null, new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6612), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eredivisie" },
                    { 7, null, new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6613), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primeira Liga" },
                    { 8, null, new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6614), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russian Premier League" },
                    { 9, null, new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6615), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish Super Lig" },
                    { 10, null, new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6617), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scottish Premiership" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LeagueId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 7, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6186), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manchester United" },
                    { 2, null, new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6196), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Real Madrid" },
                    { 3, null, new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6198), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barcelona" },
                    { 4, null, new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6199), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chelsea" },
                    { 5, null, new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6201), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liverpool" },
                    { 6, null, new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6204), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bayern Munich" },
                    { 7, null, new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6206), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juventus" },
                    { 8, null, new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6207), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paris Saint-Germain" },
                    { 9, null, new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6208), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arsenal" },
                    { 10, null, new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6210), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manchester City" },
                    { 11, null, new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6212), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC Milan" },
                    { 12, null, new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6222), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inter Milan" },
                    { 13, null, new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6223), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borussia Dortmund" },
                    { 14, null, new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6224), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tottenham Hotspur" },
                    { 15, null, new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6226), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ajax" },
                    { 16, null, new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6227), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atletico Madrid" },
                    { 17, null, new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6228), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Napoli" },
                    { 18, null, new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6231), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roma" },
                    { 19, null, new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6232), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porto" },
                    { 20, null, new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6233), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benfica" },
                    { 21, null, new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6234), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sevilla" },
                    { 22, null, new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6236), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leicester City" },
                    { 23, null, new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6237), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everton" },
                    { 24, null, new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6238), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lazio" },
                    { 25, null, new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6239), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valencia" },
                    { 26, null, new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6241), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monaco" },
                    { 27, null, new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6242), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RB Leipzig" },
                    { 28, null, new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6243), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Villarreal" },
                    { 29, null, new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6244), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wolverhampton" },
                    { 30, null, new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6246), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiorentina" },
                    { 31, null, new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6247), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shakhtar Donetsk" },
                    { 32, null, new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6248), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zenit" },
                    { 33, null, new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6250), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Galatasaray" },
                    { 34, null, new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6252), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celtic" },
                    { 35, null, new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6253), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rangers" },
                    { 36, null, new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6255), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PSV Eindhoven" },
                    { 37, null, new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6256), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olympiacos" },
                    { 38, null, new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6257), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Besiktas" },
                    { 39, null, new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6258), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sporting CP" },
                    { 40, null, new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6260), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dynamo Kyiv" },
                    { 41, null, new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6261), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Club Brugge" },
                    { 42, null, new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6262), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anderlecht" },
                    { 43, null, new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6263), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marseille" },
                    { 44, null, new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6270), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lille" },
                    { 45, null, new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6271), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bayer Leverkusen" },
                    { 46, null, new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6272), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schalke 04" },
                    { 47, null, new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6274), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hertha Berlin" },
                    { 48, null, new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6275), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werder Bremen" },
                    { 49, null, new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6276), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Southampton" },
                    { 50, null, new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6278), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crystal Palace" },
                    { 51, null, new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6279), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burnley" },
                    { 52, null, new DateTime(2025, 5, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6280), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watford" },
                    { 53, null, new DateTime(2025, 5, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6281), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brighton" },
                    { 54, null, new DateTime(2025, 5, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6282), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newcastle United" },
                    { 55, null, new DateTime(2025, 5, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6284), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "West Ham United" },
                    { 56, null, new DateTime(2025, 5, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6285), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aston Villa" },
                    { 57, null, new DateTime(2025, 5, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6286), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leeds United" },
                    { 58, null, new DateTime(2025, 5, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6287), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bologna" },
                    { 59, null, new DateTime(2025, 5, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6289), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sampdoria" },
                    { 60, null, new DateTime(2025, 5, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6290), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Torino" },
                    { 61, null, new DateTime(2025, 5, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6291), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Udinese" },
                    { 62, null, new DateTime(2025, 5, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6292), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cagliari" },
                    { 63, null, new DateTime(2025, 5, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6294), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genoa" },
                    { 64, null, new DateTime(2025, 5, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6295), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Espanyol" },
                    { 65, null, new DateTime(2025, 5, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6296), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Real Sociedad" },
                    { 66, null, new DateTime(2025, 5, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6299), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Real Betis" },
                    { 67, null, new DateTime(2025, 5, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6300), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alaves" },
                    { 68, null, new DateTime(2025, 5, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6301), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eibar" },
                    { 69, null, new DateTime(2025, 5, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6302), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Getafe" },
                    { 70, null, new DateTime(2025, 5, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6304), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leganes" },
                    { 71, null, new DateTime(2025, 5, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6305), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mallorca" },
                    { 72, null, new DateTime(2025, 5, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6306), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Granada" },
                    { 73, null, new DateTime(2025, 5, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6307), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osasuna" },
                    { 74, null, new DateTime(2025, 5, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6314), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valladolid" },
                    { 75, null, new DateTime(2025, 4, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6315), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Levante" },
                    { 76, null, new DateTime(2025, 4, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6317), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elche" },
                    { 77, null, new DateTime(2025, 4, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6318), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cadiz" },
                    { 78, null, new DateTime(2025, 4, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6319), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huesca" },
                    { 79, null, new DateTime(2025, 4, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6321), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spezia" },
                    { 80, null, new DateTime(2025, 4, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6322), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verona" },
                    { 81, null, new DateTime(2025, 4, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6324), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parma" },
                    { 82, null, new DateTime(2025, 4, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6325), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benevento" },
                    { 83, null, new DateTime(2025, 4, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6327), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crotone" },
                    { 84, null, new DateTime(2025, 4, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6328), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salernitana" },
                    { 85, null, new DateTime(2025, 4, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6329), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Empoli" },
                    { 86, null, new DateTime(2025, 4, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6330), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sassuolo" },
                    { 87, null, new DateTime(2025, 4, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6332), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reims" },
                    { 88, null, new DateTime(2025, 4, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6333), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nantes" },
                    { 89, null, new DateTime(2025, 4, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6334), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strasbourg" },
                    { 90, null, new DateTime(2025, 4, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6335), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angers" },
                    { 91, null, new DateTime(2025, 4, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6337), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Metz" },
                    { 92, null, new DateTime(2025, 4, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6338), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brest" },
                    { 93, null, new DateTime(2025, 4, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6339), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorient" },
                    { 94, null, new DateTime(2025, 4, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6341), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saint-Etienne" },
                    { 95, null, new DateTime(2025, 4, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6342), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toulouse" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 7, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6492), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pep Guardiola", 1 },
                    { 2, null, new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6495), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jurgen Klopp", 2 },
                    { 3, null, new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6496), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlo Ancelotti", 3 },
                    { 4, null, new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6497), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego Simeone", 4 },
                    { 5, null, new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6498), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas Tuchel", 5 },
                    { 6, null, new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6505), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio Conte", 6 },
                    { 7, null, new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6506), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zinedine Zidane", 7 },
                    { 8, null, new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6507), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauricio Pochettino", 8 },
                    { 9, null, new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6508), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis Enrique", 9 },
                    { 10, null, new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6510), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erik ten Hag", 10 },
                    { 11, null, new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6511), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unai Emery", 11 },
                    { 12, null, new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6512), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massimiliano Allegri", 12 },
                    { 13, null, new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6513), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julian Nagelsmann", 13 },
                    { 14, null, new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6513), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simone Inzaghi", 14 },
                    { 15, null, new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6514), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luciano Spalletti", 15 },
                    { 16, null, new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6515), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graham Potter", 16 },
                    { 17, null, new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6516), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brendan Rodgers", 17 },
                    { 18, null, new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6518), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Moyes", 18 },
                    { 19, null, new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6519), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven Gerrard", 19 },
                    { 20, null, new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6519), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank Lampard", 20 },
                    { 21, null, new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6520), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xavi Hernandez", 21 },
                    { 22, null, new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6521), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikel Arteta", 22 },
                    { 23, null, new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6522), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco Rose", 23 },
                    { 24, null, new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6523), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ralph Hasenhuttl", 24 },
                    { 25, null, new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6524), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oliver Glasner", 25 },
                    { 26, null, new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6525), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nuno Espirito Santo", 26 },
                    { 27, null, new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6526), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paulo Fonseca", 27 },
                    { 28, null, new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6526), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo Jardim", 28 },
                    { 29, null, new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6528), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesse Marsch", 29 },
                    { 30, null, new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6528), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rudi Garcia", 30 },
                    { 31, null, new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6529), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Bosz", 31 },
                    { 32, null, new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6530), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincenzo Italiano", 32 },
                    { 33, null, new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6531), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan Juric", 33 },
                    { 34, null, new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6533), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto De Zerbi", 34 },
                    { 35, null, new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6534), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andriy Shevchenko", 35 },
                    { 36, null, new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6535), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick Vieira", 36 },
                    { 37, null, new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6536), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerardo Seoane", 37 },
                    { 38, null, new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6536), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roger Schmidt", 38 },
                    { 39, null, new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6537), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark van Bommel", 39 },
                    { 40, null, new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6538), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philippe Clement", 40 },
                    { 41, null, new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6539), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergio Conceicao", 41 },
                    { 42, null, new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6540), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jorge Jesus", 42 },
                    { 43, null, new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6541), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fatih Terim", 43 },
                    { 44, null, new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6542), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steven Cooper", 44 },
                    { 45, null, new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6542), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sean Dyche", 45 },
                    { 46, null, new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6543), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy Hodgson", 46 },
                    { 47, null, new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6544), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eddie Howe", 47 },
                    { 48, null, new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6545), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steve Bruce", 48 },
                    { 49, null, new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6546), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott Parker", 49 },
                    { 50, null, new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6547), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel Farke", 50 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "CreatedBy", "CreatedDate", "Date", "HomeTeamId", "ModifiedBy", "ModifiedDate", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 3, null, new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6649), new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6645), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21m },
                    { 2, 4, null, new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6652), new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6651), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22m },
                    { 3, 5, null, new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6653), new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6652), 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23m },
                    { 4, 6, null, new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6654), new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6654), 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24m },
                    { 5, 7, null, new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6655), new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6655), 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25m },
                    { 6, 8, null, new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6658), new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6657), 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26m },
                    { 7, 9, null, new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6659), new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6659), 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27m },
                    { 8, 10, null, new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6660), 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28m },
                    { 9, 11, null, new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6661), 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29m },
                    { 10, 12, null, new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6664), new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6663), 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30m },
                    { 11, 13, null, new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6664), 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31m },
                    { 12, 14, null, new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6666), new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6666), 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32m },
                    { 13, 15, null, new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6667), new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6667), 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 33m },
                    { 14, 16, null, new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6669), new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6668), 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34m },
                    { 15, 17, null, new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6670), new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6669), 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35m },
                    { 16, 18, null, new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6671), new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6670), 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36m },
                    { 17, 19, null, new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6672), new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6671), 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 37m },
                    { 18, 20, null, new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6674), new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6673), 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38m },
                    { 19, 21, null, new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6675), new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6675), 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39m },
                    { 20, 22, null, new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6676), new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6676), 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m },
                    { 21, 23, null, new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6677), 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41m },
                    { 22, 24, null, new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6678), 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42m },
                    { 23, 25, null, new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6680), new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6679), 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43m },
                    { 24, 26, null, new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6681), new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6680), 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44m },
                    { 25, 27, null, new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6682), new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6682), 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45m },
                    { 26, 28, null, new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6683), new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6683), 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46m },
                    { 27, 29, null, new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6684), new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6684), 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47m },
                    { 28, 30, null, new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6685), new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6685), 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48m },
                    { 29, 31, null, new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6686), new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6686), 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49m },
                    { 30, 32, null, new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6688), new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6687), 31, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m },
                    { 31, 33, null, new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6689), new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6688), 32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 51m },
                    { 32, 34, null, new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6690), new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6689), 33, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52m },
                    { 33, 35, null, new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6691), new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6691), 34, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 53m },
                    { 34, 36, null, new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6693), new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6693), 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 54m },
                    { 35, 37, null, new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6694), new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6694), 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55m },
                    { 36, 38, null, new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6695), 37, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56m },
                    { 37, 39, null, new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6696), new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6696), 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 57m },
                    { 38, 40, null, new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6697), new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6697), 39, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 58m },
                    { 39, 41, null, new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6699), new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6698), 40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 59m },
                    { 40, 42, null, new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6700), new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6699), 41, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m },
                    { 41, 43, null, new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6701), new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6700), 42, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61m },
                    { 42, 44, null, new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6702), new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6702), 43, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 62m },
                    { 43, 45, null, new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6703), new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6703), 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63m },
                    { 44, 46, null, new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6704), 45, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 64m },
                    { 45, 47, null, new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6705), new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6705), 46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65m },
                    { 46, 48, null, new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6706), 47, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66m },
                    { 47, 49, null, new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6708), new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6707), 48, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 67m },
                    { 48, 50, null, new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6708), 49, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 68m },
                    { 49, 51, null, new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6710), new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6709), 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69m },
                    { 50, 52, null, new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6711), new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6710), 51, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m }
                });

            migrationBuilder.InsertData(
                table: "TeamsCoachesLeagues",
                columns: new[] { "Id", "CoachId", "LeagueId", "TeamId" },
                values: new object[,]
                {
                    { 1, 2, 2, 2 },
                    { 2, 3, 3, 3 },
                    { 3, 4, 4, 4 },
                    { 4, 5, 5, 5 },
                    { 5, 6, 6, 6 },
                    { 6, 7, 7, 7 },
                    { 7, 8, 8, 8 },
                    { 8, 9, 9, 9 },
                    { 9, 10, 10, 10 },
                    { 10, 11, 1, 11 },
                    { 11, 12, 2, 12 },
                    { 12, 13, 3, 13 },
                    { 13, 14, 4, 14 },
                    { 14, 15, 5, 15 },
                    { 15, 16, 6, 16 },
                    { 16, 17, 7, 17 },
                    { 17, 18, 8, 18 },
                    { 18, 19, 9, 19 },
                    { 19, 20, 10, 20 },
                    { 20, 21, 1, 21 },
                    { 21, 22, 2, 22 },
                    { 22, 23, 3, 23 },
                    { 23, 24, 4, 24 },
                    { 24, 25, 5, 25 },
                    { 25, 26, 6, 26 },
                    { 26, 27, 7, 27 },
                    { 27, 28, 8, 28 },
                    { 28, 29, 9, 29 },
                    { 29, 30, 10, 30 },
                    { 30, 31, 1, 31 },
                    { 31, 32, 2, 32 },
                    { 32, 33, 3, 33 },
                    { 33, 34, 4, 34 },
                    { 34, 35, 5, 35 },
                    { 35, 36, 6, 36 },
                    { 36, 37, 7, 37 },
                    { 37, 38, 8, 38 },
                    { 38, 39, 9, 39 },
                    { 39, 40, 10, 40 },
                    { 40, 41, 1, 41 },
                    { 41, 42, 2, 42 },
                    { 42, 43, 3, 43 },
                    { 43, 44, 4, 44 },
                    { 44, 45, 5, 45 },
                    { 45, 46, 6, 46 },
                    { 46, 47, 7, 47 },
                    { 47, 48, 8, 48 },
                    { 48, 49, 9, 49 },
                    { 49, 50, 10, 50 },
                    { 50, 1, 1, 51 },
                    { 51, 2, 2, 52 },
                    { 52, 3, 3, 53 },
                    { 53, 4, 4, 54 },
                    { 54, 5, 5, 55 },
                    { 55, 6, 6, 56 },
                    { 56, 7, 7, 57 },
                    { 57, 8, 8, 58 },
                    { 58, 9, 9, 59 },
                    { 59, 10, 10, 60 },
                    { 60, 11, 1, 61 },
                    { 61, 12, 2, 62 },
                    { 62, 13, 3, 63 },
                    { 63, 14, 4, 64 },
                    { 64, 15, 5, 65 },
                    { 65, 16, 6, 66 },
                    { 66, 17, 7, 67 },
                    { 67, 18, 8, 68 },
                    { 68, 19, 9, 69 },
                    { 69, 20, 10, 70 },
                    { 70, 21, 1, 71 },
                    { 71, 22, 2, 72 },
                    { 72, 23, 3, 73 },
                    { 73, 24, 4, 74 },
                    { 74, 25, 5, 75 },
                    { 75, 26, 6, 76 },
                    { 76, 27, 7, 77 },
                    { 77, 28, 8, 78 },
                    { 78, 29, 9, 79 },
                    { 79, 30, 10, 80 },
                    { 80, 31, 1, 81 },
                    { 81, 32, 2, 82 },
                    { 82, 33, 3, 83 },
                    { 83, 34, 4, 84 },
                    { 84, 35, 5, 85 },
                    { 85, 36, 6, 86 },
                    { 86, 37, 7, 87 },
                    { 87, 38, 8, 88 },
                    { 88, 39, 9, 89 },
                    { 89, 40, 10, 90 },
                    { 90, 41, 1, 91 },
                    { 91, 42, 2, 92 },
                    { 92, 43, 3, 93 },
                    { 93, 44, 4, 94 },
                    { 94, 45, 5, 95 },
                    { 95, 46, 6, 1 },
                    { 96, 47, 7, 2 },
                    { 97, 48, 8, 3 },
                    { 98, 49, 9, 4 },
                    { 99, 50, 10, 5 },
                    { 100, 1, 1, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsCoachesLeagues_CoachId",
                table: "TeamsCoachesLeagues",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsCoachesLeagues_LeagueId",
                table: "TeamsCoachesLeagues",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamsCoachesLeagues_TeamId",
                table: "TeamsCoachesLeagues",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "TeamsCoachesLeagues");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
