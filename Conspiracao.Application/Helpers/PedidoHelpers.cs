using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conspiracao.Application.Helpers
{
    public static class PedidoHelpers
    {
        public static int GerarNumeroPedido()
        {
            Random random = new Random();

            return random.Next(0, 99999);
        }
    }
}
