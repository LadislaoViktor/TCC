using System;
using System.Linq;
using System.Windows.Forms;

namespace Winetech.View
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnRelatorioFaturamento = new System.Windows.Forms.Button();
            this.btnProducao = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRelatorioEstoque = new System.Windows.Forms.Button();
            this.flwLPInicial = new System.Windows.Forms.FlowLayoutPanel();
            this.flwLPInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = true;
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(122, 105);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(131, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(122, 105);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(131, 114);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(122, 105);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(3, 114);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(122, 105);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnRelatorioFaturamento
            // 
            this.btnRelatorioFaturamento.Location = new System.Drawing.Point(387, 114);
            this.btnRelatorioFaturamento.Name = "btnRelatorioFaturamento";
            this.btnRelatorioFaturamento.Size = new System.Drawing.Size(122, 105);
            this.btnRelatorioFaturamento.TabIndex = 4;
            this.btnRelatorioFaturamento.Text = "Relatório Faturamento";
            this.btnRelatorioFaturamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorioFaturamento.UseVisualStyleBackColor = false;
            // 
            // btnProducao
            // 
            this.btnProducao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProducao.Location = new System.Drawing.Point(3, 225);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(122, 105);
            this.btnProducao.TabIndex = 5;
            this.btnProducao.Text = "Produção";
            this.btnProducao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducao.UseVisualStyleBackColor = false;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(259, 3);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(122, 105);
            this.btnFornecedores.TabIndex = 6;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(387, 3);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(122, 105);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(259, 114);
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(122, 105);
            this.btnRelatorioEstoque.TabIndex = 8;
            this.btnRelatorioEstoque.Text = "Relatorio Estoque";
            this.btnRelatorioEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorioEstoque.UseVisualStyleBackColor = true;
            // 
            // flwLPInicial
            // 
            this.flwLPInicial.BackgroundImage = global::Winetech.Properties.Resources.vinho;
            this.flwLPInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flwLPInicial.Controls.Add(this.btnUsuarios);
            this.flwLPInicial.Controls.Add(this.btnClientes);
            this.flwLPInicial.Controls.Add(this.btnFornecedores);
            this.flwLPInicial.Controls.Add(this.btnEstoque);
            this.flwLPInicial.Controls.Add(this.btnCompras);
            this.flwLPInicial.Controls.Add(this.btnVendas);
            this.flwLPInicial.Controls.Add(this.btnRelatorioEstoque);
            this.flwLPInicial.Controls.Add(this.btnRelatorioFaturamento);
            this.flwLPInicial.Controls.Add(this.btnProducao);
            this.flwLPInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwLPInicial.Location = new System.Drawing.Point(0, 0);
            this.flwLPInicial.Name = "flwLPInicial";
            this.flwLPInicial.Size = new System.Drawing.Size(561, 406);
            this.flwLPInicial.TabIndex = 9;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 406);
            this.Controls.Add(this.flwLPInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.flwLPInicial.ResumeLayout(false);
            this.flwLPInicial.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            /* frmUsuários C = new frmUsuários();
             C.Show();
             C.Close();*/
            if (Application.OpenForms.OfType<frmUsuários>().Count() > 0)
            {
                MessageBox.Show("O Formulario de usuários já está aberto!");
            }
            else
            {
                frmUsuários form = new frmUsuários();
                form.Show();
                while (form.IsAccessible)
                {

                }
                
            }
            TelaInicial.ActiveForm.Activate();
        }

        private void C_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void C_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnRelatorioFaturamento;
        private System.Windows.Forms.Button btnProducao;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRelatorioEstoque;
        private FlowLayoutPanel flwLPInicial;
    }
}