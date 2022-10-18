using WebApplication1.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

builder.Services.AddSingleton<ProductService>();

var app = builder.Build();

app.UseSwagger()
    .UseSwaggerUI();

app.MapGet("/products", (ProductService productService) => productService.GetProducts());

app.Run();