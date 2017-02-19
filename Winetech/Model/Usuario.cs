using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;

namespace Winetech.Model
{
    class Usuario
    {
        public int CodigoUsuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public decimal cpfUsuario { get; set; }
        public string nomeCompleto { get; set; }
        public char statusUsuario { get; set; }
        public int codigoPerfil { get; set; }

        public Usuario(string login,string senha,decimal cpfUsuario,string nomeCompleto,char statusUsuario,int codigoPerfil)
        {
            this.login = login;
            this.senha = senha;
            this.cpfUsuario = cpfUsuario;
            this.nomeCompleto = nomeCompleto;
            this.statusUsuario = statusUsuario;
            this.codigoPerfil = codigoPerfil;
        }
        public Usuario(string login,string senha)
        {
            this.login = login;
            this.senha = senha;
        }
        public Usuario(string nomeCompleto) {
            this.nomeCompleto = nomeCompleto;
        }
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
            SqlConnection Conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Winetech\Winetech\Winetech.mdf;Integrated Security=False;Connect Timeout=30;User Instance=False");
            Conexao.Open();
            try
            {
                SqlCommand Comando = new SqlCommand("insert into usuario "+ " values (@llogin,@senha,@cpfUsuario,@nomeCompleto,@statusUsuario,@codigoPerfil)");
                Comando.Connection = Conexao;
                Comando.Parameters.AddWithValue("@llogin",usuario.login.ToString());
                Comando.Parameters.AddWithValue("@senha", usuario.senha.ToString());
                Comando.Parameters.AddWithValue("@cpfUsuario", cpfUsuario);
                Comando.Parameters.AddWithValue("@nomeCompleto", usuario.nomeCompleto.ToString());
                Comando.Parameters.AddWithValue("@statusUsuario", 'a');
                Comando.Parameters.AddWithValue("@codigoPerfil", usuario.codigoPerfil);
                int x =Comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                    MessageBox.Show(errorMessages.ToString());
                }
                return false;
            }
            catch   { 
                    MessageBox.Show("Não deu!","Não deu!",MessageBoxButtons.OK);
                        return false;
                    }
            finally {
                Conexao.Close();
            }
            
        }
    }
}
