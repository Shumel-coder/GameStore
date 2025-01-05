using System;
using GameStore.Api.Data;
using GameStore.Api.Entities;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Endpoints;

public static class GenresEndpoints
{
  public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app) {
    var group = app.MapGroup("genres");

    group.MapGet("/", async (GameStoreContext dbContext) =>
          await dbContext.Genres
                          .Select(genre => genre.ToDTO())
                          .AsNoTracking()
                          .ToListAsync());
    return group;
  }
}
