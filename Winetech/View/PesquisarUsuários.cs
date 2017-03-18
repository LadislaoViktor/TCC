using System;
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
            WinetechEntities ctx = new WinetechEntities();
        }

        private void dtGdVDadosUsuários_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtGdVDadosUsuários.DataSource = usuarioBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           usuario usuarios = new usuario(txtBxPesquisarUsuarios.ToString());
            ControleUsuarios C = new ControleUsuarios();
            if (C.verificaCampoPreenchido(usuarios) == false)
            {
                MessageBox.Show("O nome não pode estar em branco!");
            }
            else {
                C.pesquisarusuario(txtBxPesquisarUsuarios.Text.ToString());
                if (C.pesquisarusuario(txtBxPesquisarUsuarios.Text.ToString()) == null)
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
                else {
                    dtGdVDadosUsuários.DataSource = C.pesquisarusuario(txtBxPesquisarUsuarios.Text.ToString());
                }
                
            }
        }

        private void frmPesquisarUsuários_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
