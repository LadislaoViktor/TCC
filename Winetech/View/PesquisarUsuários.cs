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
            // TODO: This line of code loads data into the 'winetechDataSet.usuario' table. You can move, or remove it, as needed.
            //this.usuarioTableAdapter.Fill(this.winetechDataSet.usuario);

        }

        private void dtGdVDadosUsuários_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                //C.pesquisarusuario(nome);
                //if(ArrayList diferente de null)
                //preenche grid
                //else
                //messagebox nome não enontrado
                MessageBox.Show("Preencher Data Grid com o retorno da função!");
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
