using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetServer_TelusInternational.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Queue_Group_Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Offered = table.Column<int>(type: "INTEGER", nullable: false),
                    Handled = table.Column<int>(type: "INTEGER", nullable: false),
                    ATT = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    AHT = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    ServiceLevel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AHT", "ATT", "Handled", "Offered", "Queue_Group_Name", "ServiceLevel" },
                values: new object[] { 1, new TimeOnly(23, 59, 59).Add(TimeSpan.FromTicks(9999)), new TimeOnly(0, 0, 0), 1, 1, "Queue group name 1", 0 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AHT", "ATT", "Handled", "Offered", "Queue_Group_Name", "ServiceLevel" },
                values: new object[] { 2, new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), new TimeOnly(0, 0, 0), 2, 2, "Queue group name 2", 39 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AHT", "ATT", "Handled", "Offered", "Queue_Group_Name", "ServiceLevel" },
                values: new object[] { 3, new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), new TimeOnly(0, 0, 0), 3, 3, "Queue group name 3", 40 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AHT", "ATT", "Handled", "Offered", "Queue_Group_Name", "ServiceLevel" },
                values: new object[] { 4, new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), new TimeOnly(0, 0, 0), 4, 4, "Queue group name 4", 41 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AHT", "ATT", "Handled", "Offered", "Queue_Group_Name", "ServiceLevel" },
                values: new object[] { 5, new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), new TimeOnly(0, 0, 0), 5, 5, "Queue group name 5", 42 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AHT", "ATT", "Handled", "Offered", "Queue_Group_Name", "ServiceLevel" },
                values: new object[] { 6, new TimeOnly(23, 59, 59, 999).Add(TimeSpan.FromTicks(9999)), new TimeOnly(0, 0, 0), 6, 6, "Queue group name 6", 43 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
