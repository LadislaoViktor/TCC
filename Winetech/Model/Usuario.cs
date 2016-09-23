using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winetech.Model
{
    class Usuario
    {
        private TextBox txtBxLogin;
        private TextBox txtBxSenha;
        private TextBox txtBxCPF;
        private TextBox txtBxNomeCompleto;
        private char status;
        private ComboBox cbBxFuncao;

        private int CodigoUsuario { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string cpfUsuario { get; set; }
        private string nomeCompleto { get; set; }
        private bool statusUsuario { get; set; }
        private int codigoFuncao { get; set; }

        public Usuario(TextBox txtBxLogin, TextBox txtBxSenha, TextBox txtBxCPF, TextBox txtBxNomeCompleto, char status, ComboBox cbBxFuncao)
        {
            this.txtBxLogin = txtBxLogin;
            this.txtBxSenha = txtBxSenha;
            this.txtBxCPF = txtBxCPF;
            this.txtBxNomeCompleto = txtBxNomeCompleto;
            this.status = status;
            this.cbBxFuncao = cbBxFuncao;
        }

        private bool validarLogin(string login, string senha)
        {

            return true;
        }
        private bool cadastrarUsuario() {

            return true;
        }
    }
}
