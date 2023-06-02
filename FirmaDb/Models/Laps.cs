using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirmaDb.Models
{
    public class Laps
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Töötaja")]
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nimi { get; set; }
        [Required]
        [MaxLength(50)]
        public string PerekonnaNimi { get; set; }
        public DateTime Sünnipäev { get; set; }

        public int Isikukood { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }
    }
}
