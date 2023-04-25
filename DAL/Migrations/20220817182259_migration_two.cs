using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Arama_Arama_id",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Arama_Arama_id1",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AramaAramaTipi");

            migrationBuilder.DropTable(
                name: "AramaArayanTipi");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Arama_id",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Arama_id1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Arama_id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Arama_id1",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "AramaTipiArama_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArananId",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArayanTipiArayan_tipi_id",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KaydedenId",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Arama_AramaTipiArama_tipi_id",
                table: "Arama",
                column: "AramaTipiArama_tipi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArananId",
                table: "Arama",
                column: "ArananId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArayanTipiArayan_tipi_id",
                table: "Arama",
                column: "ArayanTipiArayan_tipi_id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_Arama_ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_KaydedenId",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "AramaTipiArama_tipi_id",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "ArananId",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "ArayanTipiArayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "KaydedenId",
                table: "Arama");

            migrationBuilder.AddColumn<int>(
                name: "Arama_id",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Arama_id1",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AramaAramaTipi",
                columns: table => new
                {
                    AramaTipiArama_tipi_id = table.Column<int>(type: "integer", nullable: false),
                    AramalarArama_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AramaAramaTipi", x => new { x.AramaTipiArama_tipi_id, x.AramalarArama_id });
                    table.ForeignKey(
                        name: "FK_AramaAramaTipi_Arama_AramalarArama_id",
                        column: x => x.AramalarArama_id,
                        principalTable: "Arama",
                        principalColumn: "Arama_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AramaAramaTipi_AramaTipi_AramaTipiArama_tipi_id",
                        column: x => x.AramaTipiArama_tipi_id,
                        principalTable: "AramaTipi",
                        principalColumn: "Arama_tipi_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AramaArayanTipi",
                columns: table => new
                {
                    AramalarArama_id = table.Column<int>(type: "integer", nullable: false),
                    ArayanTipiArayan_tipi_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AramaArayanTipi", x => new { x.AramalarArama_id, x.ArayanTipiArayan_tipi_id });
                    table.ForeignKey(
                        name: "FK_AramaArayanTipi_Arama_AramalarArama_id",
                        column: x => x.AramalarArama_id,
                        principalTable: "Arama",
                        principalColumn: "Arama_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AramaArayanTipi_ArayanTipi_ArayanTipiArayan_tipi_id",
                        column: x => x.ArayanTipiArayan_tipi_id,
                        principalTable: "ArayanTipi",
                        principalColumn: "Arayan_tipi_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Arama_id",
                table: "AspNetUsers",
                column: "Arama_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Arama_id1",
                table: "AspNetUsers",
                column: "Arama_id1");

            migrationBuilder.CreateIndex(
                name: "IX_AramaAramaTipi_AramalarArama_id",
                table: "AramaAramaTipi",
                column: "AramalarArama_id");

            migrationBuilder.CreateIndex(
                name: "IX_AramaArayanTipi_ArayanTipiArayan_tipi_id",
                table: "AramaArayanTipi",
                column: "ArayanTipiArayan_tipi_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Arama_Arama_id",
                table: "AspNetUsers",
                column: "Arama_id",
                principalTable: "Arama",
                principalColumn: "Arama_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Arama_Arama_id1",
                table: "AspNetUsers",
                column: "Arama_id1",
                principalTable: "Arama",
                principalColumn: "Arama_id");
        }
    }
}
