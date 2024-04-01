using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitobNur.Data.Migrations
{
    /// <inheritdoc />
    public partial class BookPropertyUpdateMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "Title");
        }
    }
}
