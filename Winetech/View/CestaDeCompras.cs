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
    public partial class CestaDeCompras : Form
    {
        public CestaDeCompras()
        {
            InitializeComponent();
        }

        private void CestaDeCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.winetechDataSet.produto);

        }

        private void CestaDeCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
