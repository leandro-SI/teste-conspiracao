using Conspiracao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Infra.Data.EntitiesConfiguration
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Quantidade)
                .IsRequired();
            builder.Property(i => i.ValorUnitario)
                .IsRequired();
            builder.Property(i => i.DescricaoItem)
                .HasMaxLength(100);

            builder.HasOne(i => i.Pedido)
                .WithMany(p => p.ItemsPedido)
                .HasForeignKey(i => i.PedidoId);
        }
    }
}
