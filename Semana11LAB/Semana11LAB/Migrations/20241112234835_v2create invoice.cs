using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Semana11LAB.Migrations
{
    /// <inheritdoc />
    public partial class v2createinvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Customers");
        }
    }
}
