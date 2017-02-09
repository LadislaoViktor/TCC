using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winetech.Controler;

namespace Winetech.View
{
    public partial class ClientePF : Form
    {
        public ClientePF()
        {
            InitializeComponent();
        }

        private void ClientePF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'winetechDataSet.cliente' table. You can move, or remove it, as needed.
            //this.clienteTableAdapter.Fill(this.winetechDataSet.cliente);
            // TODO: This line of code loads data into the 'winetechDataSet.enderecoCliente' table. You can move, or remove it, as needed.
//            this.enderecoClienteTableAdapter.Fill(this.winetechDataSet.enderecoCliente);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBxPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            TelaClientePJ PJ = new TelaClientePJ();
            PJ.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCliente PF = new PesquisarCliente();
            PF.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Controle_Cliente C=new Controle_Cliente();
            
        }

        private void ClientePF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
