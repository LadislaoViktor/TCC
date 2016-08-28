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
    public partial class PesquisarFornecedor : Form
    {
        public PesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void txtBxFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void PesquisarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.winetechDataSet.fornecedor);

        }
    }
}
