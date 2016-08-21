using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Winetech.Database
{
    class Conexao
    {
        // vamos nos conectar ao SQL Server Express e à base de dados
        // locadora usando Windows Authentication
        private static string connString = @"server = .\sqlexpress;
    Database = teste;
    integrated security = true;";

        // representa a conexão com o banco
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException sqle)
            {
                conn = null;
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // vamos obter a conexão com o banco de dados
            SqlConnection conn = Conexao.obterConexao();

            // a conexão foi efetuada com sucesso?
            if (conn == null)
            {
                System.Windows.Forms.MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }
            else {
              System.Windows.Forms.MessageBox.Show("A conexão foi obtida com sucesso.");
            }

            // não precisamos mais da conexão? vamos fechá-la
            Conexao.fecharConexao();
        }
    }
}
