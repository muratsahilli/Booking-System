using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_isimdegisikligi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "Arama",
                newName: "İsim");

            migrationBuilder.RenameColumn(
                name: "Aranma_Saati",
                table: "Arama",
                newName: "AranmaSaati");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Arama",
                newName: "Telefon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "İsim",
                table: "Arama",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "Arama",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "AranmaSaati",
                table: "Arama",
                newName: "Aranma_Saati");
        }
    }
}
