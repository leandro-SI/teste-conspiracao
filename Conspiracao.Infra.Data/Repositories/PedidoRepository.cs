using Conspiracao.Domain.Entities;
using Conspiracao.Domain.Interfaces;
using Conspiracao.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Infra.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ConspiracaoDbContext _context;

        public PedidoRepository(ConspiracaoDbContext context)
        {
            _context = context;
        }

        public Pedido IncluirPedido(Pedido pedido)
        {

            //Lógica para incluir pedido no banco de dados
            //await _context.Add(pedido);
            //_context.SaveChangesAsync();
            return pedido;
        }
    }
}
