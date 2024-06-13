using Conspiracao.Domain.Validation;

namespace Conspiracao.Domain.Entities
{
    public sealed class ItemPedido : EntityBase
    {
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal Desconto { get; private set; }
        public string DescricaoItem { get; private set; }
        public long PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public ItemPedido()
        {
            
        }

        public ItemPedido(int quantidade, decimal valorUnitario, decimal desconto, string descricao, long pedidoId)
        {
            ValidationDomain(quantidade, valorUnitario, desconto, descricao, pedidoId);
        }

        private void ValidationDomain(int quantidade, decimal valorUnitario, decimal desconto, string descricao, long pedidoId)
        {
            DomainExceptionValidation.When(quantidade <= 0,
                "Quantidade inválida. quantidade mínima 1");

            DomainExceptionValidation.When(valorUnitario <= 0,
                "Valor unitário inválido.");

            DomainExceptionValidation.When(desconto < 0,
                "Desconto inválido.");

            DomainExceptionValidation.When(descricao.Length < 5,
                "Descrição inválida, o tamando mínimo é de 3 caracteres.");

            DomainExceptionValidation.When(descricao.Length > 100,
                "Descrição inválida, o tamando máximo é de 100 caracteres.");
            DomainExceptionValidation.When(pedidoId <= 0,
                "Identificador do pedido inválido.");

            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            Desconto = desconto;
            DescricaoItem = descricao;
            PedidoId = pedidoId;

        }
    }
}
