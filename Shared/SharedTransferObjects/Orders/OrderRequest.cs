using Shared.SharedTransferObjects.Authentication;

namespace Shared.SharedTransferObjects.Orders;

public record OrderRequest(string BasketId, AddressDTO Address, int DelivaryMethodId);
