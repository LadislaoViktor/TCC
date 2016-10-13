using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winetech.View;

namespace Winetech
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controler.Controle_Login CL = new Controler.Controle_Login(this.txtBxLogin.ToString(),this.txtBxSenha.ToString());
            if (CL.fazerLoginControl(this.txtBxLogin.ToString(), this.txtBxSenha.ToString())==true)
            {
                MessageBox.Show("Login efetuado com sucesso!", "Informação!", MessageBoxButtons.OK);
                TelaInicial T = new TelaInicial();
                T.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Verifique login e senha!", "Acesso negado!", MessageBoxButtons.OK);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicite o desbloqueio ao administrador!");
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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
