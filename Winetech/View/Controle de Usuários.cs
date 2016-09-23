﻿using System;
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
            // TODO: This line of code loads data into the 'winetechDataSet.funcoes' table. You can move, or remove it, as needed.
            this.funcoesTableAdapter.Fill(this.winetechDataSet.funcoes);
            // TODO: This line of code loads data into the 'winetechDataSet.usuario' table. You can move, or remove it, as needed.
            // this.usuarioTableAdapter.Fill(this.winetechDataSet.usuario);

        }

        private void chkBxAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario U = new Usuario(txtBxLogin,txtBxSenha,txtBxCPF,txtBxNomeCompleto,Status,cbBxFuncao );
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
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
    }
}
