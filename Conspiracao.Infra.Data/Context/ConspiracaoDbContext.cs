using Conspiracao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Infra.Data.Context
{
    public class ConspiracaoDbContext : DbContext
    {
        public ConspiracaoDbContext(DbContextOptions<ConspiracaoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemsPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConspiracaoDbContext).Assembly);
        }
    }
}
