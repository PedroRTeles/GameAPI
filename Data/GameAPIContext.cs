using GameAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAPI.Data
{
    public class GameAPIContext : DbContext
    {
        public GameAPIContext(DbContextOptions<GameAPIContext> options) : base(options) { }

        public DbSet<Game> Game { get; set; }
        public DbSet<Platform> Platform { get; set; }
    }
}
