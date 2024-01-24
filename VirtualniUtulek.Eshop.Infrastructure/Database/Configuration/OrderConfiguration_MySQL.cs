using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VirtualniUtulek.Eshop.Domain.Entities;

namespace VirtualniUtulek.Eshop.Infrastructure.Database.Configuration
{
    public class OrderConfiguration_MySQL : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(nameof(Order.DateTimeCreated))
                .HasDefaultValueSql("NOW(6)");
        }
    }
}
