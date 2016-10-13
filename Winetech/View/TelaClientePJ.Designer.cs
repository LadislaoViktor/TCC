namespace Winetech.View
{
    partial class TelaClientePJ
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
            this.components = new System.ComponentModel.Container();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblLimiteDeCredito = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkBxAtivo = new System.Windows.Forms.CheckBox();
            this.chkBxInativo = new System.Windows.Forms.CheckBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBxRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtBxNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtBxCNPJ = new System.Windows.Forms.TextBox();
            this.txtBxLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxTelefone = new System.Windows.Forms.TextBox();
            this.txtBxBairro = new System.Windows.Forms.TextBox();
            this.txtBxCEP = new System.Windows.Forms.TextBox();
            this.txtBxRua = new System.Windows.Forms.TextBox();
            this.txtBxNumero = new System.Windows.Forms.TextBox();
            this.txtBxComplemento = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbBxEstado = new System.Windows.Forms.ComboBox();
            this.fKCodigoEnderecoFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.enderecoFornecedorTableAdapter = new Winetech.WinetechDataSetTableAdapters.enderecoFornecedorTableAdapter();
            this.fornecedorTableAdapter = new Winetech.WinetechDataSetTableAdapters.fornecedorTableAdapter();
            this.cbBxCidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fKCodigoEnderecoFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(13, 13);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(13, 44);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 1;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(13, 75);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblLimiteDeCredito
            // 
            this.lblLimiteDeCredito.AutoSize = true;
            this.lblLimiteDeCredito.Location = new System.Drawing.Point(254, 75);
            this.lblLimiteDeCredito.Name = "lblLimiteDeCredito";
            this.lblLimiteDeCredito.Size = new System.Drawing.Size(88, 13);
            this.lblLimiteDeCredito.TabIndex = 3;
            this.lblLimiteDeCredito.Text = "Limite de Crédito:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // chkBxAtivo
            // 
            this.chkBxAtivo.AutoSize = true;
            this.chkBxAtivo.Location = new System.Drawing.Point(64, 140);
            this.chkBxAtivo.Name = "chkBxAtivo";
            this.chkBxAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkBxAtivo.TabIndex = 6;
            this.chkBxAtivo.Text = "Ativo";
            this.chkBxAtivo.UseVisualStyleBackColor = true;
            // 
            // chkBxInativo
            // 
            this.chkBxInativo.AutoSize = true;
            this.chkBxInativo.Location = new System.Drawing.Point(120, 140);
            this.chkBxInativo.Name = "chkBxInativo";
            this.chkBxInativo.Size = new System.Drawing.Size(58, 17);
            this.chkBxInativo.TabIndex = 7;
            this.chkBxInativo.Text = "Inativo";
            this.chkBxInativo.UseVisualStyleBackColor = true;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 176);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 219);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(198, 220);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(363, 219);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(16, 270);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(198, 270);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 13;
            this.lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(363, 270);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(16, 318);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 15;
            this.lblComplemento.Text = "Complemento:";
            this.lblComplemento.Click += new System.EventHandler(this.lblComplemento_Click);
            // 
            // txtBxRazaoSocial
            // 
            this.txtBxRazaoSocial.Location = new System.Drawing.Point(92, 12);
            this.txtBxRazaoSocial.Name = "txtBxRazaoSocial";
            this.txtBxRazaoSocial.Size = new System.Drawing.Size(384, 20);
            this.txtBxRazaoSocial.TabIndex = 16;
            // 
            // txtBxNomeFantasia
            // 
            this.txtBxNomeFantasia.Location = new System.Drawing.Point(92, 44);
            this.txtBxNomeFantasia.Name = "txtBxNomeFantasia";
            this.txtBxNomeFantasia.Size = new System.Drawing.Size(384, 20);
            this.txtBxNomeFantasia.TabIndex = 17;
            // 
            // txtBxCNPJ
            // 
            this.txtBxCNPJ.Location = new System.Drawing.Point(92, 75);
            this.txtBxCNPJ.Name = "txtBxCNPJ";
            this.txtBxCNPJ.Size = new System.Drawing.Size(140, 20);
            this.txtBxCNPJ.TabIndex = 18;
            // 
            // txtBxLimiteDeCredito
            // 
            this.txtBxLimiteDeCredito.Location = new System.Drawing.Point(348, 75);
            this.txtBxLimiteDeCredito.Name = "txtBxLimiteDeCredito";
            this.txtBxLimiteDeCredito.Size = new System.Drawing.Size(128, 20);
            this.txtBxLimiteDeCredito.TabIndex = 19;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(92, 107);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(140, 20);
            this.txtBxEmail.TabIndex = 20;
            // 
            // txtBxTelefone
            // 
            this.txtBxTelefone.Location = new System.Drawing.Point(92, 176);
            this.txtBxTelefone.Name = "txtBxTelefone";
            this.txtBxTelefone.Size = new System.Drawing.Size(140, 20);
            this.txtBxTelefone.TabIndex = 21;
            // 
            // txtBxBairro
            // 
            this.txtBxBairro.Location = new System.Drawing.Point(406, 216);
            this.txtBxBairro.Name = "txtBxBairro";
            this.txtBxBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBxBairro.TabIndex = 24;
            this.txtBxBairro.TextChanged += new System.EventHandler(this.txtBxBairro_TextChanged);
            // 
            // txtBxCEP
            // 
            this.txtBxCEP.Location = new System.Drawing.Point(92, 270);
            this.txtBxCEP.Name = "txtBxCEP";
            this.txtBxCEP.Size = new System.Drawing.Size(100, 20);
            this.txtBxCEP.TabIndex = 25;
            // 
            // txtBxRua
            // 
            this.txtBxRua.Location = new System.Drawing.Point(247, 270);
            this.txtBxRua.Name = "txtBxRua";
            this.txtBxRua.Size = new System.Drawing.Size(100, 20);
            this.txtBxRua.TabIndex = 26;
            // 
            // txtBxNumero
            // 
            this.txtBxNumero.Location = new System.Drawing.Point(406, 270);
            this.txtBxNumero.Name = "txtBxNumero";
            this.txtBxNumero.Size = new System.Drawing.Size(100, 20);
            this.txtBxNumero.TabIndex = 27;
            // 
            // txtBxComplemento
            // 
            this.txtBxComplemento.Location = new System.Drawing.Point(92, 315);
            this.txtBxComplemento.Name = "txtBxComplemento";
            this.txtBxComplemento.Size = new System.Drawing.Size(128, 20);
            this.txtBxComplemento.TabIndex = 28;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(92, 346);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 29;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(211, 346);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbBxEstado
            // 
            this.cbBxEstado.DataSource = this.fKCodigoEnderecoFornecedorBindingSource;
            this.cbBxEstado.FormattingEnabled = true;
            this.cbBxEstado.Location = new System.Drawing.Point(92, 215);
            this.cbBxEstado.Name = "cbBxEstado";
            this.cbBxEstado.Size = new System.Drawing.Size(86, 21);
            this.cbBxEstado.TabIndex = 31;
            // 
            // fKCodigoEnderecoFornecedorBindingSource
            // 
            this.fKCodigoEnderecoFornecedorBindingSource.DataMember = "FKCodigoEnderecoFornecedor";
            this.fKCodigoEnderecoFornecedorBindingSource.DataSource = this.enderecoFornecedorBindingSource;
            // 
            // enderecoFornecedorBindingSource
            // 
            this.enderecoFornecedorBindingSource.DataMember = "enderecoFornecedor";
            this.enderecoFornecedorBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoFornecedorTableAdapter
            // 
            this.enderecoFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // cbBxCidade
            // 
            this.cbBxCidade.DataSource = this.fKCodigoEnderecoFornecedorBindingSource;
            this.cbBxCidade.FormattingEnabled = true;
            this.cbBxCidade.Location = new System.Drawing.Point(247, 215);
            this.cbBxCidade.Name = "cbBxCidade";
            this.cbBxCidade.Size = new System.Drawing.Size(86, 21);
            this.cbBxCidade.TabIndex = 32;
            // 
            // TelaClientePJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 381);
            this.Controls.Add(this.cbBxCidade);
            this.Controls.Add(this.cbBxEstado);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtBxComplemento);
            this.Controls.Add(this.txtBxNumero);
            this.Controls.Add(this.txtBxRua);
            this.Controls.Add(this.txtBxCEP);
            this.Controls.Add(this.txtBxBairro);
            this.Controls.Add(this.txtBxTelefone);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxLimiteDeCredito);
            this.Controls.Add(this.txtBxCNPJ);
            this.Controls.Add(this.txtBxNomeFantasia);
            this.Controls.Add(this.txtBxRazaoSocial);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.chkBxInativo);
            this.Controls.Add(this.chkBxAtivo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLimiteDeCredito);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.lblRazaoSocial);
            this.Name = "TelaClientePJ";
            this.Text = "Cliente Pessoa Juridica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaClientePJ_FormClosing);
            this.Load += new System.EventHandler(this.TelaClientePJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKCodigoEnderecoFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblLimiteDeCredito;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkBxAtivo;
        private System.Windows.Forms.CheckBox chkBxInativo;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtBxRazaoSocial;
        private System.Windows.Forms.TextBox txtBxNomeFantasia;
        private System.Windows.Forms.TextBox txtBxCNPJ;
        private System.Windows.Forms.TextBox txtBxLimiteDeCredito;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxTelefone;
        private System.Windows.Forms.TextBox txtBxBairro;
        private System.Windows.Forms.TextBox txtBxCEP;
        private System.Windows.Forms.TextBox txtBxRua;
        private System.Windows.Forms.TextBox txtBxNumero;
        private System.Windows.Forms.TextBox txtBxComplemento;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cbBxEstado;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource enderecoFornecedorBindingSource;
        private WinetechDataSetTableAdapters.enderecoFornecedorTableAdapter enderecoFornecedorTableAdapter;
        private System.Windows.Forms.BindingSource fKCodigoEnderecoFornecedorBindingSource;
        private WinetechDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.ComboBox cbBxCidade;
    }
}