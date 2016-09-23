namespace Winetech.View
{
    partial class PesquisarCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitecreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEnderecoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoContatoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPedidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.clienteTableAdapter = new Winetech.WinetechDataSetTableAdapters.clienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bntPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClienteDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.nomefantasiaDataGridViewTextBoxColumn,
            this.nomecompletoDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.cnpjclienteDataGridViewTextBoxColumn,
            this.emailclienteDataGridViewTextBoxColumn,
            this.statusclienteDataGridViewTextBoxColumn,
            this.limitecreditoDataGridViewTextBoxColumn,
            this.codigoEnderecoClienteDataGridViewTextBoxColumn,
            this.codigoContatoClienteDataGridViewTextBoxColumn,
            this.codigoPedidoClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 167);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "codigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            // 
            // razaosocialDataGridViewTextBoxColumn
            // 
            this.razaosocialDataGridViewTextBoxColumn.DataPropertyName = "razaosocial";
            this.razaosocialDataGridViewTextBoxColumn.HeaderText = "razaosocial";
            this.razaosocialDataGridViewTextBoxColumn.Name = "razaosocialDataGridViewTextBoxColumn";
            // 
            // nomefantasiaDataGridViewTextBoxColumn
            // 
            this.nomefantasiaDataGridViewTextBoxColumn.DataPropertyName = "nomefantasia";
            this.nomefantasiaDataGridViewTextBoxColumn.HeaderText = "nomefantasia";
            this.nomefantasiaDataGridViewTextBoxColumn.Name = "nomefantasiaDataGridViewTextBoxColumn";
            // 
            // nomecompletoDataGridViewTextBoxColumn
            // 
            this.nomecompletoDataGridViewTextBoxColumn.DataPropertyName = "nomecompleto";
            this.nomecompletoDataGridViewTextBoxColumn.HeaderText = "nomecompleto";
            this.nomecompletoDataGridViewTextBoxColumn.Name = "nomecompletoDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "datanascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "datanascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            // 
            // cnpjclienteDataGridViewTextBoxColumn
            // 
            this.cnpjclienteDataGridViewTextBoxColumn.DataPropertyName = "cnpjcliente";
            this.cnpjclienteDataGridViewTextBoxColumn.HeaderText = "cnpjcliente";
            this.cnpjclienteDataGridViewTextBoxColumn.Name = "cnpjclienteDataGridViewTextBoxColumn";
            // 
            // emailclienteDataGridViewTextBoxColumn
            // 
            this.emailclienteDataGridViewTextBoxColumn.DataPropertyName = "emailcliente";
            this.emailclienteDataGridViewTextBoxColumn.HeaderText = "emailcliente";
            this.emailclienteDataGridViewTextBoxColumn.Name = "emailclienteDataGridViewTextBoxColumn";
            // 
            // statusclienteDataGridViewTextBoxColumn
            // 
            this.statusclienteDataGridViewTextBoxColumn.DataPropertyName = "statuscliente";
            this.statusclienteDataGridViewTextBoxColumn.HeaderText = "statuscliente";
            this.statusclienteDataGridViewTextBoxColumn.Name = "statusclienteDataGridViewTextBoxColumn";
            // 
            // limitecreditoDataGridViewTextBoxColumn
            // 
            this.limitecreditoDataGridViewTextBoxColumn.DataPropertyName = "limitecredito";
            this.limitecreditoDataGridViewTextBoxColumn.HeaderText = "limitecredito";
            this.limitecreditoDataGridViewTextBoxColumn.Name = "limitecreditoDataGridViewTextBoxColumn";
            // 
            // codigoEnderecoClienteDataGridViewTextBoxColumn
            // 
            this.codigoEnderecoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoEnderecoCliente";
            this.codigoEnderecoClienteDataGridViewTextBoxColumn.HeaderText = "codigoEnderecoCliente";
            this.codigoEnderecoClienteDataGridViewTextBoxColumn.Name = "codigoEnderecoClienteDataGridViewTextBoxColumn";
            // 
            // codigoContatoClienteDataGridViewTextBoxColumn
            // 
            this.codigoContatoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoContatoCliente";
            this.codigoContatoClienteDataGridViewTextBoxColumn.HeaderText = "codigoContatoCliente";
            this.codigoContatoClienteDataGridViewTextBoxColumn.Name = "codigoContatoClienteDataGridViewTextBoxColumn";
            // 
            // codigoPedidoClienteDataGridViewTextBoxColumn
            // 
            this.codigoPedidoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoPedidoCliente";
            this.codigoPedidoClienteDataGridViewTextBoxColumn.HeaderText = "codigoPedidoCliente";
            this.codigoPedidoClienteDataGridViewTextBoxColumn.Name = "codigoPedidoClienteDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Location = new System.Drawing.Point(206, 10);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bntPesquisar.TabIndex = 5;
            this.bntPesquisar.Text = "Pesquisar:";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 261);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Name = "PesquisarCliente";
            this.Text = "Pesquisar Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquisarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private WinetechDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitecreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEnderecoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoContatoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPedidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntPesquisar;
    }
}