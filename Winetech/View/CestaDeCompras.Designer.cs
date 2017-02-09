namespace Winetech.View
{
    partial class CestaDeCompras
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtBxProduto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teorAlcolicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoUnitárioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSafraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.produtoTableAdapter = new Winetech.WinetechDataSetTableAdapters.produtoTableAdapter();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(13, 13);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // txtBxProduto
            // 
            this.txtBxProduto.Location = new System.Drawing.Point(82, 13);
            this.txtBxProduto.Name = "txtBxProduto";
            this.txtBxProduto.Size = new System.Drawing.Size(227, 20);
            this.txtBxProduto.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.uvaDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.teorAlcolicoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.custoUnitárioDataGridViewTextBoxColumn,
            this.quantidadeEstoqueDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.dataValidadeDataGridViewTextBoxColumn,
            this.codigoPaisDataGridViewTextBoxColumn,
            this.codigoSafraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(579, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoProdutoDataGridViewTextBoxColumn
            // 
            this.codigoProdutoDataGridViewTextBoxColumn.DataPropertyName = "codigoProduto";
            this.codigoProdutoDataGridViewTextBoxColumn.HeaderText = "codigoProduto";
            this.codigoProdutoDataGridViewTextBoxColumn.Name = "codigoProdutoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // uvaDataGridViewTextBoxColumn
            // 
            this.uvaDataGridViewTextBoxColumn.DataPropertyName = "uva";
            this.uvaDataGridViewTextBoxColumn.HeaderText = "uva";
            this.uvaDataGridViewTextBoxColumn.Name = "uvaDataGridViewTextBoxColumn";
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            // 
            // teorAlcolicoDataGridViewTextBoxColumn
            // 
            this.teorAlcolicoDataGridViewTextBoxColumn.DataPropertyName = "teor_Alcolico";
            this.teorAlcolicoDataGridViewTextBoxColumn.HeaderText = "teor_Alcolico";
            this.teorAlcolicoDataGridViewTextBoxColumn.Name = "teorAlcolicoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // custoUnitárioDataGridViewTextBoxColumn
            // 
            this.custoUnitárioDataGridViewTextBoxColumn.DataPropertyName = "custoUnitário";
            this.custoUnitárioDataGridViewTextBoxColumn.HeaderText = "custoUnitário";
            this.custoUnitárioDataGridViewTextBoxColumn.Name = "custoUnitárioDataGridViewTextBoxColumn";
            // 
            // quantidadeEstoqueDataGridViewTextBoxColumn
            // 
            this.quantidadeEstoqueDataGridViewTextBoxColumn.DataPropertyName = "quantidadeEstoque";
            this.quantidadeEstoqueDataGridViewTextBoxColumn.HeaderText = "quantidadeEstoque";
            this.quantidadeEstoqueDataGridViewTextBoxColumn.Name = "quantidadeEstoqueDataGridViewTextBoxColumn";
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "precoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "precoVenda";
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "dataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "dataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            // 
            // codigoPaisDataGridViewTextBoxColumn
            // 
            this.codigoPaisDataGridViewTextBoxColumn.DataPropertyName = "codigoPais";
            this.codigoPaisDataGridViewTextBoxColumn.HeaderText = "codigoPais";
            this.codigoPaisDataGridViewTextBoxColumn.Name = "codigoPaisDataGridViewTextBoxColumn";
            // 
            // codigoSafraDataGridViewTextBoxColumn
            // 
            this.codigoSafraDataGridViewTextBoxColumn.DataPropertyName = "codigoSafra";
            this.codigoSafraDataGridViewTextBoxColumn.HeaderText = "codigoSafra";
            this.codigoSafraDataGridViewTextBoxColumn.Name = "codigoSafraDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.Location = new System.Drawing.Point(82, 315);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarItens.TabIndex = 3;
            this.btnAdicionarItens.Text = "Adicionar Itens";
            this.btnAdicionarItens.UseVisualStyleBackColor = true;
            // 
            // CestaDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 364);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBxProduto);
            this.Controls.Add(this.lblProduto);
            this.Name = "CestaDeCompras";
            this.Text = "Cesta De Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CestaDeCompras_FormClosing);
            this.Load += new System.EventHandler(this.CestaDeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtBxProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private WinetechDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teorAlcolicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoUnitárioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSafraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdicionarItens;
    }
}