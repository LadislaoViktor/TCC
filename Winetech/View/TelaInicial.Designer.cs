﻿using System;

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
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(56, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(122, 105);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(227, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(122, 105);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(227, 156);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(122, 105);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(56, 156);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(122, 105);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioFaturamento
            // 
            this.btnRelatorioFaturamento.Location = new System.Drawing.Point(56, 289);
            this.btnRelatorioFaturamento.Name = "btnRelatorioFaturamento";
            this.btnRelatorioFaturamento.Size = new System.Drawing.Size(122, 105);
            this.btnRelatorioFaturamento.TabIndex = 4;
            this.btnRelatorioFaturamento.Text = "Relatório Faturamento";
            this.btnRelatorioFaturamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorioFaturamento.UseVisualStyleBackColor = true;
            // 
            // btnProducao
            // 
            this.btnProducao.Location = new System.Drawing.Point(227, 289);
            this.btnProducao.Name = "btnProducao";
            this.btnProducao.Size = new System.Drawing.Size(122, 105);
            this.btnProducao.TabIndex = 5;
            this.btnProducao.Text = "Produção";
            this.btnProducao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducao.UseVisualStyleBackColor = true;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(387, 12);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(122, 105);
            this.btnFornecedores.TabIndex = 6;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedores.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(387, 156);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(122, 105);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(387, 289);
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(122, 105);
            this.btnRelatorioEstoque.TabIndex = 8;
            this.btnRelatorioEstoque.Text = "Relatorio Estoque";
            this.btnRelatorioEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorioEstoque.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 406);
            this.Controls.Add(this.btnRelatorioEstoque);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnProducao);
            this.Controls.Add(this.btnRelatorioFaturamento);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsuários C = new frmUsuários();
            C.Show();
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
    }
}