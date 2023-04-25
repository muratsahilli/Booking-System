using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_datetimevol2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_RandevuDurumu_Randevu_DurumuId",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "Randevu_DurumuId",
                table: "Randevu",
                newName: "RandevuDurumuId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_DurumuId",
                table: "Randevu",
                newName: "IX_Randevu_RandevuDurumuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_RandevuDurumu_RandevuDurumuId",
                table: "Randevu",
                column: "RandevuDurumuId",
                principalTable: "RandevuDurumu",
                principalColumn: "RandevuID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_RandevuDurumu_RandevuDurumuId",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "RandevuDurumuId",
                table: "Randevu",
                newName: "Randevu_DurumuId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_RandevuDurumuId",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_DurumuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_RandevuDurumu_Randevu_DurumuId",
                table: "Randevu",
                column: "Randevu_DurumuId",
                principalTable: "RandevuDurumu",
                principalColumn: "RandevuID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
