using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "K_Randevu",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "Randevu_Durumu",
                table: "Randevu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "K_Randevu",
                table: "Randevu",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Randevu_Durumu",
                table: "Randevu",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
