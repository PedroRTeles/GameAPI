using System;
using System.Collections.Generic;

namespace GameAPI.Models
{
    public class Game
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Platform> Platforms { get; set; } 
    }
}
