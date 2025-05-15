namespace Domain.Models.Basket;

public class CustomerBasket
{
    public string id { get; set; } // create from the client
    public ICollection<BasketItem> BasketItems { get; set; } = [];
    public string? PaymentIntentId { get; init; }
    public string? ClientSecret { get; init; }
    public int? DeliveryMethodId { get; init; }
    public decimal ShippingPrice { get; init; }
}
