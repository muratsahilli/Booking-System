using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KayıtId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_KullanıcıRandevu_KullanıcırandevuID",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_RandevuDurumu_Randevu_DurumRandevuID",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "KullanıcırandevuID",
                table: "Randevu",
                newName: "KullanıcıRandevuId");

            migrationBuilder.RenameColumn(
                name: "Ziyaret_EdilId",
                table: "Randevu",
                newName: "Ziyaret_EdilenKisiId");

            migrationBuilder.RenameColumn(
                name: "Randevu_KayıtId",
                table: "Randevu",
                newName: "Randevu_KaydedenId");

            migrationBuilder.RenameColumn(
                name: "Randevu_DurumRandevuID",
                table: "Randevu",
                newName: "Randevu_DurumuId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_KullanıcırandevuID",
                table: "Randevu",
                newName: "IX_Randevu_KullanıcıRandevuId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Ziyaret_EdilId",
                table: "Randevu",
                newName: "IX_Randevu_Ziyaret_EdilenKisiId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_KayıtId",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_KaydedenId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_DurumRandevuID",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_DurumuId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_KullanıcıRandevu_KullanıcıRandevuId",
                table: "Randevu",
                column: "KullanıcıRandevuId",
                principalTable: "KullanıcıRandevu",
                principalColumn: "randevuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_RandevuDurumu_Randevu_DurumuId",
                table: "Randevu",
                column: "Randevu_DurumuId",
                principalTable: "RandevuDurumu",
                principalColumn: "RandevuID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KaydedenId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilenKisiId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_KullanıcıRandevu_KullanıcıRandevuId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_RandevuDurumu_Randevu_DurumuId",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "KullanıcıRandevuId",
                table: "Randevu",
                newName: "KullanıcırandevuID");

            migrationBuilder.RenameColumn(
                name: "Ziyaret_EdilenKisiId",
                table: "Randevu",
                newName: "Ziyaret_EdilId");

            migrationBuilder.RenameColumn(
                name: "Randevu_KaydedenId",
                table: "Randevu",
                newName: "Randevu_KayıtId");

            migrationBuilder.RenameColumn(
                name: "Randevu_DurumuId",
                table: "Randevu",
                newName: "Randevu_DurumRandevuID");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_KullanıcıRandevuId",
                table: "Randevu",
                newName: "IX_Randevu_KullanıcırandevuID");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Ziyaret_EdilenKisiId",
                table: "Randevu",
                newName: "IX_Randevu_Ziyaret_EdilId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_KaydedenId",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_KayıtId");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_DurumuId",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_DurumRandevuID");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KayıtId",
                table: "Randevu",
                column: "Randevu_KayıtId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilId",
                table: "Randevu",
                column: "Ziyaret_EdilId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_KullanıcıRandevu_KullanıcırandevuID",
                table: "Randevu",
                column: "KullanıcırandevuID",
                principalTable: "KullanıcıRandevu",
                principalColumn: "randevuID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_RandevuDurumu_Randevu_DurumRandevuID",
                table: "Randevu",
                column: "Randevu_DurumRandevuID",
                principalTable: "RandevuDurumu",
                principalColumn: "RandevuID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
