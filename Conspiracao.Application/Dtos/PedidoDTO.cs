using Conspiracao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Conspiracao.Application.Dtos
{
    public class PedidoDTO
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O Nome do Fornecedor é Requerido")]
        [MinLength(3)]
        [MaxLength(200, ErrorMessage = "O nome do fornecedor não pode exceder 200 caracteres.")]
        public string NomeFornecedor { get; set; }
        public decimal DescontoGeral { get; set; }
        public ICollection<ItemPedidoDTO> ItemsPedido { get; set; }
    }
}
