namespace Winetech.View
{
    partial class frmPesquisarUsuários
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
            this.txtBxPesquisarUsuarios = new System.Windows.Forms.TextBox();
            this.dtGdVDadosUsuários = new System.Windows.Forms.DataGridView();
            this.winetechDataSet = new Winetech.WinetechDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Winetech.WinetechDataSetTableAdapters.usuarioTableAdapter();
            this.codigoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPerfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisarUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGdVDadosUsuários)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtBxPesquisarUsuarios
            // 
            this.txtBxPesquisarUsuarios.Location = new System.Drawing.Point(111, 13);
            this.txtBxPesquisarUsuarios.Name = "txtBxPesquisarUsuarios";
            this.txtBxPesquisarUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtBxPesquisarUsuarios.TabIndex = 1;
            // 
            // dtGdVDadosUsuários
            // 
            this.dtGdVDadosUsuários.AutoGenerateColumns = false;
            this.dtGdVDadosUsuários.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGdVDadosUsuários.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUsuarioDataGridViewTextBoxColumn,
            this.lloginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.cpfUsuarioDataGridViewTextBoxColumn,
            this.nomecompletoDataGridViewTextBoxColumn,
            this.statusUsuarioDataGridViewTextBoxColumn,
            this.codigoPerfilDataGridViewTextBoxColumn});
            this.dtGdVDadosUsuários.DataSource = this.usuarioBindingSource;
            this.dtGdVDadosUsuários.Location = new System.Drawing.Point(12, 57);
            this.dtGdVDadosUsuários.Name = "dtGdVDadosUsuários";
            this.dtGdVDadosUsuários.Size = new System.Drawing.Size(538, 239);
            this.dtGdVDadosUsuários.TabIndex = 2;
            this.dtGdVDadosUsuários.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGdVDadosUsuários_CellContentClick);
            // 
            // winetechDataSet
            // 
            this.winetechDataSet.DataSetName = "WinetechDataSet";
            this.winetechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.winetechDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // codigoUsuarioDataGridViewTextBoxColumn
            // 
            this.codigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "codigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.HeaderText = "codigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.Name = "codigoUsuarioDataGridViewTextBoxColumn";
            // 
            // lloginDataGridViewTextBoxColumn
            // 
            this.lloginDataGridViewTextBoxColumn.DataPropertyName = "llogin";
            this.lloginDataGridViewTextBoxColumn.HeaderText = "llogin";
            this.lloginDataGridViewTextBoxColumn.Name = "lloginDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // cpfUsuarioDataGridViewTextBoxColumn
            // 
            this.cpfUsuarioDataGridViewTextBoxColumn.DataPropertyName = "cpfUsuario";
            this.cpfUsuarioDataGridViewTextBoxColumn.HeaderText = "cpfUsuario";
            this.cpfUsuarioDataGridViewTextBoxColumn.Name = "cpfUsuarioDataGridViewTextBoxColumn";
            // 
            // nomecompletoDataGridViewTextBoxColumn
            // 
            this.nomecompletoDataGridViewTextBoxColumn.DataPropertyName = "nomecompleto";
            this.nomecompletoDataGridViewTextBoxColumn.HeaderText = "nomecompleto";
            this.nomecompletoDataGridViewTextBoxColumn.Name = "nomecompletoDataGridViewTextBoxColumn";
            // 
            // statusUsuarioDataGridViewTextBoxColumn
            // 
            this.statusUsuarioDataGridViewTextBoxColumn.DataPropertyName = "statusUsuario";
            this.statusUsuarioDataGridViewTextBoxColumn.HeaderText = "statusUsuario";
            this.statusUsuarioDataGridViewTextBoxColumn.Name = "statusUsuarioDataGridViewTextBoxColumn";
            // 
            // codigoPerfilDataGridViewTextBoxColumn
            // 
            this.codigoPerfilDataGridViewTextBoxColumn.DataPropertyName = "codigoPerfil";
            this.codigoPerfilDataGridViewTextBoxColumn.HeaderText = "codigoPerfil";
            this.codigoPerfilDataGridViewTextBoxColumn.Name = "codigoPerfilDataGridViewTextBoxColumn";
            // 
            // btnPesquisarUsuarios
            // 
            this.btnPesquisarUsuarios.Location = new System.Drawing.Point(253, 13);
            this.btnPesquisarUsuarios.Name = "btnPesquisarUsuarios";
            this.btnPesquisarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarUsuarios.TabIndex = 3;
            this.btnPesquisarUsuarios.Text = "Pesquisar";
            this.btnPesquisarUsuarios.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPesquisarUsuários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 325);
            this.Controls.Add(this.btnPesquisarUsuarios);
            this.Controls.Add(this.dtGdVDadosUsuários);
            this.Controls.Add(this.txtBxPesquisarUsuarios);
            this.Controls.Add(this.lblNome);
            this.Name = "frmPesquisarUsuários";
            this.Text = "Pesquisar Usuários";
            this.Load += new System.EventHandler(this.frmPesquisarUsuários_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGdVDadosUsuários)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winetechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBxPesquisarUsuarios;
        private System.Windows.Forms.DataGridView dtGdVDadosUsuários;
        private WinetechDataSet winetechDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private WinetechDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPerfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPesquisarUsuarios;
    }
}