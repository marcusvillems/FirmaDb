using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaDb.Migrations
{
    public partial class add_Keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_HarukontoriId",
                table: "Töötaja",
                column: "HarukontoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontrollinimekiri_TöötajaId",
                table: "Tervisekontrollinimekiri",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkus_TöötajaId",
                table: "Puhkus",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Palved_TöötajaId",
                table: "Palved",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_LigipääsuTase_TöötajaId",
                table: "LigipääsuTase",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laps_TöötajaId",
                table: "Laps",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_AsjaId",
                table: "Laenutus",
                column: "AsjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_TöötajaId",
                table: "Laenutus",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Haigusleht_TöötajaId",
                table: "Haigusleht",
                column: "TöötajaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Haigusleht_Töötaja_TöötajaId",
                table: "Haigusleht",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laenutus_LaenutatavadAsjad_AsjaId",
                table: "Laenutus",
                column: "AsjaId",
                principalTable: "LaenutatavadAsjad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laenutus_Töötaja_TöötajaId",
                table: "Laenutus",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laps_Töötaja_TöötajaId",
                table: "Laps",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LigipääsuTase_Töötaja_TöötajaId",
                table: "LigipääsuTase",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Palved_Töötaja_TöötajaId",
                table: "Palved",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Puhkus_Töötaja_TöötajaId",
                table: "Puhkus",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tervisekontrollinimekiri_Töötaja_TöötajaId",
                table: "Tervisekontrollinimekiri",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Töötaja_Harukontor_HarukontoriId",
                table: "Töötaja",
                column: "HarukontoriId",
                principalTable: "Harukontor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Haigusleht_Töötaja_TöötajaId",
                table: "Haigusleht");

            migrationBuilder.DropForeignKey(
                name: "FK_Laenutus_LaenutatavadAsjad_AsjaId",
                table: "Laenutus");

            migrationBuilder.DropForeignKey(
                name: "FK_Laenutus_Töötaja_TöötajaId",
                table: "Laenutus");

            migrationBuilder.DropForeignKey(
                name: "FK_Laps_Töötaja_TöötajaId",
                table: "Laps");

            migrationBuilder.DropForeignKey(
                name: "FK_LigipääsuTase_Töötaja_TöötajaId",
                table: "LigipääsuTase");

            migrationBuilder.DropForeignKey(
                name: "FK_Palved_Töötaja_TöötajaId",
                table: "Palved");

            migrationBuilder.DropForeignKey(
                name: "FK_Puhkus_Töötaja_TöötajaId",
                table: "Puhkus");

            migrationBuilder.DropForeignKey(
                name: "FK_Tervisekontrollinimekiri_Töötaja_TöötajaId",
                table: "Tervisekontrollinimekiri");

            migrationBuilder.DropForeignKey(
                name: "FK_Töötaja_Harukontor_HarukontoriId",
                table: "Töötaja");

            migrationBuilder.DropIndex(
                name: "IX_Töötaja_HarukontoriId",
                table: "Töötaja");

            migrationBuilder.DropIndex(
                name: "IX_Tervisekontrollinimekiri_TöötajaId",
                table: "Tervisekontrollinimekiri");

            migrationBuilder.DropIndex(
                name: "IX_Puhkus_TöötajaId",
                table: "Puhkus");

            migrationBuilder.DropIndex(
                name: "IX_Palved_TöötajaId",
                table: "Palved");

            migrationBuilder.DropIndex(
                name: "IX_LigipääsuTase_TöötajaId",
                table: "LigipääsuTase");

            migrationBuilder.DropIndex(
                name: "IX_Laps_TöötajaId",
                table: "Laps");

            migrationBuilder.DropIndex(
                name: "IX_Laenutus_AsjaId",
                table: "Laenutus");

            migrationBuilder.DropIndex(
                name: "IX_Laenutus_TöötajaId",
                table: "Laenutus");

            migrationBuilder.DropIndex(
                name: "IX_Haigusleht_TöötajaId",
                table: "Haigusleht");
        }
    }
}
