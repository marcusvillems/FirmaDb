using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDb.Models
{
    public class Töötaja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Harukontor")]
        public int HarukontoriId { get; set; }
        public Harukontor Harukontor { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nimi { get; set; }
        [MaxLength (50)]
        [Required]
        public string PerekonnaNimi { get; set; }
        [Required]
        public int Isikukood { get; set; }
        [Required]
        public DateTime Sünnipäev { get; set; }
        [MaxLength(50)]
        [Required]
        public string AmetiNimetus { get; set; }
        [Required]
        public int PuhkuspäevadeArv { get; set; }
        [Required]
        public int HaiguslehtedeArv { get; set; }
        [Required]
        [MaxLength(50)]
        public string KontaktTel { get; set; }
        [Required, MaxLength(60)]
        public string Email { get; set; }
        [Required]
        public DateTime TöölAlates { get; set; }
        [Required]
        public DateTime TöölKuni { get; set; }
        [Required]
        public decimal Töökoormus { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }
    }
}
