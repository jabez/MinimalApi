using Microsoft.EntityFrameworkCore;
using MyMinimalApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextFactory<MyMinimalApiContext>(options => options.UseInMemoryDatabase($"MyMinimalApiDb"));
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

var scope = app.Services.CreateScope();

var databaseContext = scope.ServiceProvider.GetService<MyMinimalApiContext>();
if (databaseContext != null)
{
    databaseContext.Database.EnsureCreated();
}

app.MapGet("/vhicle", async (IDbContextFactory<MyMinimalApiContext> dbContextFactory) =>
{
    using var dbContext = dbContextFactory.CreateDbContext();
    return  await dbContext.Vehicles.AsNoTracking().ToListAsync();
});

app.Run();
