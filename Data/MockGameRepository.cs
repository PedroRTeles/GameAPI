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
                new Game { Id = 1, Name = "Death Stranding", ReleaseDate = new DateTime(2021, 06, 06), Platforms = MockPlatforms() },
                new Game { Id = 1, Name = "Operation Tango", ReleaseDate = new DateTime(2021, 06, 01), Platforms = MockPlatforms() },
                new Game { Id = 1, Name = "Control", ReleaseDate = new DateTime(2021, 05, 28), Platforms = MockPlatforms() }
            };
        }

        private List<Platform> MockPlatforms()
        {
            return new List<Platform>()
            {
                new Platform { Id = 1, Name = "PC"},
                new Platform { Id = 2, Name = "Nintendo Switch"}
            };
        }

        public Game GetGameById(long id)
        {
            return new Game { Id = 1, Name = "Death Stranding", ReleaseDate = new DateTime(2021, 06, 06), Platforms = MockPlatforms() };
        }
    }
}
