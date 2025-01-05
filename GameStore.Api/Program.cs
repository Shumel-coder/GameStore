using GameStore.Api.Data;

using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();

await app.MigrateDbAsync();

app.Run();

//ASP.NET Core Full Course For Beginners by Julio Casal