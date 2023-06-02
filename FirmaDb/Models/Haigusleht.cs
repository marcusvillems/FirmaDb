using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDb.Models
{
    public class Haigusleht
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Töötaja")]
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public DateTime AlgusKuupäev { get; set; }
        [Required]
        public DateTime LõppKuupäev { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }
    }
}
