using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KitobNur.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAddedBookAndCategoryMigrationTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 5, 3, 17, 22, 149, DateTimeKind.Utc).AddTicks(5754), "Fiction", null },
                    { 2, new DateTime(2024, 4, 5, 3, 17, 22, 149, DateTimeKind.Utc).AddTicks(5767), "Non-fiction", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Balance", "CategoryId", "CreatedAt", "Description", "ImagePath", "Name", "RentalId", "UpdatedAt", "VistorLogId", "counte" },
                values: new object[,]
                {
                    { 1L, "Harper Lee", 100m, 1, new DateTime(2024, 4, 5, 3, 17, 22, 149, DateTimeKind.Utc).AddTicks(6040), "A novel by Harper Lee", "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg", "To Kill a Mockingbird", null, null, null, (short)10 },
                    { 2L, "George Orwell", 90m, 1, new DateTime(2024, 4, 5, 3, 17, 22, 149, DateTimeKind.Utc).AddTicks(6052), "A novel by George Orwell", "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg", "1984", null, null, null, (short)8 },
                    { 3L, "Yuval Noah Harari", 120m, 2, new DateTime(2024, 4, 5, 3, 17, 22, 149, DateTimeKind.Utc).AddTicks(6057), "A book by Yuval Noah Harari", "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg", "Sapiens: A Brief History of Humankind", null, null, null, (short)15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
