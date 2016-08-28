using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winetech.View
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.pedidoFornecedor' table. You can move, or remove it, as needed.
            this.pedidoFornecedorTableAdapter.Fill(this.winetechDataSet.pedidoFornecedor);
            // TODO: This line of code loads data into the 'winetechDataSet.itensPedidoFornecedor' table. You can move, or remove it, as needed.
            this.itensPedidoFornecedorTableAdapter.Fill(this.winetechDataSet.itensPedidoFornecedor);
            // TODO: This line of code loads data into the 'winetechDataSet.pedidoCliente' table. You can move, or remove it, as needed.
            this.pedidoClienteTableAdapter.Fill(this.winetechDataSet.pedidoCliente);

        }

        private void lblFornecedor_Click(object sender, EventArgs e)
        {

        }
    }
}
