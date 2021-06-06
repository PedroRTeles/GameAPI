using GameAPI.Data;
using GameAPI.Dtos;
using GameAPI.Mappers;
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
        public ActionResult<List<GameResponseDto>> GetAllGames()
        {
            var games = repository.GetAllGames();

            return Ok(GameMapper.ConvertToListDto(games));
        }

        [HttpGet("games/{id}")]
        public ActionResult<GameResponseDto> GetGameById(long id)
        {
            var game = repository.GetGameById(id);

            return Ok(GameMapper.ConvertToDto(game));
        }
    }
}
