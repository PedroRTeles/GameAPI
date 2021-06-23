using GameAPI.Models;
using System.Collections.Generic;

namespace GameAPI.Data
{
    public interface IGameRepository
    {
        public List<Game> GetAllGames();
        public Game GetGameById(long id);
        public void SaveChanges();
        public void SaveGame(Game game);
        public void UpdateGame(Game game);
    }
}
