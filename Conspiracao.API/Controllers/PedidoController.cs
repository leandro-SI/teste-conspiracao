﻿using Conspiracao.Application.Dtos;
using Conspiracao.Application.Interfaces;
using Conspiracao.Domain.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conspiracao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {

        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        /// <summary>
        /// Gerar um novo pedido
        /// </summary>
        /// <param name="pedidoDto">Dados do Pedido</param>
        /// <returns>Objeto criado</returns>
        /// <response code="400">Objeto inválido</response>
        /// <response code="200">Sucesso</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult IncluirPedido([FromBody] PedidoDTO pedidoDto)
        {

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (pedidoDto == null)
                    return BadRequest("Invalid Data");

                var pedido = _pedidoService.IncluirPedido(pedidoDto);

                return Ok(pedido);

            }
            catch (DomainExceptionValidation error)
            {
                throw new DomainExceptionValidation(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }
    }
}
