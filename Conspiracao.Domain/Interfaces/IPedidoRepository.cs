using Conspiracao.Domain.Entities;

namespace Conspiracao.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Pedido IncluirPedido(Pedido pedido);
    }
}
