namespace Shared.SharedTransferObjects.Basket;

public record BasketDTO
{
    public string Id { get; init; }
    public ICollection<BasketItemDTO> Items { get; init; } = [];

}
