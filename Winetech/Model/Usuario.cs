using System.Windows.Forms;
using System.Data.SqlClient;

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

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public bool validarLogin(Usuario u)
        {
            
            SqlConnection Conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Winetech\Winetech\Winetech.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
                Conexao.Open();
                SqlCommand Comando = new SqlCommand("Insert into ",Conexao);
            SqlDataReader LeitorDados = Comando.ExecuteReader();
            while(LeitorDados.Read()){
                MessageBox.Show("Alguma coisa.");
            }
                Conexao.Close();
           /* if (Comando.)
            {
                return true;
            }
            else*/
            return true;
        }
        public bool cadastrarUsuario(Usuario usuario) {
            SqlConnection Conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Winetech\Winetech\Winetech.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
            Conexao.Open();
            SqlCommand Comando = new SqlCommand("insert into usuario values(3,'admin','admin','12345678909','Victor Schena','A',2)", Conexao);
            Conexao.Close();
            MessageBox.Show("Alguma coisa.");
            return true;
        }
    }
}
