using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winetech.Controler;
using Winetech.Model;

namespace Winetech.View
{
    public partial class frmUsuários : Form
    {
        public frmUsuários()
        {
            InitializeComponent();
        }

        private void cbBxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Controle_de_Usuários_Load(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("codigoPerfil");
            DataColumn dc1 = new DataColumn("descricaoPerfil");
            dt.Columns.Add(dc1);
            dt.Rows.Add("Administrador");
            cbBxPerfil.DataSource = dt;
            // TODO: This line of code loads data into the 'winetechDataSet.perfil' table. You can move, or remove it, as needed.
           cbBxPerfil.DataSource= this.perfilTableAdapter.Fill(this.winetechDataSet.perfil);
            // TODO: This line of code loads data into the 'winetechDataSet.funcoes' table. You can move, or remove it, as needed.
            cbBxFuncao.DataSource= this.funcoesTableAdapter.Fill(this.winetechDataSet.funcoes);
            // TODO: This line of code loads data into the 'winetechDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.winetechDataSet.usuario);
            */
            cbBxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBxPerfil.DataSource = opcaoPerfil();
            cbBxPerfil.ValueMember = "codigoPerfil";
            cbBxPerfil.DisplayMember = "descricaoPerfil";
            cbBxPerfil.Update();

            cbBxFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBxFuncao.DataSource = opcaoFuncoes();
            cbBxFuncao.ValueMember = "codigoFuncao";
            cbBxFuncao.DisplayMember = "descricaoFuncao";
            cbBxFuncao.Update();

            cbBxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBxTipo.DataSource = Tipo();
            cbBxTipo.ValueMember = "codigoFuncao";
            cbBxTipo.DisplayMember = "tipo";
            cbBxTipo.Update();
        }
        public DataTable opcaoPerfil()
        {
            DataTable dtPerfil = new DataTable("Perfil");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Winetech\Winetech\Winetech.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False"))
            using (SqlCommand Command = new SqlCommand("SELECT codigoPerfil,descricaoPerfil FROM dbo.perfil", Connection))
            {
                Connection.Open();
                dtPerfil.Load(Command.ExecuteReader());
            }
            return dtPerfil;
        }
        public DataTable opcaoFuncoes()
        {
            DataTable dtFuncoes = new DataTable("Funcoes");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Winetech\Winetech\Winetech.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False"))
            using (SqlCommand Command = new SqlCommand("SELECT codigoFuncao,descricaofuncao FROM dbo.funcoes", Connection))
            {
                Connection.Open();
                dtFuncoes.Load(Command.ExecuteReader());
            }
            return dtFuncoes;
        }
        public DataTable Tipo()
        {
            DataTable dtFuncoes = new DataTable("Funcoes");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Winetech\Winetech\Winetech.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False"))
            using (SqlCommand Command = new SqlCommand("SELECT codigoFuncao,tipo FROM dbo.Funcoes", Connection))
            {
                Connection.Open();
                dtFuncoes.Load(Command.ExecuteReader());
            }
            return dtFuncoes;
        }
        private void chkBxAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtBxLogin.ToString(),txtBxSenha.ToString(),txtBxCPF.ToString(),txtBxNomeCompleto.ToString(),true,1);
            ControleUsuarios U = new ControleUsuarios();
            bool cadastro =U.cadastrarUsuários(usuario);
            if (cadastro == true)
            {
                MessageBox.Show("Inserido com sucesso!");
            }
            else
                MessageBox.Show("Falha ao inserir: Verifique os dados e tente novamente!");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPesquisarUsuários P=new frmPesquisarUsuários();
            P.Show();
            /*  string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Winetech\\Winetech\\Winetech.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
              SqlConnection conexao = new SqlConnection(strcon);
              //SqlCommand cmd = new SqlCommand("INSERT INTO usuario VALUES('aaa'","111"," ",")",
               //   conexao); 
               Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4,
              é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados,
              a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
  Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                button2_Click(sender, e);
                chama o evento do click do button2 (na verdade é como se o button2 tivesse sido clicado, ou botão select do form2)sempre que quiser fazer com que ocorra um evento sem que o usuário tenha feito, é só passar o comando acima (se tiver duvida dê com copiar no "private void button2_Click(object sender, EventArgs e)" e deixe do jeito que eu modifiquei) o evento que ocorre quando clicamos no button2 é aquele que busca as informações no banco de dados e depois preenche o DataGridView com elas, ao usar button2_Click(sender, e); estamos fazendo com que aconteça exatamente isso, ao clicarmos no botão Insert ou Delete vai parecer q o campo inserido ou deletado no datagridview foi inserido ou deletado na mesma hora. Experimente comentar a linha button2_Click(sender, e); para ver a diferença. 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
*/
        }
        private void frmUsuarios_FormClosing(Object sender, FormClosingEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
        }
        char Status;
        private void rdBtnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            Status = 'A';
        }

        private void rdBtnInativo_CheckedChanged(object sender, EventArgs e)
        {
            Status = 'I';
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.perfilTableAdapter.FillBy(this.winetechDataSet.perfil);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.perfilTableAdapter.FillBy(this.winetechDataSet.perfil);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
