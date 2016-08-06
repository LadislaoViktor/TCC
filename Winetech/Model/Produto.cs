using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winetech.Model
{
    class Produto
    {
        private int codigoProduto { get; set; }
        private string nome { get; set; }
        private string descricao { get; set; }
        private string uva { get; set; }
        private string classe { get; set; }
        private char teorAlcolico { get; set; }
        private string tipo { get; set; }
        private decimal custoUnitario { get; set; }
        private int quantidadeEstoque { get; set; }
        private decimal precoVenda { get; set; }
        private string unidade { get; set; }
        private DateTime datavalidade { get; set; }
        private int codigopais { get; set; }
        private int codigosafra { get; set; }
    }
}
