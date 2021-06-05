using System.ComponentModel.DataAnnotations;

namespace GameAPI.Models
{
    public class Platform
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
    }
}
