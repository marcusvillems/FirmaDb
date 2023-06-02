using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaDb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haigusleht",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    AlgusKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LõppKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleht", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TelefoniNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FaksiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaenutatavadAsjad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kogus = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Kommentaar = table.Column<int>(type: "int", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaenutatavadAsjad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    AsjaId = table.Column<int>(type: "int", nullable: false),
                    LaenutusKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TagastamisKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PerekonnaNimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sünnipäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LigipääsuLuba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LigipääsuTase = table.Column<int>(type: "int", nullable: false),
                    AlgusKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LõppKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigipääsuLuba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LigipääsuTase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    Ligipääsu_Tase = table.Column<int>(type: "int", nullable: false),
                    LigipääsuÕigused = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AlgusKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LõppKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigipääsuTase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Palved",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    PalveTekst = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    KoostamisKp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palved", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puhkus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    AlgusKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LõpuKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tasu = table.Column<bool>(type: "bit", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontrollinimekiri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    TervisekontrolliKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JärgmiseTervisekontrolliKp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tervisenõuanded = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontrollinimekiri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Töötaja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HarukontoriId = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PerekonnaNimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    Sünnipäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmetiNimetus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PuhkuspäevadeArv = table.Column<int>(type: "int", nullable: false),
                    HaiguslehtedeArv = table.Column<int>(type: "int", nullable: false),
                    KontaktTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TöölAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöölKuni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Töökoormus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VihjeTekst = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    KoostamiseKp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haigusleht");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "LaenutatavadAsjad");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Laps");

            migrationBuilder.DropTable(
                name: "LigipääsuLuba");

            migrationBuilder.DropTable(
                name: "LigipääsuTase");

            migrationBuilder.DropTable(
                name: "Palved");

            migrationBuilder.DropTable(
                name: "Puhkus");

            migrationBuilder.DropTable(
                name: "Tervisekontrollinimekiri");

            migrationBuilder.DropTable(
                name: "Töötaja");

            migrationBuilder.DropTable(
                name: "Vihjed");
        }
    }
}
