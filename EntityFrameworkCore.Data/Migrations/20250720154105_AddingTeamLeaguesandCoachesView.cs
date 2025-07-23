using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTeamLeaguesandCoachesView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"Create View vw_TeamsAndLeagues 
                    as 
                    Select t.Name, l.Name as LeagueName
                    From Teams As t
                    LEFT JOIN Leagues As l
                    ");

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 7, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 7, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2025, 7, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2025, 7, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2025, 7, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2025, 7, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2025, 7, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2025, 7, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2025, 7, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2025, 7, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2025, 7, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2025, 7, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2025, 7, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2025, 7, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2025, 7, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2025, 7, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2025, 7, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2025, 7, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2025, 7, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2025, 6, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2025, 6, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2025, 6, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2025, 6, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2025, 6, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2025, 6, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2025, 6, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2025, 6, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2025, 6, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2025, 6, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2025, 6, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2025, 6, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2025, 6, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2025, 6, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2025, 6, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2025, 6, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2025, 6, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2025, 6, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2025, 6, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2025, 6, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2025, 6, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2025, 6, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2025, 6, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2025, 6, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2025, 6, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2025, 6, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2025, 6, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2025, 6, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2025, 6, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2025, 6, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2025, 5, 31, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateTime",
                value: new DateTime(2025, 5, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateTime",
                value: new DateTime(2025, 5, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateTime",
                value: new DateTime(2025, 5, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateTime",
                value: new DateTime(2025, 5, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateTime",
                value: new DateTime(2025, 5, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateTime",
                value: new DateTime(2025, 5, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateTime",
                value: new DateTime(2025, 5, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateTime",
                value: new DateTime(2025, 5, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateTime",
                value: new DateTime(2025, 5, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateTime",
                value: new DateTime(2025, 5, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateTime",
                value: new DateTime(2025, 5, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateTime",
                value: new DateTime(2025, 5, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateTime",
                value: new DateTime(2025, 5, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateTime",
                value: new DateTime(2025, 5, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateTime",
                value: new DateTime(2025, 5, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateTime",
                value: new DateTime(2025, 5, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateTime",
                value: new DateTime(2025, 5, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateTime",
                value: new DateTime(2025, 5, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateTime",
                value: new DateTime(2025, 5, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateTime",
                value: new DateTime(2025, 5, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateTime",
                value: new DateTime(2025, 5, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateTime",
                value: new DateTime(2025, 5, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateTime",
                value: new DateTime(2025, 5, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateTime",
                value: new DateTime(2025, 5, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateTime",
                value: new DateTime(2025, 5, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateTime",
                value: new DateTime(2025, 5, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateTime",
                value: new DateTime(2025, 5, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateTime",
                value: new DateTime(2025, 5, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateTime",
                value: new DateTime(2025, 5, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateTime",
                value: new DateTime(2025, 5, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateTime",
                value: new DateTime(2025, 4, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateTime",
                value: new DateTime(2025, 4, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateTime",
                value: new DateTime(2025, 4, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateTime",
                value: new DateTime(2025, 4, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateTime",
                value: new DateTime(2025, 4, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateTime",
                value: new DateTime(2025, 4, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateTime",
                value: new DateTime(2025, 4, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateTime",
                value: new DateTime(2025, 4, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateTime",
                value: new DateTime(2025, 4, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateTime",
                value: new DateTime(2025, 4, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateTime",
                value: new DateTime(2025, 4, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateTime",
                value: new DateTime(2025, 4, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateTime",
                value: new DateTime(2025, 4, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateTime",
                value: new DateTime(2025, 4, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateTime",
                value: new DateTime(2025, 4, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateTime",
                value: new DateTime(2025, 4, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateTime",
                value: new DateTime(2025, 4, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateTime",
                value: new DateTime(2025, 4, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateTime",
                value: new DateTime(2025, 4, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateTime",
                value: new DateTime(2025, 4, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1066), new DateTime(2025, 7, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1069), new DateTime(2025, 7, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1070), new DateTime(2025, 7, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1072), new DateTime(2025, 7, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1073), new DateTime(2025, 7, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1076), new DateTime(2025, 7, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1077), new DateTime(2025, 7, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1078), new DateTime(2025, 7, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1079), new DateTime(2025, 7, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1082), new DateTime(2025, 7, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1083), new DateTime(2025, 7, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1084), new DateTime(2025, 7, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 7, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1087), new DateTime(2025, 7, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1088), new DateTime(2025, 7, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1089), new DateTime(2025, 7, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1090), new DateTime(2025, 7, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1093), new DateTime(2025, 7, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1094), new DateTime(2025, 7, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1095), new DateTime(2025, 6, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1097), new DateTime(2025, 6, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1098), new DateTime(2025, 6, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1099), new DateTime(2025, 6, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1100), new DateTime(2025, 6, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1101), new DateTime(2025, 6, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1103), new DateTime(2025, 6, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1104), new DateTime(2025, 6, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1105), new DateTime(2025, 6, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1106), new DateTime(2025, 6, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1108), new DateTime(2025, 6, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1109), new DateTime(2025, 6, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1110), new DateTime(2025, 6, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1111), new DateTime(2025, 6, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1114), new DateTime(2025, 6, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1115), new DateTime(2025, 6, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1116), new DateTime(2025, 6, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1117), new DateTime(2025, 6, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1119), new DateTime(2025, 6, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1120), new DateTime(2025, 6, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1121), new DateTime(2025, 6, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1122), new DateTime(2025, 6, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1123), new DateTime(2025, 6, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1125), new DateTime(2025, 6, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1126), new DateTime(2025, 6, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1127), new DateTime(2025, 6, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1128), new DateTime(2025, 6, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1130), new DateTime(2025, 6, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1131), new DateTime(2025, 6, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1132), new DateTime(2025, 6, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 31, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1133), new DateTime(2025, 5, 31, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 16, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 15, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 14, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 13, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 12, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 11, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 9, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 8, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 7, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 6, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 5, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 3, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 1, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 30, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 29, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 28, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 27, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 26, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 25, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 24, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 23, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 22, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 21, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 18, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 17, 15, 41, 5, 15, DateTimeKind.Utc).AddTicks(673));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP vw_TeamsAndLeagues");

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2025, 7, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2025, 7, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2025, 7, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2025, 7, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2025, 7, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2025, 7, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2025, 7, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2025, 7, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2025, 7, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2025, 7, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2025, 6, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2025, 6, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2025, 6, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2025, 6, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2025, 6, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2025, 6, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2025, 6, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2025, 6, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2025, 6, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2025, 6, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2025, 6, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2025, 6, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2025, 6, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2025, 6, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2025, 6, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2025, 6, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2025, 6, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2025, 6, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2025, 6, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2025, 6, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2025, 6, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2025, 6, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2025, 6, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2025, 6, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2025, 6, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2025, 6, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2025, 6, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2025, 6, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2025, 6, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2025, 6, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2025, 5, 31, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateTime",
                value: new DateTime(2025, 5, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateTime",
                value: new DateTime(2025, 5, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateTime",
                value: new DateTime(2025, 5, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateTime",
                value: new DateTime(2025, 5, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateTime",
                value: new DateTime(2025, 5, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateTime",
                value: new DateTime(2025, 5, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateTime",
                value: new DateTime(2025, 5, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateTime",
                value: new DateTime(2025, 5, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateTime",
                value: new DateTime(2025, 5, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateTime",
                value: new DateTime(2025, 5, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateTime",
                value: new DateTime(2025, 5, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateTime",
                value: new DateTime(2025, 5, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateTime",
                value: new DateTime(2025, 5, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateTime",
                value: new DateTime(2025, 5, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateTime",
                value: new DateTime(2025, 5, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateTime",
                value: new DateTime(2025, 5, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateTime",
                value: new DateTime(2025, 5, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateTime",
                value: new DateTime(2025, 5, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateTime",
                value: new DateTime(2025, 5, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateTime",
                value: new DateTime(2025, 5, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateTime",
                value: new DateTime(2025, 5, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateTime",
                value: new DateTime(2025, 5, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateTime",
                value: new DateTime(2025, 5, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateTime",
                value: new DateTime(2025, 5, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateTime",
                value: new DateTime(2025, 5, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateTime",
                value: new DateTime(2025, 5, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateTime",
                value: new DateTime(2025, 5, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateTime",
                value: new DateTime(2025, 5, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateTime",
                value: new DateTime(2025, 5, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateTime",
                value: new DateTime(2025, 5, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateTime",
                value: new DateTime(2025, 4, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateTime",
                value: new DateTime(2025, 4, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateTime",
                value: new DateTime(2025, 4, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateTime",
                value: new DateTime(2025, 4, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateTime",
                value: new DateTime(2025, 4, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateTime",
                value: new DateTime(2025, 4, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateTime",
                value: new DateTime(2025, 4, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateTime",
                value: new DateTime(2025, 4, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateTime",
                value: new DateTime(2025, 4, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateTime",
                value: new DateTime(2025, 4, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateTime",
                value: new DateTime(2025, 4, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateTime",
                value: new DateTime(2025, 4, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateTime",
                value: new DateTime(2025, 4, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateTime",
                value: new DateTime(2025, 4, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateTime",
                value: new DateTime(2025, 4, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateTime",
                value: new DateTime(2025, 4, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateTime",
                value: new DateTime(2025, 4, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateTime",
                value: new DateTime(2025, 4, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateTime",
                value: new DateTime(2025, 4, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateTime",
                value: new DateTime(2025, 4, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8119), new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8120), new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8123), new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8126), new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8129), new DateTime(2025, 7, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8131), new DateTime(2025, 7, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8132), new DateTime(2025, 7, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8134), new DateTime(2025, 7, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8135), new DateTime(2025, 7, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8137), new DateTime(2025, 7, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8138), new DateTime(2025, 7, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8140), new DateTime(2025, 7, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8142), new DateTime(2025, 7, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8144), new DateTime(2025, 7, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8145), new DateTime(2025, 6, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 6, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8148), new DateTime(2025, 6, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8149), new DateTime(2025, 6, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8150), new DateTime(2025, 6, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8151), new DateTime(2025, 6, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8153), new DateTime(2025, 6, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8154), new DateTime(2025, 6, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8156), new DateTime(2025, 6, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8157), new DateTime(2025, 6, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8158), new DateTime(2025, 6, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8159), new DateTime(2025, 6, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8161), new DateTime(2025, 6, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8162), new DateTime(2025, 6, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8164), new DateTime(2025, 6, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8166), new DateTime(2025, 6, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8167), new DateTime(2025, 6, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8169), new DateTime(2025, 6, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8170), new DateTime(2025, 6, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8171), new DateTime(2025, 6, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8173), new DateTime(2025, 6, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8174), new DateTime(2025, 6, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8176), new DateTime(2025, 6, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8177), new DateTime(2025, 6, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8178), new DateTime(2025, 6, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 6, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 6, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 6, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8184), new DateTime(2025, 6, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8185), new DateTime(2025, 6, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 31, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8186), new DateTime(2025, 5, 31, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(7669));
        }
    }
}
