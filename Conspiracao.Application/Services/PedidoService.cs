using AutoMapper;
using Conspiracao.Application.Dtos;
using Conspiracao.Application.Dtos.Responses;
using Conspiracao.Application.Helpers;
using Conspiracao.Application.Interfaces;
using Conspiracao.Domain.Entities;
using Conspiracao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        public PedidoResponse IncluirPedido(PedidoDTO pedidoDto)
        {
            var pedidoEntity = _mapper.Map<Pedido>(pedidoDto);

            var pedidoPersist = _pedidoRepository.IncluirPedido(pedidoEntity);

            return this.PedidoResponse(_mapper.Map<PedidoDTO>(pedidoPersist));
        }

        private PedidoResponse PedidoResponse(PedidoDTO pedidoDto)
        {

            var valorTotalItens = pedidoDto.ItemsPedido.Sum(i => i.Quantidade * (i.ValorUnitario - i.Desconto));

            var pedidoResponse = new PedidoResponse
            {
                NomeFornecedor = pedidoDto.NomeFornecedor.ToUpper(),
                NumeroPedido = PedidoHelpers.GerarNumeroPedido(),
                ValorTotal = valorTotalItens - pedidoDto.DescontoGeral,
                DescontoGeral = pedidoDto.DescontoGeral,
                ItemsPedido = _mapper.Map<List<ItemResponse>>(pedidoDto.ItemsPedido)
            };

            pedidoResponse.ItemsPedido = pedidoResponse.ItemsPedido.Select(item =>
            {
                item.ValorLiquido = (item.Quantidade * item.ValorUnitario) - item.Desconto;
                return item;
            }).ToList();

            return pedidoResponse;
        }
    }
}
