using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitobNur.Data.Migrations
{
    /// <inheritdoc />
    public partial class RentalUpdateMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentalID",
                table: "Rentals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalID",
                table: "Rentals",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
