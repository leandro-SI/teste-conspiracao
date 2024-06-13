﻿using Conspiracao.Application.Dtos;
using Conspiracao.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Application.Interfaces
{
    public interface IPedidoService
    {
        PedidoResponse IncluirPedido(PedidoDTO pedidoDto);
    }
}
