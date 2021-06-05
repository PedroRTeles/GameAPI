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

        public List<Game> GetAllGames()
        {
            return context.Game.ToList();
        }

        public Game GetGameById(long id)
        {
            return context.Game.FirstOrDefault(g => g.Id == id);
        }
    }
}
