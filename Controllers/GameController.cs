using GameAPI.Data;
using GameAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameAPI.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository repository;

        public GameController(IGameRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("games/")]
        public ActionResult<List<Game>> GetAllGames()
        {
            var games = repository.GetAllGames();

            return Ok(games);
        }

        [HttpGet("games/{id}")]
        public ActionResult<Game> GetGameById(long id)
        {
            var game = repository.GetGameById(id);

            return Ok(game);
        }
    }
}
