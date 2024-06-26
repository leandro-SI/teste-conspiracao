﻿using AutoMapper;
using Conspiracao.Application.Dtos;
using Conspiracao.Application.Dtos.Responses;
using Conspiracao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Pedido, PedidoDTO>().ReverseMap();
            CreateMap<ItemPedidoDTO, ItemResponse>().ReverseMap();
            CreateMap<ItemPedido, ItemPedidoDTO>().ReverseMap();
        }
    }
}
