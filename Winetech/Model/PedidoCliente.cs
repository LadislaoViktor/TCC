using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winetech.Model
{
    class PedidoCliente
    {
        private int codigoPedido { get; set; }
        private DateTime dataPedido { get; set; }
        private char statusPedido { get; set; }
        private char statusPagamentoPeido { get; set; }
        private int quantidade { get; set; }
        private decimal precoUnitario { get; set; }
        private decimal totalPedido { get; set; }
    }
}
