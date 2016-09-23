namespace Winetech.View
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtBxCliente = new System.Windows.Forms.TextBox();
            this.txtBxNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPagamentoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.pedidoClienteTableAdapter = new Winetech.WinetechDataSetTableAdapters.pedidoClienteTableAdapter();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            this.btnRemoverItens = new System.Windows.Forms.Button();
            this.btnFecharPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(262, 28);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompleto.TabIndex = 1;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(262, 65);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // txtBxCliente
            // 
            this.txtBxCliente.Location = new System.Drawing.Point(62, 21);
            this.txtBxCliente.Name = "txtBxCliente";
            this.txtBxCliente.Size = new System.Drawing.Size(194, 20);
            this.txtBxCliente.TabIndex = 4;
            // 
            // txtBxNomeCompleto
            // 
            this.txtBxNomeCompleto.Location = new System.Drawing.Point(356, 25);
            this.txtBxNomeCompleto.Name = "txtBxNomeCompleto";
            this.txtBxNomeCompleto.Size = new System.Drawing.Size(200, 20);
            this.txtBxNomeCompleto.TabIndex = 5;
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(62, 62);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(194, 20);
            this.txtBxCodigo.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPedidoDataGridViewTextBoxColumn,
            this.dataPedidoDataGridViewTextBoxColumn,
            this.statusPedidoDataGridViewTextBoxColumn,
            this.statusPagamentoPedidoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoUnitarioDataGridViewTextBoxColumn,
            this.totalPedidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pedidoClienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 207);
            this.dataGridView1.TabIndex = 8;
            // 
            // codigoPedidoDataGridViewTextBoxColumn
            // 
            this.codigoPedidoDataGridViewTextBoxColumn.DataPropertyName = "codigoPedido";
            this.codigoPedidoDataGridViewTextBoxColumn.HeaderText = "codigoPedido";
            this.codigoPedidoDataGridViewTextBoxColumn.Name = "codigoPedidoDataGridViewTextBoxColumn";
            // 
            // dataPedidoDataGridViewTextBoxColumn
            // 
            this.dataPedidoDataGridViewTextBoxColumn.DataPropertyName = "dataPedido";
            this.dataPedidoDataGridViewTextBoxColumn.HeaderText = "dataPedido";
            this.dataPedidoDataGridViewTextBoxColumn.Name = "dataPedidoDataGridViewTextBoxColumn";
            // 
            // statusPedidoDataGridViewTextBoxColumn
            // 
            this.statusPedidoDataGridViewTextBoxColumn.DataPropertyName = "statusPedido";
            this.statusPedidoDataGridViewTextBoxColumn.HeaderText = "statusPedido";
            this.statusPedidoDataGridViewTextBoxColumn.Name = "statusPedidoDataGridViewTextBoxColumn";
            // 
            // statusPagamentoPedidoDataGridViewTextBoxColumn
            // 
            this.statusPagamentoPedidoDataGridViewTextBoxColumn.DataPropertyName = "statusPagamentoPedido";
            this.statusPagamentoPedidoDataGridViewTextBoxColumn.HeaderText = "statusPagamentoPedido";
            this.statusPagamentoPedidoDataGridViewTextBoxColumn.Name = "statusPagamentoPedidoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            this.precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.HeaderText = "precoUnitario";
            this.precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            // 
            // totalPedidoDataGridViewTextBoxColumn
            // 
            this.totalPedidoDataGridViewTextBoxColumn.DataPropertyName = "totalPedido";
            this.totalPedidoDataGridViewTextBoxColumn.HeaderText = "totalPedido";
            this.totalPedidoDataGridViewTextBoxColumn.Name = "totalPedidoDataGridViewTextBoxColumn";
            // 
            // pedidoClienteBindingSource
            // 
            this.pedidoClienteBindingSource.DataMember = "pedidoCliente";
            this.pedidoClienteBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoClienteTableAdapter
            // 
            this.pedidoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.Location = new System.Drawing.Point(36, 350);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(86, 23);
            this.btnAdicionarItens.TabIndex = 9;
            this.btnAdicionarItens.Text = "Adicionar Itens";
            this.btnAdicionarItens.UseVisualStyleBackColor = true;
            this.btnAdicionarItens.Click += new System.EventHandler(this.btnAdicionarItens_Click);
            // 
            // btnRemoverItens
            // 
            this.btnRemoverItens.Location = new System.Drawing.Point(189, 350);
            this.btnRemoverItens.Name = "btnRemoverItens";
            this.btnRemoverItens.Size = new System.Drawing.Size(86, 23);
            this.btnRemoverItens.TabIndex = 10;
            this.btnRemoverItens.Text = "Remover Itens";
            this.btnRemoverItens.UseVisualStyleBackColor = true;
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Location = new System.Drawing.Point(345, 350);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.Size = new System.Drawing.Size(88, 23);
            this.btnFecharPedido.TabIndex = 11;
            this.btnFecharPedido.Text = "Fechar Pedido";
            this.btnFecharPedido.UseVisualStyleBackColor = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 385);
            this.Controls.Add(this.btnFecharPedido);
            this.Controls.Add(this.btnRemoverItens);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.txtBxNomeCompleto);
            this.Controls.Add(this.txtBxCliente);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtBxCliente;
        private System.Windows.Forms.TextBox txtBxNomeCompleto;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource pedidoClienteBindingSource;
        private WinetechDataSetTableAdapters.pedidoClienteTableAdapter pedidoClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPagamentoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdicionarItens;
        private System.Windows.Forms.Button btnRemoverItens;
        private System.Windows.Forms.Button btnFecharPedido;
    }
}