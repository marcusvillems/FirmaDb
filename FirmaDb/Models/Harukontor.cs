using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDb.Models
{
    public class Harukontor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nimi { get; set; }
        [MaxLength(20)]
        [Required]
        public string TelefoniNumber { get; set; }
        [MaxLength (20)]
        public string FaksiNumber { get; set; }
        [MaxLength(255)]
        public string Kommentaar { get; set; }
    }
}
