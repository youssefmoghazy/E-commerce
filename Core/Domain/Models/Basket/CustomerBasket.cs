namespace Domain.Models.Basket;

public class CustomerBasket
{
    public string id { get; set; } // create from the client
    public ICollection<BasketItem> BasketItems { get; set; } = [];

}
