using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaDb.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LigipääsuLuba_LigipääsuTase",
                table: "LigipääsuLuba",
                column: "LigipääsuTase");

            migrationBuilder.CreateIndex(
                name: "IX_LigipääsuLuba_TöötajaId",
                table: "LigipääsuLuba",
                column: "TöötajaId");

            migrationBuilder.AddForeignKey(
                name: "FK_LigipääsuLuba_LigipääsuTase_LigipääsuTase",
                table: "LigipääsuLuba",
                column: "LigipääsuTase",
                principalTable: "LigipääsuTase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LigipääsuLuba_Töötaja_TöötajaId",
                table: "LigipääsuLuba",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LigipääsuLuba_LigipääsuTase_LigipääsuTase",
                table: "LigipääsuLuba");

            migrationBuilder.DropForeignKey(
                name: "FK_LigipääsuLuba_Töötaja_TöötajaId",
                table: "LigipääsuLuba");

            migrationBuilder.DropIndex(
                name: "IX_LigipääsuLuba_LigipääsuTase",
                table: "LigipääsuLuba");

            migrationBuilder.DropIndex(
                name: "IX_LigipääsuLuba_TöötajaId",
                table: "LigipääsuLuba");
        }
    }
}
