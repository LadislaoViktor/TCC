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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.pedidoCliente' table. You can move, or remove it, as needed.
            // this.pedidoClienteTableAdapter.Fill(this.winetechDataSet.pedidoCliente);

        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            CestaDeCompras C = new CestaDeCompras();
            C.Show();
        }

        private void Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
