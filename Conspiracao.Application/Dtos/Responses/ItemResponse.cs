using Conspiracao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Conspiracao.Application.Dtos.Responses
{
    public class ItemResponse
    {
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Desconto { get; set; }
        public string DescricaoItem { get; set; }
        public decimal ValorLiquido { get; set; }
        [JsonIgnore]
        public long PedidoId { get; set; }
        [JsonIgnore]
        public Pedido Pedido { get; set; }
    }
}
