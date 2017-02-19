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
    public partial class TelaInicial : Form 
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientePF C = new ClientePF();
            C.Show();
            if (C.IsDisposed == false)
            {
                this.Show();
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras C = new Compras();
            C.Show();
            if (C.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fornecedor F = new Fornecedor();
            F.Show();
            if (F.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas V = new Vendas();
            V.Show();
            if (V.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estoque E = new Estoque();
            E.Show();
            if (E.IsAccessible == false)
            {
                this.Show();
            }
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }*/
            Application.Exit();

        }

        private void btnProducao_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorioFaturamento_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
