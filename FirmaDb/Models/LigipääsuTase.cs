using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirmaDb.Models
{
    public class LigipääsuTase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Töötaja")]
        public int TöötajaId { get; set; }
        public Töötaja Töötaja { get; set; }
        [Required]
        public int Ligipääsu_Tase { get; set; }
        [Required]
        [MaxLength(255)]
        public string LigipääsuÕigused { get; set; }
        [Required]
        public DateTime AlgusKp { get; set; }
        [Required]
        public DateTime LõppKp { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }
    }
}
