using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.RenameColumn(
                name: "ArayanId",
                table: "Arama",
                newName: "ArayanTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArananId",
                table: "Arama",
                column: "ArananId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArayanTipiId",
                table: "Arama",
                column: "ArayanTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_KaydedenId",
                table: "Arama",
                column: "KaydedenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiId",
                table: "Arama",
                column: "ArayanTipiId",
                principalTable: "ArayanTipi",
                principalColumn: "Arayan_tipi_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_AspNetUsers_ArananId",
                table: "Arama",
                column: "ArananId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_AspNetUsers_KaydedenId",
                table: "Arama",
                column: "KaydedenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AspNetUsers_ArananId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AspNetUsers_KaydedenId",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_ArananId",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_ArayanTipiId",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_KaydedenId",
                table: "Arama");

            migrationBuilder.RenameColumn(
                name: "ArayanTipiId",
                table: "Arama",
                newName: "ArayanId");

            migrationBuilder.AddColumn<int>(
                name: "ArayanTipiArayan_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArayanTipiArayan_tipi_id",
                table: "Arama",
                column: "ArayanTipiArayan_tipi_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiArayan_tipi_id",
                table: "Arama",
                column: "ArayanTipiArayan_tipi_id",
                principalTable: "ArayanTipi",
                principalColumn: "Arayan_tipi_id");
        }
    }
}
