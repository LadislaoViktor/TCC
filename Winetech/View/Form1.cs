using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Controler.Controle_Login CL = new Controler.Controle_Login();
            if (CL.fazerLoginControl(txtBxLogin.ToString(), txtBxSenha.ToString()) == true)
            {
                MessageBox.Show("Login efetuado com sucesso!", "Informação!", MessageBoxButtons.OK);
                //Chamar tela inicial.
            }
            else
                MessageBox.Show("Verifique login e senha!", "Acesso negado!", MessageBoxButtons.OK);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
