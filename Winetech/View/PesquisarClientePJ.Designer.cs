namespace Winetech.View
{
    partial class PesquisarClientePJ
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
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtBxNomeFantasia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitecreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.clienteTableAdapter = new Winetech.WinetechDataSetTableAdapters.clienteTableAdapter();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(13, 13);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 0;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // txtBxNomeFantasia
            // 
            this.txtBxNomeFantasia.Location = new System.Drawing.Point(110, 13);
            this.txtBxNomeFantasia.Name = "txtBxNomeFantasia";
            this.txtBxNomeFantasia.Size = new System.Drawing.Size(100, 20);
            this.txtBxNomeFantasia.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClienteDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.nomefantasiaDataGridViewTextBoxColumn,
            this.cnpjclienteDataGridViewTextBoxColumn,
            this.emailclienteDataGridViewTextBoxColumn,
            this.statusclienteDataGridViewTextBoxColumn,
            this.limitecreditoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 178);
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
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(240, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(339, 240);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // PesquisarClientePJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 275);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBxNomeFantasia);
            this.Controls.Add(this.lblNomeFantasia);
            this.Name = "PesquisarClientePJ";
            this.Text = "PesquisarClientePJ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PesquisarClientePJ_FormClosing);
            this.Load += new System.EventHandler(this.PesquisarClientePJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtBxNomeFantasia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private WinetechDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitecreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExcluir;
    }
}