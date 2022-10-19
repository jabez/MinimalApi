using MyMinimalApi.Models;
using MyMinimalApi.ViewModels.Brands;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/brand",  (PostBrandRequestViewModel requestModel) => 
{
    var brand = new Brand()
    {
        Id = Guid.NewGuid(),
        Name = requestModel.Name
    };

    return Results.Created("",brand);
});

app.Run();
