using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDb.Models
{
    public class Vihjed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [ForeignKey("Töötaja")]
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        public string VihjeTekst { get; set; }

        public DateTime KoostamiseKp { get; set; }
    }
}
