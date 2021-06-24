using GameAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameAPI.Data
{
    public class PostgresGameRepository : IGameRepository
    {
        private readonly GameAPIContext context;

        public PostgresGameRepository(GameAPIContext context)
        {
            this.context = context;
        }

        public void DeleteGame(Game game)
        {
            context.Game.Remove(game);
            SaveChanges();
        }

        public List<Game> GetAllGames()
        {
            return context.Game.ToList();
        }

        public Game GetGameById(long id)
        {
            return context.Game.FirstOrDefault(g => g.Id == id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void SaveGame(Game game)
        {
            context.Game.Add(game);
            SaveChanges();
        }

        public void UpdateGame(Game game)
        {
            // Not Implemented
        }
    }
}
