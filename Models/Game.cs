using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameAPI.Models
{
    public class Game
    {
        [Key]
        public long Id { get; set; }
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
