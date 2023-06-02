using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirmaDb.Models
{
    public class Laenutus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Töötaja")]
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [ForeignKey("LaenutatavadAsjad")]
        public int AsjaId { get; set; }
        public LaenutatavadAsjad LaenutatavadAsjad { get; set; }
        [Required]
        public DateTime LaenutusKp { get; set; }
        [Required]
        public DateTime TagastamisKp { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }
    }
}
