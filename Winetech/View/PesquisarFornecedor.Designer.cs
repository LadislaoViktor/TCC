namespace Winetech.View
{
    partial class PesquisarFornecedor
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
            this.txtBxFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.dtGDVFornecedor = new System.Windows.Forms.DataGridView();
            this.cnpjFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoEnderecoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.fornecedorTableAdapter = new Winetech.WinetechDataSetTableAdapters.fornecedorTableAdapter();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGDVFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxFornecedor
            // 
            this.txtBxFornecedor.Location = new System.Drawing.Point(125, 24);
            this.txtBxFornecedor.Name = "txtBxFornecedor";
            this.txtBxFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtBxFornecedor.TabIndex = 0;
            this.txtBxFornecedor.TextChanged += new System.EventHandler(this.txtBxFornecedor_TextChanged);
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(13, 24);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(84, 13);
            this.lblNomeFantasia.TabIndex = 1;
            this.lblNomeFantasia.Text = "Nome Fantasia :";
            // 
            // dtGDVFornecedor
            // 
            this.dtGDVFornecedor.AutoGenerateColumns = false;
            this.dtGDVFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGDVFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpjFornecedorDataGridViewTextBoxColumn,
            this.razaoSocialFornecedorDataGridViewTextBoxColumn,
            this.nomeFantasiaFornecedorDataGridViewTextBoxColumn,
            this.emailFornecedorDataGridViewTextBoxColumn,
            this.telefoneFornecedorDataGridViewTextBoxColumn,
            this.statusFornecedorDataGridViewTextBoxColumn,
            this.codigoEnderecoFornecedorDataGridViewTextBoxColumn});
            this.dtGDVFornecedor.DataSource = this.fornecedorBindingSource;
            this.dtGDVFornecedor.Location = new System.Drawing.Point(16, 74);
            this.dtGDVFornecedor.Name = "dtGDVFornecedor";
            this.dtGDVFornecedor.Size = new System.Drawing.Size(598, 215);
            this.dtGDVFornecedor.TabIndex = 2;
            // 
            // cnpjFornecedorDataGridViewTextBoxColumn
            // 
            this.cnpjFornecedorDataGridViewTextBoxColumn.DataPropertyName = "cnpjFornecedor";
            this.cnpjFornecedorDataGridViewTextBoxColumn.HeaderText = "cnpjFornecedor";
            this.cnpjFornecedorDataGridViewTextBoxColumn.Name = "cnpjFornecedorDataGridViewTextBoxColumn";
            // 
            // razaoSocialFornecedorDataGridViewTextBoxColumn
            // 
            this.razaoSocialFornecedorDataGridViewTextBoxColumn.DataPropertyName = "razaoSocialFornecedor";
            this.razaoSocialFornecedorDataGridViewTextBoxColumn.HeaderText = "razaoSocialFornecedor";
            this.razaoSocialFornecedorDataGridViewTextBoxColumn.Name = "razaoSocialFornecedorDataGridViewTextBoxColumn";
            // 
            // nomeFantasiaFornecedorDataGridViewTextBoxColumn
            // 
            this.nomeFantasiaFornecedorDataGridViewTextBoxColumn.DataPropertyName = "nomeFantasiaFornecedor";
            this.nomeFantasiaFornecedorDataGridViewTextBoxColumn.HeaderText = "nomeFantasiaFornecedor";
            this.nomeFantasiaFornecedorDataGridViewTextBoxColumn.Name = "nomeFantasiaFornecedorDataGridViewTextBoxColumn";
            // 
            // emailFornecedorDataGridViewTextBoxColumn
            // 
            this.emailFornecedorDataGridViewTextBoxColumn.DataPropertyName = "emailFornecedor";
            this.emailFornecedorDataGridViewTextBoxColumn.HeaderText = "emailFornecedor";
            this.emailFornecedorDataGridViewTextBoxColumn.Name = "emailFornecedorDataGridViewTextBoxColumn";
            // 
            // telefoneFornecedorDataGridViewTextBoxColumn
            // 
            this.telefoneFornecedorDataGridViewTextBoxColumn.DataPropertyName = "telefoneFornecedor";
            this.telefoneFornecedorDataGridViewTextBoxColumn.HeaderText = "telefoneFornecedor";
            this.telefoneFornecedorDataGridViewTextBoxColumn.Name = "telefoneFornecedorDataGridViewTextBoxColumn";
            // 
            // statusFornecedorDataGridViewTextBoxColumn
            // 
            this.statusFornecedorDataGridViewTextBoxColumn.DataPropertyName = "statusFornecedor";
            this.statusFornecedorDataGridViewTextBoxColumn.HeaderText = "statusFornecedor";
            this.statusFornecedorDataGridViewTextBoxColumn.Name = "statusFornecedorDataGridViewTextBoxColumn";
            // 
            // codigoEnderecoFornecedorDataGridViewTextBoxColumn
            // 
            this.codigoEnderecoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codigoEnderecoFornecedor";
            this.codigoEnderecoFornecedorDataGridViewTextBoxColumn.HeaderText = "codigoEnderecoFornecedor";
            this.codigoEnderecoFornecedorDataGridViewTextBoxColumn.Name = "codigoEnderecoFornecedorDataGridViewTextBoxColumn";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.winetechDataSet;
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(55, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(226, 297);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // PesquisarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 332);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtGDVFornecedor);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.txtBxFornecedor);
            this.Name = "PesquisarFornecedor";
            this.Text = "Pesquisar Fornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PesquisarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGDVFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFornecedor;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.DataGridView dtGDVFornecedor;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private WinetechDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEnderecoFornecedorDataGridViewTextBoxColumn;
    }
}