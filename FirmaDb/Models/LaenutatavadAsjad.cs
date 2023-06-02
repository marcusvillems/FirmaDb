using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirmaDb.Models
{
    public class LaenutatavadAsjad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int Kogus { get; set; }
        [Required]
        [MaxLength(255)]
        public string Kirjeldus { get; set; }
        [MaxLength(255)]
        public int Kommentaar { get; set; }

    }
}
