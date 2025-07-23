using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddConcurrencyInBaseModelClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "TeamsCoachesLeagues",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "Teams",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "Matches",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "Leagues",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "Coaches",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Version",
                table: "Audits",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateTime", "Version" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Date", "Version" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Version" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 6,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 7,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 8,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 9,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 10,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 13,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 14,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 15,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 16,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 17,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 18,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 19,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 20,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 21,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 22,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 23,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 24,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 25,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 26,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 27,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 28,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 29,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 30,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 31,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 32,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 33,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 34,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 35,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 36,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 37,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 38,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 39,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 40,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 41,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 42,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 43,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 44,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 45,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 46,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 47,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 48,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 49,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 50,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 51,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 52,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 53,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 54,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 55,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 56,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 57,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 58,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 59,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 60,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 61,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 62,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 63,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 64,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 65,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 66,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 67,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 68,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 69,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 70,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 71,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 72,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 73,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 74,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 75,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 76,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 77,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 78,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 79,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 80,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 81,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 82,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 83,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 84,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 85,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 86,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 87,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 88,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 89,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 90,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 91,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 92,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 93,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 94,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 95,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 96,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 97,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 98,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 99,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 100,
                column: "Version",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "TeamsCoachesLeagues");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Leagues");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Audits");

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
    }
}
