using Conspiracao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Application.Dtos.Responses
{
    public class PedidoResponse
    {
        public long Id { get; set; }
        public int NumeroPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string NomeFornecedor { get; set; }
        public decimal DescontoGeral { get; set; }
        public ICollection<ItemPedidoDTO> ItemsPedido { get; set; }
    }
}
