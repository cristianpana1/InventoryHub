using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowClient", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("AllowClient");

app.MapGet("/api/productlist", (IMemoryCache cache) =>
{
    const string cacheKey = "products";

    if (!cache.TryGetValue(cacheKey, out object? products))
    {
        products = new[]
        {
            new
            {
                Id = 1,
                Name = "Laptop",
                Price = 1200.50,
                Stock = 25,
                Category = new
                {
                    Id = 101,
                    Name = "Electronics"
                }
            },
            new
            {
                Id = 2,
                Name = "Headphones",
                Price = 50.00,
                Stock = 100,
                Category = new
                {
                    Id = 102,
                    Name = "Accessories"
                }
            }
        };

        cache.Set(cacheKey, products, TimeSpan.FromMinutes(5));
    }

    return Results.Ok(products);
});

app.Run();