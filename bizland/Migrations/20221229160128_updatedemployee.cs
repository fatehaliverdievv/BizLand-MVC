using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bizland.Migrations
{
    /// <inheritdoc />
    public partial class updatedemployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Clients",
                newName: "LogoUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LogoUrl",
                table: "Clients",
                newName: "Logo");
        }
    }
}
