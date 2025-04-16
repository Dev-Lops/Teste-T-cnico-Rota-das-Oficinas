namespace RO.DevTest.Domain.Entities;

public class Sale
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = default!;
    public List<SaleItem> Items { get; set; } = new();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public decimal Total => Items.Sum(i => i.UnitPrice * i.Quantity);
}
