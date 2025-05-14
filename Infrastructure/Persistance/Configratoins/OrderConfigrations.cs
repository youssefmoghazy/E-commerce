using Order = Domain.Models.OrderModels.Order;
namespace Persistance.Configratoins;

public class OrderConfigrations : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("orders");
        builder.Property(d => d.subtotal)
            .HasColumnType("decimal(8,2)");
        builder.HasMany(o => o.Items)
            .WithOne();
        builder.OwnsOne(x => x.Address, x => x.WithOwner());

    }
}
