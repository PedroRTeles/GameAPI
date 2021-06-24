using GameAPI.Models;
using System;
using System.Collections.Generic;

namespace GameAPI.Data
{
    public class MockGameRepository : IGameRepository
    {
        public void DeleteGame(Game game)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAllGames()
        {
            return new List<Game>
            {
                new Game { Id = 1, Name = "Death Stranding", ReleaseDate = new DateTime(2021, 06, 06), Platform = "PC" },
                new Game { Id = 1, Name = "Operation Tango", ReleaseDate = new DateTime(2021, 06, 01), Platform = "Nintendo Switch" },
                new Game { Id = 1, Name = "Control", ReleaseDate = new DateTime(2021, 05, 28), Platform = "PC" }
            };
        }

        public Game GetGameById(long id)
        {
            return new Game { Id = 1, Name = "Death Stranding", ReleaseDate = new DateTime(2021, 06, 06), Platform = "PC" };
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
