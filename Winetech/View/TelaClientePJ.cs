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
    public partial class TelaClientePJ : Form
    {
        public TelaClientePJ()
        {
            InitializeComponent();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void txtBxBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }

        private void TelaClientePJ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.fornecedor' table. You can move, or remove it, as needed.
           // this.fornecedorTableAdapter.Fill(this.winetechDataSet.fornecedor);
            // TODO: This line of code loads data into the 'winetechDataSet.enderecoFornecedor' table. You can move, or remove it, as needed.
            //this.enderecoFornecedorTableAdapter.Fill(this.winetechDataSet.enderecoFornecedor);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarClientePJ PJ = new PesquisarClientePJ();
            PJ.Show();
        }
    }
}
