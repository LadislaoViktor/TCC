namespace Winetech.View
{
    partial class Estoque
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
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCustoUnitario = new System.Windows.Forms.Label();
            this.lblUva = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblTeorAlcolico = new System.Windows.Forms.Label();
            this.lblSafra = new System.Windows.Forms.Label();
            this.lblDataDeValidade = new System.Windows.Forms.Label();
            this.lblPrecoDeVenda = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nUDTeorAlcolico = new System.Windows.Forms.NumericUpDown();
            this.nUDQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtBxCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtBxUnidade = new System.Windows.Forms.TextBox();
            this.txtBxTipo = new System.Windows.Forms.TextBox();
            this.txtBxClasse = new System.Windows.Forms.TextBox();
            this.txtBxPrecoDeVenda = new System.Windows.Forms.TextBox();
            this.txtBxCustoUnitario = new System.Windows.Forms.TextBox();
            this.txtBxUva = new System.Windows.Forms.TextBox();
            this.txtBxDescricao = new System.Windows.Forms.TextBox();
            this.txtBxNome = new System.Windows.Forms.TextBox();
            this.dtTPDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.cbBxPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.paisTableAdapter = new Winetech.WinetechDataSetTableAdapters.paisTableAdapter();
            this.cbBxSafra = new System.Windows.Forms.ComboBox();
            this.safraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.safraTableAdapter = new Winetech.WinetechDataSetTableAdapters.safraTableAdapter();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTeorAlcolico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(20, 15);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoProduto.TabIndex = 0;
            this.lblCodigoProduto.Text = "Codigo Produto :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(232, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 48);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(20, 79);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "Pais:";
            // 
            // lblCustoUnitario
            // 
            this.lblCustoUnitario.AutoSize = true;
            this.lblCustoUnitario.Location = new System.Drawing.Point(20, 162);
            this.lblCustoUnitario.Name = "lblCustoUnitario";
            this.lblCustoUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblCustoUnitario.TabIndex = 6;
            this.lblCustoUnitario.Text = "Custo Unitario :";
            // 
            // lblUva
            // 
            this.lblUva.AutoSize = true;
            this.lblUva.Location = new System.Drawing.Point(20, 102);
            this.lblUva.Name = "lblUva";
            this.lblUva.Size = new System.Drawing.Size(30, 13);
            this.lblUva.TabIndex = 7;
            this.lblUva.Text = "Uva:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(233, 130);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(233, 92);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(41, 13);
            this.lblClasse.TabIndex = 9;
            this.lblClasse.Text = "Classe:";
            // 
            // lblTeorAlcolico
            // 
            this.lblTeorAlcolico.AutoSize = true;
            this.lblTeorAlcolico.Location = new System.Drawing.Point(20, 130);
            this.lblTeorAlcolico.Name = "lblTeorAlcolico";
            this.lblTeorAlcolico.Size = new System.Drawing.Size(78, 13);
            this.lblTeorAlcolico.TabIndex = 10;
            this.lblTeorAlcolico.Text = "Teor Alcoolico:";
            // 
            // lblSafra
            // 
            this.lblSafra.AutoSize = true;
            this.lblSafra.Location = new System.Drawing.Point(233, 57);
            this.lblSafra.Name = "lblSafra";
            this.lblSafra.Size = new System.Drawing.Size(35, 13);
            this.lblSafra.TabIndex = 11;
            this.lblSafra.Text = "Safra:";
            // 
            // lblDataDeValidade
            // 
            this.lblDataDeValidade.AutoSize = true;
            this.lblDataDeValidade.Location = new System.Drawing.Point(233, 162);
            this.lblDataDeValidade.Name = "lblDataDeValidade";
            this.lblDataDeValidade.Size = new System.Drawing.Size(94, 13);
            this.lblDataDeValidade.TabIndex = 12;
            this.lblDataDeValidade.Text = "Data De Validade:";
            // 
            // lblPrecoDeVenda
            // 
            this.lblPrecoDeVenda.AutoSize = true;
            this.lblPrecoDeVenda.Location = new System.Drawing.Point(20, 214);
            this.lblPrecoDeVenda.Name = "lblPrecoDeVenda";
            this.lblPrecoDeVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoDeVenda.TabIndex = 13;
            this.lblPrecoDeVenda.Text = "Preço de Venda:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(236, 215);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(50, 13);
            this.lblUnidade.TabIndex = 14;
            this.lblUnidade.Text = "Unidade:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(20, 187);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 15;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // nUDTeorAlcolico
            // 
            this.nUDTeorAlcolico.Location = new System.Drawing.Point(112, 130);
            this.nUDTeorAlcolico.Name = "nUDTeorAlcolico";
            this.nUDTeorAlcolico.Size = new System.Drawing.Size(33, 20);
            this.nUDTeorAlcolico.TabIndex = 16;
            // 
            // nUDQuantidade
            // 
            this.nUDQuantidade.Location = new System.Drawing.Point(112, 187);
            this.nUDQuantidade.Name = "nUDQuantidade";
            this.nUDQuantidade.Size = new System.Drawing.Size(33, 20);
            this.nUDQuantidade.TabIndex = 17;
            // 
            // txtBxCodigoProduto
            // 
            this.txtBxCodigoProduto.Location = new System.Drawing.Point(112, 15);
            this.txtBxCodigoProduto.Name = "txtBxCodigoProduto";
            this.txtBxCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtBxCodigoProduto.TabIndex = 18;
            // 
            // txtBxUnidade
            // 
            this.txtBxUnidade.Location = new System.Drawing.Point(372, 211);
            this.txtBxUnidade.Name = "txtBxUnidade";
            this.txtBxUnidade.Size = new System.Drawing.Size(100, 20);
            this.txtBxUnidade.TabIndex = 22;
            // 
            // txtBxTipo
            // 
            this.txtBxTipo.Location = new System.Drawing.Point(372, 130);
            this.txtBxTipo.Name = "txtBxTipo";
            this.txtBxTipo.Size = new System.Drawing.Size(100, 20);
            this.txtBxTipo.TabIndex = 23;
            // 
            // txtBxClasse
            // 
            this.txtBxClasse.Location = new System.Drawing.Point(372, 89);
            this.txtBxClasse.Name = "txtBxClasse";
            this.txtBxClasse.Size = new System.Drawing.Size(100, 20);
            this.txtBxClasse.TabIndex = 24;
            // 
            // txtBxPrecoDeVenda
            // 
            this.txtBxPrecoDeVenda.Location = new System.Drawing.Point(112, 211);
            this.txtBxPrecoDeVenda.Name = "txtBxPrecoDeVenda";
            this.txtBxPrecoDeVenda.Size = new System.Drawing.Size(100, 20);
            this.txtBxPrecoDeVenda.TabIndex = 26;
            // 
            // txtBxCustoUnitario
            // 
            this.txtBxCustoUnitario.Location = new System.Drawing.Point(112, 161);
            this.txtBxCustoUnitario.Name = "txtBxCustoUnitario";
            this.txtBxCustoUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtBxCustoUnitario.TabIndex = 27;
            // 
            // txtBxUva
            // 
            this.txtBxUva.Location = new System.Drawing.Point(112, 99);
            this.txtBxUva.Name = "txtBxUva";
            this.txtBxUva.Size = new System.Drawing.Size(100, 20);
            this.txtBxUva.TabIndex = 28;
            // 
            // txtBxDescricao
            // 
            this.txtBxDescricao.Location = new System.Drawing.Point(112, 45);
            this.txtBxDescricao.Name = "txtBxDescricao";
            this.txtBxDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtBxDescricao.TabIndex = 30;
            // 
            // txtBxNome
            // 
            this.txtBxNome.Location = new System.Drawing.Point(276, 18);
            this.txtBxNome.Name = "txtBxNome";
            this.txtBxNome.Size = new System.Drawing.Size(196, 20);
            this.txtBxNome.TabIndex = 31;
            // 
            // dtTPDataDeValidade
            // 
            this.dtTPDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTPDataDeValidade.Location = new System.Drawing.Point(376, 162);
            this.dtTPDataDeValidade.Name = "dtTPDataDeValidade";
            this.dtTPDataDeValidade.Size = new System.Drawing.Size(96, 20);
            this.dtTPDataDeValidade.TabIndex = 32;
            // 
            // cbBxPais
            // 
            this.cbBxPais.DataSource = this.paisBindingSource;
            this.cbBxPais.DisplayMember = "nomePais";
            this.cbBxPais.FormattingEnabled = true;
            this.cbBxPais.Location = new System.Drawing.Point(112, 71);
            this.cbBxPais.Name = "cbBxPais";
            this.cbBxPais.Size = new System.Drawing.Size(100, 21);
            this.cbBxPais.TabIndex = 33;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // cbBxSafra
            // 
            this.cbBxSafra.DataSource = this.safraBindingSource;
            this.cbBxSafra.DisplayMember = "descricao";
            this.cbBxSafra.FormattingEnabled = true;
            this.cbBxSafra.Location = new System.Drawing.Point(372, 48);
            this.cbBxSafra.Name = "cbBxSafra";
            this.cbBxSafra.Size = new System.Drawing.Size(99, 21);
            this.cbBxSafra.TabIndex = 34;
            // 
            // safraBindingSource
            // 
            this.safraBindingSource.DataMember = "safra";
            this.safraBindingSource.DataSource = this.winetechDataSet;
            // 
            // safraTableAdapter
            // 
            this.safraTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 241);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 276);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbBxSafra);
            this.Controls.Add(this.cbBxPais);
            this.Controls.Add(this.dtTPDataDeValidade);
            this.Controls.Add(this.txtBxNome);
            this.Controls.Add(this.txtBxDescricao);
            this.Controls.Add(this.txtBxUva);
            this.Controls.Add(this.txtBxCustoUnitario);
            this.Controls.Add(this.txtBxPrecoDeVenda);
            this.Controls.Add(this.txtBxClasse);
            this.Controls.Add(this.txtBxTipo);
            this.Controls.Add(this.txtBxUnidade);
            this.Controls.Add(this.txtBxCodigoProduto);
            this.Controls.Add(this.nUDQuantidade);
            this.Controls.Add(this.nUDTeorAlcolico);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblPrecoDeVenda);
            this.Controls.Add(this.lblDataDeValidade);
            this.Controls.Add(this.lblSafra);
            this.Controls.Add(this.lblTeorAlcolico);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblUva);
            this.Controls.Add(this.lblCustoUnitario);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigoProduto);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Estoque_FormClosing);
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDTeorAlcolico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCustoUnitario;
        private System.Windows.Forms.Label lblUva;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblTeorAlcolico;
        private System.Windows.Forms.Label lblSafra;
        private System.Windows.Forms.Label lblDataDeValidade;
        private System.Windows.Forms.Label lblPrecoDeVenda;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nUDTeorAlcolico;
        private System.Windows.Forms.NumericUpDown nUDQuantidade;
        private System.Windows.Forms.TextBox txtBxCodigoProduto;
        private System.Windows.Forms.TextBox txtBxUnidade;
        private System.Windows.Forms.TextBox txtBxTipo;
        private System.Windows.Forms.TextBox txtBxClasse;
        private System.Windows.Forms.TextBox txtBxPrecoDeVenda;
        private System.Windows.Forms.TextBox txtBxCustoUnitario;
        private System.Windows.Forms.TextBox txtBxUva;
        private System.Windows.Forms.TextBox txtBxDescricao;
        private System.Windows.Forms.TextBox txtBxNome;
        private System.Windows.Forms.DateTimePicker dtTPDataDeValidade;
        private System.Windows.Forms.ComboBox cbBxPais;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private WinetechDataSetTableAdapters.paisTableAdapter paisTableAdapter;
        private System.Windows.Forms.ComboBox cbBxSafra;
        private System.Windows.Forms.BindingSource safraBindingSource;
        private WinetechDataSetTableAdapters.safraTableAdapter safraTableAdapter;
        private System.Windows.Forms.Button btnSalvar;
    }
}