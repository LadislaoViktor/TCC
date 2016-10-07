using System.Windows.Forms;
using System.Data.SqlClient;

namespace Winetech.Model
{
    class Usuario
    {
        //private TextBox txtBxLogin;
        //private TextBox txtBxSenha;
        //private TextBox txtBxCPF;
        //private TextBox txtBxNomeCompleto;
        //private char status;
        //private ComboBox cbBxFuncao;

        public int CodigoUsuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string cpfUsuario { get; set; }
        public string nomeCompleto { get; set; }
        public bool statusUsuario { get; set; }
        public int codigoFuncao { get; set; }

        public Usuario(string login,string senha,string cpfUsuario,string nomeCompleto,bool statusUsuario,int codigoFuncao)
        {
            this.login = login;
            this.senha = senha;
            this.cpfUsuario = cpfUsuario;
            this.statusUsuario = statusUsuario;
            this.codigoFuncao = codigoFuncao;

        }
        public Usuario(string login,string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        //public usuario(textbox txtbxlogin, textbox txtbxsenha, textbox txtbxcpf, textbox txtbxnomecompleto, char status, combobox cbbxfuncao)
        //{
        //    this.txtbxlogin = txtbxlogin;
        //    this.txtbxsenha = txtbxsenha;
        //    this.txtbxcpf = txtbxcpf;
        //    this.txtbxnomecompleto = txtbxnomecompleto;
        //    this.status = status;
        //    this.cbbxfuncao = cbbxfuncao;
        //}

        /*public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }*/

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
                MessageBox.Show("Não valida nada.");
                Conexao.Close();
            return true;
        }
        public bool cadastrarUsuario(Usuario usuario) {
            usuario.ToString();
            SqlConnection Conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;");
            Conexao.Open();
            SqlCommand Comando = new SqlCommand("insert into usuario(llogin,senha,cpfUsuario,nomecompleto,statusUsuario,codigoPerfil) values(@param,@param2,@param3,@param4,@param5,@param6)");
            Comando.Parameters.AddWithValue("@usuario.login", login);
            Comando.Parameters.AddWithValue("@usuario.senha", senha);
            Comando.Parameters.AddWithValue("@usuario.cpfUsuario", cpfUsuario);
            Comando.Parameters.AddWithValue("@usuario.nomeCompleto", nomeCompleto);
            Comando.Parameters.AddWithValue("@usuario.statusUsuario", statusUsuario);
            Comando.Parameters.AddWithValue("@usuario.codigoFuncao", codigoFuncao);
            Conexao.Close();
            return true;
        }
    }
}
