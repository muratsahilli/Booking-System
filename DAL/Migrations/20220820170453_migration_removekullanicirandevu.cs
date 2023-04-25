using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_removekullanicirandevu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_KullanıcıRandevu_KullanıcıRandevuId",
                table: "Randevu");

            migrationBuilder.DropTable(
                name: "KullanıcıRandevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_KullanıcıRandevuId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "KullanıcıRandevuId",
                table: "Randevu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullanıcıRandevuId",
                table: "Randevu",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "KullanıcıRandevu",
                columns: table => new
                {
                    randevuID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserIDId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullanıcıRandevu", x => x.randevuID);
                    table.ForeignKey(
                        name: "FK_KullanıcıRandevu_AspNetUsers_UserIDId",
                        column: x => x.UserIDId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_KullanıcıRandevuId",
                table: "Randevu",
                column: "KullanıcıRandevuId");

            migrationBuilder.CreateIndex(
                name: "IX_KullanıcıRandevu_UserIDId",
                table: "KullanıcıRandevu",
                column: "UserIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_KullanıcıRandevu_KullanıcıRandevuId",
                table: "Randevu",
                column: "KullanıcıRandevuId",
                principalTable: "KullanıcıRandevu",
                principalColumn: "randevuID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
