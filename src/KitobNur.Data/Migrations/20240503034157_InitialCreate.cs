using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KitobNur.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LibraryReadingHistoryId",
                table: "Books",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LibraryReadingHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryReadingHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryReadingHistory_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "LibraryReadingHistoryId" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 41, 56, 829, DateTimeKind.Utc).AddTicks(8803), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "LibraryReadingHistoryId" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 41, 56, 829, DateTimeKind.Utc).AddTicks(8807), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "LibraryReadingHistoryId" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 41, 56, 829, DateTimeKind.Utc).AddTicks(8809), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 3, 3, 41, 56, 829, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 3, 3, 41, 56, 829, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryReadingHistoryId",
                table: "Books",
                column: "LibraryReadingHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryReadingHistory_UserId",
                table: "LibraryReadingHistory",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_LibraryReadingHistory_LibraryReadingHistoryId",
                table: "Books",
                column: "LibraryReadingHistoryId",
                principalTable: "LibraryReadingHistory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_LibraryReadingHistory_LibraryReadingHistoryId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "LibraryReadingHistory");

            migrationBuilder.DropIndex(
                name: "IX_Books_LibraryReadingHistoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LibraryReadingHistoryId",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 4, 41, 31, 639, DateTimeKind.Utc).AddTicks(3258));
        }
    }
}
