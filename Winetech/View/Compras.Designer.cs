namespace Winetech.View
{
    partial class Compras
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
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.pedidoFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.pedidoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoClienteTableAdapter = new Winetech.WinetechDataSetTableAdapters.pedidoClienteTableAdapter();
            this.itensPedidoFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensPedidoFornecedorTableAdapter = new Winetech.WinetechDataSetTableAdapters.itensPedidoFornecedorTableAdapter();
            this.pedidoFornecedorTableAdapter = new Winetech.WinetechDataSetTableAdapters.pedidoFornecedorTableAdapter();
            this.lblDataCompraPedido = new System.Windows.Forms.Label();
            this.txtBxFornecedor = new System.Windows.Forms.TextBox();
            this.dtTmPcData = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoPedidoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompraPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadePedidoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPedidoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            this.btnRemoverItens = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(13, 20);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(64, 13);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor:";
            this.lblFornecedor.Click += new System.EventHandler(this.lblFornecedor_Click);
            // 
            // pedidoFornecedorBindingSource
            // 
            this.pedidoFornecedorBindingSource.DataMember = "pedidoFornecedor";
            this.pedidoFornecedorBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoClienteBindingSource
            // 
            this.pedidoClienteBindingSource.DataMember = "pedidoCliente";
            this.pedidoClienteBindingSource.DataSource = this.winetechDataSet;
            // 
            // pedidoClienteTableAdapter
            // 
            this.pedidoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // itensPedidoFornecedorBindingSource
            // 
            this.itensPedidoFornecedorBindingSource.DataMember = "itensPedidoFornecedor";
            this.itensPedidoFornecedorBindingSource.DataSource = this.winetechDataSet;
            // 
            // itensPedidoFornecedorTableAdapter
            // 
            this.itensPedidoFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoFornecedorTableAdapter
            // 
            this.pedidoFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // lblDataCompraPedido
            // 
            this.lblDataCompraPedido.AutoSize = true;
            this.lblDataCompraPedido.Location = new System.Drawing.Point(387, 66);
            this.lblDataCompraPedido.Name = "lblDataCompraPedido";
            this.lblDataCompraPedido.Size = new System.Drawing.Size(33, 13);
            this.lblDataCompraPedido.TabIndex = 4;
            this.lblDataCompraPedido.Text = "Data:";
            // 
            // txtBxFornecedor
            // 
            this.txtBxFornecedor.Location = new System.Drawing.Point(83, 17);
            this.txtBxFornecedor.Name = "txtBxFornecedor";
            this.txtBxFornecedor.Size = new System.Drawing.Size(543, 20);
            this.txtBxFornecedor.TabIndex = 5;
            // 
            // dtTmPcData
            // 
            this.dtTmPcData.Location = new System.Drawing.Point(426, 63);
            this.dtTmPcData.Name = "dtTmPcData";
            this.dtTmPcData.Size = new System.Drawing.Size(200, 20);
            this.dtTmPcData.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPedidoFornecedorDataGridViewTextBoxColumn,
            this.dataCompraPedidoDataGridViewTextBoxColumn,
            this.Produto,
            this.quantidadePedidoFornecedorDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.totalPedidoFornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidoFornecedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 190);
            this.dataGridView1.TabIndex = 9;
            // 
            // codigoPedidoFornecedorDataGridViewTextBoxColumn
            // 
            this.codigoPedidoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codigoPedidoFornecedor";
            this.codigoPedidoFornecedorDataGridViewTextBoxColumn.HeaderText = "Codigo Pedido";
            this.codigoPedidoFornecedorDataGridViewTextBoxColumn.Name = "codigoPedidoFornecedorDataGridViewTextBoxColumn";
            // 
            // dataCompraPedidoDataGridViewTextBoxColumn
            // 
            this.dataCompraPedidoDataGridViewTextBoxColumn.DataPropertyName = "dataCompraPedido";
            this.dataCompraPedidoDataGridViewTextBoxColumn.HeaderText = "Data Compra";
            this.dataCompraPedidoDataGridViewTextBoxColumn.Name = "dataCompraPedidoDataGridViewTextBoxColumn";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // quantidadePedidoFornecedorDataGridViewTextBoxColumn
            // 
            this.quantidadePedidoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "quantidadePedidoFornecedor";
            this.quantidadePedidoFornecedorDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadePedidoFornecedorDataGridViewTextBoxColumn.Name = "quantidadePedidoFornecedorDataGridViewTextBoxColumn";
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preço Unitario";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            // 
            // totalPedidoFornecedorDataGridViewTextBoxColumn
            // 
            this.totalPedidoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "totalPedidoFornecedor";
            this.totalPedidoFornecedorDataGridViewTextBoxColumn.HeaderText = "Total Pedido";
            this.totalPedidoFornecedorDataGridViewTextBoxColumn.Name = "totalPedidoFornecedorDataGridViewTextBoxColumn";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 63);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.Location = new System.Drawing.Point(19, 304);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(87, 23);
            this.btnAdicionarItens.TabIndex = 11;
            this.btnAdicionarItens.Text = "Adicionar Itens";
            this.btnAdicionarItens.UseVisualStyleBackColor = true;
            // 
            // btnRemoverItens
            // 
            this.btnRemoverItens.Location = new System.Drawing.Point(147, 304);
            this.btnRemoverItens.Name = "btnRemoverItens";
            this.btnRemoverItens.Size = new System.Drawing.Size(84, 23);
            this.btnRemoverItens.TabIndex = 12;
            this.btnRemoverItens.Text = "Remover Itens";
            this.btnRemoverItens.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fechar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 341);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoverItens);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtTmPcData);
            this.Controls.Add(this.txtBxFornecedor);
            this.Controls.Add(this.lblDataCompraPedido);
            this.Controls.Add(this.lblFornecedor);
            this.Name = "Compras";
            this.Text = "Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compras_FormClosing);
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensPedidoFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornecedor;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource pedidoClienteBindingSource;
        private WinetechDataSetTableAdapters.pedidoClienteTableAdapter pedidoClienteTableAdapter;
        private System.Windows.Forms.BindingSource itensPedidoFornecedorBindingSource;
        private WinetechDataSetTableAdapters.itensPedidoFornecedorTableAdapter itensPedidoFornecedorTableAdapter;
        private System.Windows.Forms.BindingSource pedidoFornecedorBindingSource;
        private WinetechDataSetTableAdapters.pedidoFornecedorTableAdapter pedidoFornecedorTableAdapter;
        private System.Windows.Forms.Label lblDataCompraPedido;
        private System.Windows.Forms.TextBox txtBxFornecedor;
        private System.Windows.Forms.DateTimePicker dtTmPcData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompraPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePedidoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPedidoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdicionarItens;
        private System.Windows.Forms.Button btnRemoverItens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}