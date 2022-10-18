using System.Collections.ObjectModel;
using WebApplication1.Domain;

namespace WebApplication1.Infrastructure;

public class ProductService
{
    private readonly IReadOnlyCollection<Product> _products;

    public ProductService()
    {
        _products = new ReadOnlyCollection<Product>(GenerateFakeProducts());
    }

    public IReadOnlyCollection<Product> GetProducts() => _products;


    private static IList<Product> GenerateFakeProducts()
    {
        return new Bogus.Faker<Product>()
            .RuleFor(p => p.Sku, f => f.Random.AlphaNumeric(length: 5))
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.Price, f => f.Random.Int(min: 1000, max: 20000) / 100m)
            .Generate(count: 20);
    }
}