using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.DTOs;

public record class UpdateGameDTO
(
  [Required][StringLength(50)] string Name,
  [Required][StringLength(20)] string Genre,
  [Range(1,100)] decimal Price,
  DateOnly ReleaseDate
);
