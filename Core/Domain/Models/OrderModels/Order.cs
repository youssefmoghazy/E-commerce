namespace Domain.Models.OrderModels;

public class Order : BaseEntity<Guid>
{
    public Order()
    {
        
    }
    public Order(string email, IEnumerable<OrderItem> items, OrderAddress address,
        DeliveryMethod deliveryMethod, 
        decimal subtotal)
    {
        Email = email;
        Items = items;
        Address = address;
        DeliveryMethod = deliveryMethod;
        this.subtotal = subtotal;
    }

    //id
    public string Email { get; set; } = default!;
    public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    public IEnumerable<OrderItem> Items { get; set; } = [];
    public OrderAddress Address { get; set; } = default!;
    public DeliveryMethod DeliveryMethod { get; set; } = default!;
    public int DeliverymethodId { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;
    public string PaymentIntentId { get; set; } =string.Empty;
    public decimal subtotal { get; set; }
}
