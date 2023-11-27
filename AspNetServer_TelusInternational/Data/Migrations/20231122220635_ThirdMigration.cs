using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetServer_TelusInternational.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { "00:00:00", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { "00:00:00", 0, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { "00:00:00", 0, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { "00:00:00", 0, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { "00:00:00", 0, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { "00:00:00", 0, 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), 1, 38 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), 1, 39 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), 1, 40 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), 1, 41 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), 1, 42 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "AHT", "Offered", "ServiceLevel" },
                values: new object[] { new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), 1, 43 });
        }
    }
}
