using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_isimdegisikligi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KaydedenId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilenKisiId",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "Ziyaret_EdilenKisiId",
                table: "Randevu",
                newName: "ZiyaretEdilenKisiId");

            migrationBuilder.RenameColumn(
                name: "Randevu_KaydedenId",
                table: "Randevu",
                newName: "RandevuKaydedenId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Ziyaret_EdilenKisiId",
                table: "Randevu",
                newName: "IX_Randevu_ZiyaretEdilenKisiId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_KaydedenId",
                table: "Randevu",
                newName: "IX_Randevu_RandevuKaydedenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_RandevuKaydedenId",
                table: "Randevu",
                column: "RandevuKaydedenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_ZiyaretEdilenKisiId",
                table: "Randevu",
                column: "ZiyaretEdilenKisiId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_RandevuKaydedenId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_ZiyaretEdilenKisiId",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "ZiyaretEdilenKisiId",
                table: "Randevu",
                newName: "Ziyaret_EdilenKisiId");

            migrationBuilder.RenameColumn(
                name: "RandevuKaydedenId",
                table: "Randevu",
                newName: "Randevu_KaydedenId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_ZiyaretEdilenKisiId",
                table: "Randevu",
                newName: "IX_Randevu_Ziyaret_EdilenKisiId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_RandevuKaydedenId",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_KaydedenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KaydedenId",
                table: "Randevu",
                column: "Randevu_KaydedenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilenKisiId",
                table: "Randevu",
                column: "Ziyaret_EdilenKisiId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
