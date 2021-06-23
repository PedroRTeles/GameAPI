using GameAPI.Dtos;
using GameAPI.Models;
using System.Collections.Generic;

namespace GameAPI.Mappers
{
    public static class GameMapper
    {
        public static List<GameResponseDto> ConvertToListDto(List<Game> games)
        {
            List<GameResponseDto> gamesDto = new();

            games.ForEach(game =>
            {
                gamesDto.Add(ConvertToDto(game));
            });

            return gamesDto;
        }

        public static GameResponseDto ConvertToDto(Game game) => new()
        {
            Id = game.Id,
            Name = game.Name,
            Description = game.Description,
            Platform = game.Platform,
            ReleaseDate = game.ReleaseDate.ToString("dd/MM/yyyy")
        };

        public static Game ConvertToModel(GameCreateRequestDto gameCreateRequestDto) => new()
        {
            Name = gameCreateRequestDto.Name,
            Description = gameCreateRequestDto.Description,
            Platform = gameCreateRequestDto.Platform,
            ReleaseDate = gameCreateRequestDto.ReleaseDate
        };

        public static Game UpdateModel(GameUpdateRequestDto dto, Game game)
        {
            game.Name = dto.Name;
            game.Description = dto.Description;
            game.Platform = dto.Platform;
            game.ReleaseDate = dto.ReleaseDate;

            return game;
        }
    }
}
