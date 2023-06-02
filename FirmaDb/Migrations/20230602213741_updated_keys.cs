using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaDb.Migrations
{
    public partial class updated_keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VihjeTekst",
                table: "Vihjed",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "TöötajaId",
                table: "Vihjed",
                type: "int",
                maxLength: 255,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vihjed_TöötajaId",
                table: "Vihjed",
                column: "TöötajaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vihjed_Töötaja_TöötajaId",
                table: "Vihjed",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vihjed_Töötaja_TöötajaId",
                table: "Vihjed");

            migrationBuilder.DropIndex(
                name: "IX_Vihjed_TöötajaId",
                table: "Vihjed");

            migrationBuilder.DropColumn(
                name: "TöötajaId",
                table: "Vihjed");

            migrationBuilder.AlterColumn<string>(
                name: "VihjeTekst",
                table: "Vihjed",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
