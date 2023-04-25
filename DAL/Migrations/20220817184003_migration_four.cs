using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arama_tipi_id",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "Arayan_tipi_id",
                table: "Arama");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Arama_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arayan_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
