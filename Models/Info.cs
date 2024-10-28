using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlandAI.Models
{
    public class Info
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(10)]
        public string? PhNo { get; set; }
        [Required]
        public DateOnly DOB { get; set; }
    }

}

