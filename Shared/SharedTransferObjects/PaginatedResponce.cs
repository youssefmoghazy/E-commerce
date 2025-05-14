namespace Shared.SharedTransferObjects;

public record PaginatedResponce<TEntity>(int PageIndex , int PageSize, int TotalCount, IEnumerable<TEntity> Data);
