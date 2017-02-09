namespace Winetech.View
{
    partial class ClientePF
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.cbBxEstado = new System.Windows.Forms.ComboBox();
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.enderecoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoClienteTableAdapter = new Winetech.WinetechDataSetTableAdapters.enderecoClienteTableAdapter();
            this.clienteTableAdapter = new Winetech.WinetechDataSetTableAdapters.clienteTableAdapter();
            this.cbBxCidade = new System.Windows.Forms.ComboBox();
            this.dTPDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtBxNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtBxRG = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxCPF = new System.Windows.Forms.TextBox();
            this.txtBxLimiteDeCredito = new System.Windows.Forms.TextBox();
            this.txtBxTelefone = new System.Windows.Forms.TextBox();
            this.txtBxBairro = new System.Windows.Forms.TextBox();
            this.txtBxCEP = new System.Windows.Forms.TextBox();
            this.txtBxNumero = new System.Windows.Forms.TextBox();
            this.txtBxRua = new System.Windows.Forms.TextBox();
            this.txtBxComplemento = new System.Windows.Forms.TextBox();
            this.chkBxAtivo = new System.Windows.Forms.CheckBox();
            this.chkBxInativo = new System.Windows.Forms.CheckBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.fkCodigoEnderecoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkBxPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkBxPessoaJuridica = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkCodigoEnderecoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(31, 57);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(88, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo :";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(31, 88);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 1;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(214, 84);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(31, 116);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(207, 152);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(87, 13);
            this.lblLimiteCredito.TabIndex = 4;
            this.lblLimiteCredito.Text = "Limite de crédito:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(31, 221);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(31, 257);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(217, 257);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(31, 286);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(31, 321);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 11;
            this.lblCEP.Text = "CEP:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(217, 321);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 12;
            this.lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(31, 358);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Numero:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(31, 390);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 14;
            this.lblComplemento.Text = "Complemento:";
            // 
            // cbBxEstado
            // 
            this.cbBxEstado.FormattingEnabled = true;
            this.cbBxEstado.Location = new System.Drawing.Point(80, 254);
            this.cbBxEstado.Name = "cbBxEstado";
            this.cbBxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbBxEstado.TabIndex = 15;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoClienteBindingSource
            // 
            this.enderecoClienteBindingSource.DataMember = "enderecoCliente";
            this.enderecoClienteBindingSource.DataSource = this.winetechDataSet;
            // 
            // enderecoClienteTableAdapter
            // 
            this.enderecoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cbBxCidade
            // 
            this.cbBxCidade.FormattingEnabled = true;
            this.cbBxCidade.Location = new System.Drawing.Point(266, 254);
            this.cbBxCidade.Name = "cbBxCidade";
            this.cbBxCidade.Size = new System.Drawing.Size(121, 21);
            this.cbBxCidade.TabIndex = 16;
            // 
            // dTPDataDeNascimento
            // 
            this.dTPDataDeNascimento.Location = new System.Drawing.Point(144, 116);
            this.dTPDataDeNascimento.Name = "dTPDataDeNascimento";
            this.dTPDataDeNascimento.Size = new System.Drawing.Size(200, 20);
            this.dTPDataDeNascimento.TabIndex = 17;
            // 
            // txtBxNomeCompleto
            // 
            this.txtBxNomeCompleto.Location = new System.Drawing.Point(126, 50);
            this.txtBxNomeCompleto.Name = "txtBxNomeCompleto";
            this.txtBxNomeCompleto.Size = new System.Drawing.Size(261, 20);
            this.txtBxNomeCompleto.TabIndex = 18;
            // 
            // txtBxRG
            // 
            this.txtBxRG.Location = new System.Drawing.Point(80, 81);
            this.txtBxRG.Name = "txtBxRG";
            this.txtBxRG.Size = new System.Drawing.Size(121, 20);
            this.txtBxRG.TabIndex = 19;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(80, 148);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(121, 20);
            this.txtBxEmail.TabIndex = 20;
            // 
            // txtBxCPF
            // 
            this.txtBxCPF.Location = new System.Drawing.Point(266, 81);
            this.txtBxCPF.Name = "txtBxCPF";
            this.txtBxCPF.Size = new System.Drawing.Size(121, 20);
            this.txtBxCPF.TabIndex = 21;
            this.txtBxCPF.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBxLimiteDeCredito
            // 
            this.txtBxLimiteDeCredito.Location = new System.Drawing.Point(300, 149);
            this.txtBxLimiteDeCredito.Name = "txtBxLimiteDeCredito";
            this.txtBxLimiteDeCredito.Size = new System.Drawing.Size(87, 20);
            this.txtBxLimiteDeCredito.TabIndex = 22;
            // 
            // txtBxTelefone
            // 
            this.txtBxTelefone.Location = new System.Drawing.Point(80, 213);
            this.txtBxTelefone.Name = "txtBxTelefone";
            this.txtBxTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtBxTelefone.TabIndex = 23;
            // 
            // txtBxBairro
            // 
            this.txtBxBairro.Location = new System.Drawing.Point(80, 286);
            this.txtBxBairro.Name = "txtBxBairro";
            this.txtBxBairro.Size = new System.Drawing.Size(121, 20);
            this.txtBxBairro.TabIndex = 24;
            // 
            // txtBxCEP
            // 
            this.txtBxCEP.Location = new System.Drawing.Point(80, 321);
            this.txtBxCEP.Name = "txtBxCEP";
            this.txtBxCEP.Size = new System.Drawing.Size(121, 20);
            this.txtBxCEP.TabIndex = 25;
            // 
            // txtBxNumero
            // 
            this.txtBxNumero.Location = new System.Drawing.Point(80, 358);
            this.txtBxNumero.Name = "txtBxNumero";
            this.txtBxNumero.Size = new System.Drawing.Size(121, 20);
            this.txtBxNumero.TabIndex = 26;
            // 
            // txtBxRua
            // 
            this.txtBxRua.Location = new System.Drawing.Point(266, 321);
            this.txtBxRua.Name = "txtBxRua";
            this.txtBxRua.Size = new System.Drawing.Size(121, 20);
            this.txtBxRua.TabIndex = 27;
            // 
            // txtBxComplemento
            // 
            this.txtBxComplemento.Location = new System.Drawing.Point(111, 390);
            this.txtBxComplemento.Name = "txtBxComplemento";
            this.txtBxComplemento.Size = new System.Drawing.Size(90, 20);
            this.txtBxComplemento.TabIndex = 28;
            // 
            // chkBxAtivo
            // 
            this.chkBxAtivo.AutoSize = true;
            this.chkBxAtivo.Location = new System.Drawing.Point(80, 186);
            this.chkBxAtivo.Name = "chkBxAtivo";
            this.chkBxAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkBxAtivo.TabIndex = 29;
            this.chkBxAtivo.Text = "Ativo";
            this.chkBxAtivo.UseVisualStyleBackColor = true;
            // 
            // chkBxInativo
            // 
            this.chkBxInativo.AutoSize = true;
            this.chkBxInativo.Location = new System.Drawing.Point(167, 186);
            this.chkBxInativo.Name = "chkBxInativo";
            this.chkBxInativo.Size = new System.Drawing.Size(58, 17);
            this.chkBxInativo.TabIndex = 30;
            this.chkBxInativo.Text = "Inativo";
            this.chkBxInativo.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(220, 390);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(312, 390);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // fkCodigoEnderecoClienteBindingSource
            // 
            this.fkCodigoEnderecoClienteBindingSource.DataMember = "fkCodigoEnderecoCliente";
            this.fkCodigoEnderecoClienteBindingSource.DataSource = this.enderecoClienteBindingSource;
            // 
            // chkBxPessoaFisica
            // 
            this.chkBxPessoaFisica.AutoSize = true;
            this.chkBxPessoaFisica.Location = new System.Drawing.Point(34, 12);
            this.chkBxPessoaFisica.Name = "chkBxPessoaFisica";
            this.chkBxPessoaFisica.Size = new System.Drawing.Size(91, 17);
            this.chkBxPessoaFisica.TabIndex = 33;
            this.chkBxPessoaFisica.Text = "Pessoa Fisica";
            this.chkBxPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // chkBxPessoaJuridica
            // 
            this.chkBxPessoaJuridica.AutoSize = true;
            this.chkBxPessoaJuridica.Location = new System.Drawing.Point(169, 12);
            this.chkBxPessoaJuridica.Name = "chkBxPessoaJuridica";
            this.chkBxPessoaJuridica.Size = new System.Drawing.Size(100, 17);
            this.chkBxPessoaJuridica.TabIndex = 34;
            this.chkBxPessoaJuridica.Text = "Pessoa Juridica";
            this.chkBxPessoaJuridica.UseVisualStyleBackColor = true;
            this.chkBxPessoaJuridica.CheckedChanged += new System.EventHandler(this.chkBxPessoaJuridica_CheckedChanged);
            // 
            // ClientePF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 422);
            this.Controls.Add(this.chkBxPessoaJuridica);
            this.Controls.Add(this.chkBxPessoaFisica);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.chkBxInativo);
            this.Controls.Add(this.chkBxAtivo);
            this.Controls.Add(this.txtBxComplemento);
            this.Controls.Add(this.txtBxRua);
            this.Controls.Add(this.txtBxNumero);
            this.Controls.Add(this.txtBxCEP);
            this.Controls.Add(this.txtBxBairro);
            this.Controls.Add(this.txtBxTelefone);
            this.Controls.Add(this.txtBxLimiteDeCredito);
            this.Controls.Add(this.txtBxCPF);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxRG);
            this.Controls.Add(this.txtBxNomeCompleto);
            this.Controls.Add(this.dTPDataDeNascimento);
            this.Controls.Add(this.cbBxCidade);
            this.Controls.Add(this.cbBxEstado);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLimiteCredito);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblNomeCompleto);
            this.Name = "ClientePF";
            this.Text = "Cliente Pessoa Física";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientePF_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkCodigoEnderecoClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.ComboBox cbBxEstado;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource enderecoClienteBindingSource;
        private WinetechDataSetTableAdapters.enderecoClienteTableAdapter enderecoClienteTableAdapter;
        private System.Windows.Forms.BindingSource fkCodigoEnderecoClienteBindingSource;
        private WinetechDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox cbBxCidade;
        private System.Windows.Forms.DateTimePicker dTPDataDeNascimento;
        private System.Windows.Forms.TextBox txtBxNomeCompleto;
        private System.Windows.Forms.TextBox txtBxRG;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxCPF;
        private System.Windows.Forms.TextBox txtBxLimiteDeCredito;
        private System.Windows.Forms.TextBox txtBxTelefone;
        private System.Windows.Forms.TextBox txtBxBairro;
        private System.Windows.Forms.TextBox txtBxCEP;
        private System.Windows.Forms.TextBox txtBxNumero;
        private System.Windows.Forms.TextBox txtBxRua;
        private System.Windows.Forms.TextBox txtBxComplemento;
        private System.Windows.Forms.CheckBox chkBxAtivo;
        private System.Windows.Forms.CheckBox chkBxInativo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox chkBxPessoaFisica;
        private System.Windows.Forms.CheckBox chkBxPessoaJuridica;
    }
}