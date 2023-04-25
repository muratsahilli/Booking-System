using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class aramatablosuguncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AramaTipi_AramaTipiArama_tipi_id",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AspNetUsers_ArananId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AspNetUsers_KaydedenId",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_AramaTipiArama_tipi_id",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_ArananId",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_KaydedenId",
                table: "Arama");

            migrationBuilder.RenameColumn(
                name: "AramaTipiArama_tipi_id",
                table: "Arama",
                newName: "ArayanId");

            migrationBuilder.AlterColumn<int>(
                name: "ArayanTipiArayan_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "AramaTipiId",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Arama_AramaTipiId",
                table: "Arama",
                column: "AramaTipiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_AramaTipi_AramaTipiId",
                table: "Arama",
                column: "AramaTipiId",
                principalTable: "AramaTipi",
                principalColumn: "Arama_tipi_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiArayan_tipi_id",
                table: "Arama",
                column: "ArayanTipiArayan_tipi_id",
                principalTable: "ArayanTipi",
                principalColumn: "Arayan_tipi_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AramaTipi_AramaTipiId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_AramaTipiId",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "AramaTipiId",
                table: "Arama");

            migrationBuilder.RenameColumn(
                name: "ArayanId",
                table: "Arama",
                newName: "AramaTipiArama_tipi_id");

            migrationBuilder.AlterColumn<int>(
                name: "ArayanTipiArayan_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arama_AramaTipiArama_tipi_id",
                table: "Arama",
                column: "AramaTipiArama_tipi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArananId",
                table: "Arama",
                column: "ArananId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_KaydedenId",
                table: "Arama",
                column: "KaydedenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_AramaTipi_AramaTipiArama_tipi_id",
                table: "Arama",
                column: "AramaTipiArama_tipi_id",
                principalTable: "AramaTipi",
                principalColumn: "Arama_tipi_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_ArayanTipi_ArayanTipiArayan_tipi_id",
                table: "Arama",
                column: "ArayanTipiArayan_tipi_id",
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
    }
}
