using GameAPI.Data;
using GameAPI.Dtos;
using GameAPI.Mappers;
using Microsoft.AspNetCore.JsonPatch;
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

        [HttpGet("games/{id}", Name = "GetGameById")]
        public ActionResult<GameResponseDto> GetGameById(long id)
        {
            var game = repository.GetGameById(id);

            return Ok(GameMapper.ConvertToDto(game));
        }

        [HttpPost("games/")]
        public ActionResult<GameResponseDto> CreateGame(GameCreateRequestDto gameCreateRequest)
        {
            var game = GameMapper.ConvertToModel(gameCreateRequest);
            repository.SaveGame(game);

            return CreatedAtRoute(nameof(GetGameById), new { Id = game.Id }, GameMapper.ConvertToDto(game));
        }

        [HttpPut("games/{id}")]
        public ActionResult UpdateGame(int id, GameUpdateRequestDto gameUpdateRequest)
        {
            var gameModelInRepo = repository.GetGameById(id);

            if(gameModelInRepo == null)
            {
                return NotFound();
            }

            var model = GameMapper.UpdateModel(gameUpdateRequest, gameModelInRepo);

            repository.SaveChanges();

            return NoContent();
        }

        [HttpPatch("games/{id}")]
        public ActionResult PartialGameUpdte(int id, JsonPatchDocument<GameUpdateRequestDto> patchDocument)
        {
            var gameModelInRepo = repository.GetGameById(id);

            if (gameModelInRepo == null)
            {
                return NotFound();
            }

            var gameToPatch = GameMapper.ConvertToUpdateRequestDto(gameModelInRepo);
            patchDocument.ApplyTo(gameToPatch, ModelState);

            if(!TryValidateModel(gameToPatch))
            {
                return ValidationProblem();
            }

            var model = GameMapper.UpdateModel(gameToPatch, gameModelInRepo);

            repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("games/{id}")]
        public ActionResult DeleteGame(int id)
        {
            var gameModelInRepo = repository.GetGameById(id);

            if (gameModelInRepo == null)
            {
                return NotFound();
            }

            repository.DeleteGame(gameModelInRepo);

            return NoContent();
        }
    }
}
