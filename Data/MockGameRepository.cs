using GameAPI.Models;
using System;
using System.Collections.Generic;

namespace GameAPI.Data
{
    public class MockGameRepository : IGameRepository
    {
        public List<Game> GetAllGames()
        {
            return new List<Game>
            {
                new Game { Id = 1, Name = "Death Stranding", ReleaseDate = new DateTime(2021, 06, 06), Platform = new Platform { Id = 1, Name = "PC"}, },
                new Game { Id = 1, Name = "Operation Tango", ReleaseDate = new DateTime(2021, 06, 01), Platform = new Platform { Id = 1, Name = "Nintendo Switch"}, },
                new Game { Id = 1, Name = "Control", ReleaseDate = new DateTime(2021, 05, 28), Platform = new Platform { Id = 1, Name = "PC"}, }
            };
        }

        public Game GetGameById(long id)
        {
            return new Game { Id = 1, Name = "Death Stranding", ReleaseDate = new DateTime(2021, 06, 06), Platform = new Platform { Id = 1, Name = "PC" }, };
        }
    }
}
