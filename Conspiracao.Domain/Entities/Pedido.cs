using Conspiracao.Domain.Validation;

namespace Conspiracao.Domain.Entities
{
    public sealed class Pedido : EntityBase
    {
        public string NomeFornecedor { get; private set; }
        public decimal DescontoGeral { get; set; }
        public ICollection<ItemPedido> ItemsPedido { get; set; } = new List<ItemPedido>();

        public Pedido(string nomeFornecedor, ICollection<ItemPedido> itemsPedido)
        {
            ValidationDomain(nomeFornecedor, itemsPedido);
        }

        private void ValidationDomain(string nomeFornecedor, ICollection<ItemPedido> itemsPedido)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nomeFornecedor),
                "Nome do Fornecedor inválido. Nome é requerido.");

            DomainExceptionValidation.When(nomeFornecedor.Length > 200,
                "Nome do Fornecedor inválido. máximo de caracteres é 200.");

            DomainExceptionValidation.When(itemsPedido is null,
                "Items pedido inválido, o pedido deve conter no mínimo 1 item.");

            DomainExceptionValidation.When(itemsPedido.Count <= 0,
                "Items pedido inválido, o pedido deve conter no mínimo 1 item.");

            NomeFornecedor = nomeFornecedor;
            ItemsPedido = itemsPedido;
        }
    }
}
