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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.safra' table. You can move, or remove it, as needed.
            //this.safraTableAdapter.Fill(this.winetechDataSet.safra);
            // TODO: This line of code loads data into the 'winetechDataSet.pais' table. You can move, or remove it, as needed.
            //this.paisTableAdapter.Fill(this.winetechDataSet.pais);

        }

        private void Estoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (resultado == DialogResult.No)
            {
                this.Show();
            }
            if (resultado == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
