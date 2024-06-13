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
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomeFornecedor)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasMany(p => p.ItemsPedido)
                .WithOne(i => i.Pedido)
                .HasForeignKey(i => i.PedidoId);
        }
    }
}
