using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBaseModelClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TeamsCoachesLeagues",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TeamsCoachesLeagues",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "TeamsCoachesLeagues",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "TeamsCoachesLeagues",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Audits",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Audits",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Audits",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Audits",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8345), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8377), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8390), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8393), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8395), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8399), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8401), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8403), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8405), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8409), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8413), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8415), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8418), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8420), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8423), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8425), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8427), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8430), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8433), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8435), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8437), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8439), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8441), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8443), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8445), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8447), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8449), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8451), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8453), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8456), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8458), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8460), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8462), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8465), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8468), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8470), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8472), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8474), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8476), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8478), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8481), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8483), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8485), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8487), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8489), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8491), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8493), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8495), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8498), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8499), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8502), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8510), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8513), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8515), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8517), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8519), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8522), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8523), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8526), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8528), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8530), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8532), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8534), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8536), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8538), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8542), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8543), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8546), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8548), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8550), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8552), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8554), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8556), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8558), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8560), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8562), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8564), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8567), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8568), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8571), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8573), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8575), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8577), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8579), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8581), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8583), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8585), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8587), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8589), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8591), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8593), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8595), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8597), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8600), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8602), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8604), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8606), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8608), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8610), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedBy", "CreatedDate", "DateTime", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 13, 20, 25, 157, DateTimeKind.Utc).AddTicks(8612), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TeamsCoachesLeagues",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TeamsCoachesLeagues");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TeamsCoachesLeagues");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "TeamsCoachesLeagues");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "TeamsCoachesLeagues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Audits");

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateTime",
                value: new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateTime",
                value: new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateTime",
                value: new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateTime",
                value: new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateTime",
                value: new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateTime",
                value: new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateTime",
                value: new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateTime",
                value: new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateTime",
                value: new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateTime",
                value: new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateTime",
                value: new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 36,
                column: "DateTime",
                value: new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 37,
                column: "DateTime",
                value: new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateTime",
                value: new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateTime",
                value: new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateTime",
                value: new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 41,
                column: "DateTime",
                value: new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 42,
                column: "DateTime",
                value: new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 43,
                column: "DateTime",
                value: new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 44,
                column: "DateTime",
                value: new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 45,
                column: "DateTime",
                value: new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 46,
                column: "DateTime",
                value: new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 47,
                column: "DateTime",
                value: new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 48,
                column: "DateTime",
                value: new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 49,
                column: "DateTime",
                value: new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 50,
                column: "DateTime",
                value: new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 51,
                column: "DateTime",
                value: new DateTime(2025, 5, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 52,
                column: "DateTime",
                value: new DateTime(2025, 5, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 53,
                column: "DateTime",
                value: new DateTime(2025, 5, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 54,
                column: "DateTime",
                value: new DateTime(2025, 5, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 55,
                column: "DateTime",
                value: new DateTime(2025, 5, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 56,
                column: "DateTime",
                value: new DateTime(2025, 5, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 57,
                column: "DateTime",
                value: new DateTime(2025, 5, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 58,
                column: "DateTime",
                value: new DateTime(2025, 5, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 59,
                column: "DateTime",
                value: new DateTime(2025, 5, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 60,
                column: "DateTime",
                value: new DateTime(2025, 5, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 61,
                column: "DateTime",
                value: new DateTime(2025, 5, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 62,
                column: "DateTime",
                value: new DateTime(2025, 5, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 63,
                column: "DateTime",
                value: new DateTime(2025, 5, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 64,
                column: "DateTime",
                value: new DateTime(2025, 5, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 65,
                column: "DateTime",
                value: new DateTime(2025, 5, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 66,
                column: "DateTime",
                value: new DateTime(2025, 5, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 67,
                column: "DateTime",
                value: new DateTime(2025, 5, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 68,
                column: "DateTime",
                value: new DateTime(2025, 5, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 69,
                column: "DateTime",
                value: new DateTime(2025, 5, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 70,
                column: "DateTime",
                value: new DateTime(2025, 5, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 71,
                column: "DateTime",
                value: new DateTime(2025, 5, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 72,
                column: "DateTime",
                value: new DateTime(2025, 5, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 73,
                column: "DateTime",
                value: new DateTime(2025, 5, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 74,
                column: "DateTime",
                value: new DateTime(2025, 4, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 75,
                column: "DateTime",
                value: new DateTime(2025, 4, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 76,
                column: "DateTime",
                value: new DateTime(2025, 4, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 77,
                column: "DateTime",
                value: new DateTime(2025, 4, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 78,
                column: "DateTime",
                value: new DateTime(2025, 4, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 79,
                column: "DateTime",
                value: new DateTime(2025, 4, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 80,
                column: "DateTime",
                value: new DateTime(2025, 4, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 81,
                column: "DateTime",
                value: new DateTime(2025, 4, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 82,
                column: "DateTime",
                value: new DateTime(2025, 4, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 83,
                column: "DateTime",
                value: new DateTime(2025, 4, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 84,
                column: "DateTime",
                value: new DateTime(2025, 4, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 85,
                column: "DateTime",
                value: new DateTime(2025, 4, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 86,
                column: "DateTime",
                value: new DateTime(2025, 4, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 87,
                column: "DateTime",
                value: new DateTime(2025, 4, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 88,
                column: "DateTime",
                value: new DateTime(2025, 4, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 89,
                column: "DateTime",
                value: new DateTime(2025, 4, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 90,
                column: "DateTime",
                value: new DateTime(2025, 4, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 91,
                column: "DateTime",
                value: new DateTime(2025, 4, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 92,
                column: "DateTime",
                value: new DateTime(2025, 4, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 93,
                column: "DateTime",
                value: new DateTime(2025, 4, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 94,
                column: "DateTime",
                value: new DateTime(2025, 4, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 95,
                column: "DateTime",
                value: new DateTime(2025, 4, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 96,
                column: "DateTime",
                value: new DateTime(2025, 4, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 97,
                column: "DateTime",
                value: new DateTime(2025, 4, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 98,
                column: "DateTime",
                value: new DateTime(2025, 4, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 99,
                column: "DateTime",
                value: new DateTime(2025, 4, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Audits",
                keyColumn: "Id",
                keyValue: 100,
                column: "DateTime",
                value: new DateTime(2025, 4, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6649), new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6652), new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6653), new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6654), new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6655), new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6658), new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6659), new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6664), new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6666), new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6667), new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6669), new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6670), new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6671), new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6672), new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6674), new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6675), new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6676), new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6680), new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6681), new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6682), new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6683), new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6683) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6684), new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6685), new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6686), new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6688), new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6689), new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6690), new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6691), new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6693), new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6694), new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6696), new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6697), new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6699), new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6700), new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6701), new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6702), new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6703), new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6705), new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6708), new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6710), new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Date" },
                values: new object[] { new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6711), new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 31, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 9, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 8, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 7, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 6, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 5, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 4, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 3, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 1, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 30, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 29, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 28, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 27, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 26, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 25, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 24, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 23, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 22, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 21, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 20, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 19, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 18, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 17, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 16, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 15, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 14, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 13, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 12, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 11, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 4, 10, 12, 25, 56, 179, DateTimeKind.Utc).AddTicks(6342));
        }
    }
}
