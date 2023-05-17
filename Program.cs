using EprApi.Data;
using EprApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EprApiDbContext>();
var app = builder.Build();

app.MapGet("v1/products", (EprApiDbContext context) =>
{
    var data = context.Product.ToList();
    return Results.Ok(data);
});

app.MapPost("v1/products", (EprApiDbContext context, List<CatalogProductModel> model) =>
{
    context.Product.AddRange(model);
    context.SaveChanges();
});

app.Run();
