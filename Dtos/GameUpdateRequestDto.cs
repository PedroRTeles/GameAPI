using System;
using System.ComponentModel.DataAnnotations;

namespace GameAPI.Dtos
{
    public class GameUpdateRequestDto 
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}
