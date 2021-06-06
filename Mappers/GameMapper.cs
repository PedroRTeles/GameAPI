using GameAPI.Dtos;
using GameAPI.Models;
using System;
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
            Name = game.Name,
            Description = game.Description,
            Platform = game.Platform,
            ReleaseDate = game.ReleaseDate.ToString("dd/MM/yyyy")
        };
    }
}
