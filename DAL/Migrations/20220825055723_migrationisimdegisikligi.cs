using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migrationisimdegisikligi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Randevu_Durumu",
                table: "RandevuDurumu",
                newName: "Randevudurumu");

            migrationBuilder.RenameColumn(
                name: "Randevuya_Gelen",
                table: "Randevu",
                newName: "RandevuyaGelen");

            migrationBuilder.RenameColumn(
                name: "Randevu_id",
                table: "Randevu",
                newName: "RandevuId");

            migrationBuilder.RenameColumn(
                name: "Arayan_tipi",
                table: "ArayanTipi",
                newName: "Arayantipi");

            migrationBuilder.RenameColumn(
                name: "Arayan_tipi_id",
                table: "ArayanTipi",
                newName: "ArayanTipiId");

            migrationBuilder.RenameColumn(
                name: "Arama_tipi",
                table: "AramaTipi",
                newName: "Aramatipi");

            migrationBuilder.RenameColumn(
                name: "Arama_tipi_id",
                table: "AramaTipi",
                newName: "AramaTipiId");

            migrationBuilder.RenameColumn(
                name: "Arama_id",
                table: "Arama",
                newName: "AramaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Randevudurumu",
                table: "RandevuDurumu",
                newName: "Randevu_Durumu");

            migrationBuilder.RenameColumn(
                name: "RandevuyaGelen",
                table: "Randevu",
                newName: "Randevuya_Gelen");

            migrationBuilder.RenameColumn(
                name: "RandevuId",
                table: "Randevu",
                newName: "Randevu_id");

            migrationBuilder.RenameColumn(
                name: "Arayantipi",
                table: "ArayanTipi",
                newName: "Arayan_tipi");

            migrationBuilder.RenameColumn(
                name: "ArayanTipiId",
                table: "ArayanTipi",
                newName: "Arayan_tipi_id");

            migrationBuilder.RenameColumn(
                name: "Aramatipi",
                table: "AramaTipi",
                newName: "Arama_tipi");

            migrationBuilder.RenameColumn(
                name: "AramaTipiId",
                table: "AramaTipi",
                newName: "Arama_tipi_id");

            migrationBuilder.RenameColumn(
                name: "AramaId",
                table: "Arama",
                newName: "Arama_id");
        }
    }
}
