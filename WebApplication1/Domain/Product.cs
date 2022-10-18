namespace WebApplication1.Domain;

public class Product
{
    public string Sku { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }

    public override string ToString() => $"{nameof(Sku)}: {Sku}, {nameof(Name)}: {Name}, {nameof(Price)}: {Price}";
}