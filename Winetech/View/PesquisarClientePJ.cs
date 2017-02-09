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
    public partial class PesquisarClientePJ : Form
    {
        public PesquisarClientePJ()
        {
            InitializeComponent();
        }

        private void PesquisarClientePJ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.winetechDataSet.cliente);
            PesquisarClientePJ PJ = new PesquisarClientePJ();
        }

        private void PesquisarClientePJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
