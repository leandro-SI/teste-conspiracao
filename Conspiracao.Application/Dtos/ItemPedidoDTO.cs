using Conspiracao.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Conspiracao.Application.Dtos
{
    public class ItemPedidoDTO
    {

        [JsonIgnore]
        public long Id { get; set; }

        [Required(ErrorMessage = "Quantidade mínima Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser no mínimo 1")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Valor unitário é Requerido")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("ValorUnitario")]
        public decimal ValorUnitario { get; set; }
        public decimal Desconto { get; set; }

        [Required(ErrorMessage = "Descrição do item é Requerido")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Descricao")]
        public string DescricaoItem { get; set; }

        [JsonIgnore]
        [DisplayName("Pedido")]
        public long PedidoId { get; set; }
        [JsonIgnore]
        public Pedido Pedido { get; set; }


    }
}
