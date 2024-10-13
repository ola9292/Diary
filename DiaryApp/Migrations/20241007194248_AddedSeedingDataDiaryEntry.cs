using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with joe", new DateTime(2024, 10, 7, 20, 42, 47, 589, DateTimeKind.Local).AddTicks(5412), "Went Hiking" },
                    { 2, "Went shopping with joe", new DateTime(2024, 10, 7, 20, 42, 47, 589, DateTimeKind.Local).AddTicks(5418), "Went shopping" },
                    { 3, "Went swimming with joe", new DateTime(2024, 10, 7, 20, 42, 47, 589, DateTimeKind.Local).AddTicks(5423), "Went swimming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
