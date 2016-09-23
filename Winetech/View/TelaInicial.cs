﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winetech.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientePF C = new ClientePF();
            C.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras C = new Compras();
            C.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedor F = new Fornecedor();
            F.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Vendas V = new Vendas();
            V.Show();
           
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque E = new Estoque();
            E.ShowDialog();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
