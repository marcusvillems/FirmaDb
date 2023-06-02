using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirmaDb.Models
{
    public class Tervisekontrollinimekiri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Töötaja")]
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public DateTime TervisekontrolliKp { get; set; }
        [Required]
        public DateTime JärgmiseTervisekontrolliKp { get; set; }
        [Required]
        [MaxLength(255)]
        public string Tervisenõuanded { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }

    }
}
