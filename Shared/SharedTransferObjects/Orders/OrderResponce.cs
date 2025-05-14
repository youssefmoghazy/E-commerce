using Shared.SharedTransferObjects.Authentication;
namespace Shared.SharedTransferObjects.Orders;
public record OrderResponce
{
    public Guid id {  get; set; }
    public string UserEmail { get; set; } = default!;
    public DateTimeOffset Date { get; set; }
    public IEnumerable<OrderItemDTO> Items { get; set; } = default!;
    public AddressDTO Address { get; set; } = default!;
    public string DeliveryMethod {  get; set; }
    public string paymentStatus { get; set; }
    public string PaymentIntenId { get; set; } = string.Empty;
    public decimal subtotal { get; set; }
    public decimal total { get; set; }

}
public record OrderItemDTO
{
    public string PictureUrl { get; set; }
    public string ProductName { get; set; }
    public decimal price { get; set; }
    public int Quantity { get; set; }
}