using System.ComponentModel.DataAnnotations;

namespace Shared.SharedTransferObjects.Basket;

public record BasketItemDTO
{
    public int Id { get; init; }
    public string Name { get; init; } = default!;
    public string ProductUrl { get; init; } = default!;
    [Range(0,double.MaxValue)]
    public decimal Price { get; init; }
    public int Quantity { get; init; }
}