using System;
using System.Data;
using System.Data.SqlClient;
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
        private void Controle_de_Usuários_Load(object sender, EventArgs e)
        {
            cbBxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBxPerfil.DataSource = opcaoPerfil();
            cbBxPerfil.ValueMember = "codigoPerfil";
            cbBxPerfil.DisplayMember = "descricaoPerfil";
            cbBxPerfil.Update();

        }
        public DataTable opcaoPerfil()
        {
            DataTable dtPerfil = new DataTable("perfil");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=C:\Winetech\Winetech\Winetech2.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=False"))
            using (SqlCommand Command = new SqlCommand("SELECT codigoPerfil,descricaoPerfil FROM perfil", Connection))
            {
                Connection.Open();
                dtPerfil.Load(Command.ExecuteReader());
            }
            return dtPerfil;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            perfil p = new perfil(Convert.ToInt32(cbBxPerfil.SelectedIndex), cbBxPerfil.SelectedText.ToString());
            usuario umusuario = new usuario(5, txtBxLogin.Text.ToString(), txtBxSenha.Text.ToString(), txtBxCPF.Text.ToString(), txtBxNomeCompleto.Text.ToString(), rdBtnAtivo.Checked,p );
                    ControleUsuarios U = new ControleUsuarios();
                    bool cadastro = U.cadastrarUsuários(umusuario);
                    if (cadastro == true)
                    {
                        MessageBox.Show("Inserido com sucesso!");
                    }
                    else
                        MessageBox.Show("Falha ao inserir: Todos os campos são obrigatórios!");
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

        private void frmUsuários_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar todos os campos?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                txtBxNomeCompleto.Text="";
                txtBxCPF.Text = "";
                txtBxLogin.Text = "";
                txtBxSenha.Text = "";
                rdBtnAtivo.Checked = false;
                rdBtnInativo.Checked = false;
            }
        }

        private void cbBxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkBxResetarSenha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
