using FirmaDb.Models;
using Microsoft.EntityFrameworkCore;

namespace FirmaDb
{
    public class FirmaDbContext : DbContext
    {
        public FirmaDbContext(DbContextOptions<FirmaDbContext> options)
           : base(options) { }

        public DbSet<Haigusleht> Haigusleht { get; set; }
        public DbSet<Harukontor> Harukontor { get; set; }
        public DbSet<LaenutatavadAsjad> LaenutatavadAsjad { get; set; }
        public DbSet<Laenutus> Laenutus { get; set; }
        public DbSet<Laps> Laps { get; set; }
        public DbSet<LigipääsuLuba> LigipääsuLuba { get; set; }
        public DbSet<LigipääsuTase> LigipääsuTase { get; set; }
        public DbSet<Palved> Palved { get; set; }
        public DbSet<Puhkus> Puhkus { get; set; }
        public DbSet<Tervisekontrollinimekiri> Tervisekontrollinimekiri { get; set; }
        public DbSet<Töötaja> Töötaja { get; set; }
        public DbSet<Vihjed> Vihjed { get; set; }
    }
}