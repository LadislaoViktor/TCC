using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winetech.Controler;
using Winetech.Model;

namespace Winetech.View
{
    public partial class frmPesquisarUsuários : Form
    {
        public frmPesquisarUsuários()
        {
            InitializeComponent();
        }

        private void frmPesquisarUsuários_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.usuario' table. You can move, or remove it, as needed.
            //this.usuarioTableAdapter.Fill(this.winetechDataSet.usuario);

        }

        private void dtGdVDadosUsuários_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtBxPesquisarUsuarios.ToString());
            ControleUsuarios C = new ControleUsuarios();
            if (C.pesquisarUsuarios(usuario) == null)
            {
                MessageBox.Show("O nome não pode estar em branco!");
            }
            else {
                MessageBox.Show("Prencher linhas da tabela.");
            }

        }

        private void frmPesquisarUsuários_FormClosing(object sender, FormClosingEventArgs e)
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
