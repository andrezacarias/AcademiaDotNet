namespace GerenciamentoDeVendas
{
    partial class FormPesquisaCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rhinoStore_DBDataSet27 = new GerenciamentoDeVendas.RhinoStore_DBDataSet27();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet27TableAdapters.vendasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.rhinoStore_DBDataSet28 = new GerenciamentoDeVendas.RhinoStore_DBDataSet28();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet28)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendasDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // rhinoStore_DBDataSet27
            // 
            this.rhinoStore_DBDataSet27.DataSetName = "RhinoStore_DBDataSet27";
            this.rhinoStore_DBDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.rhinoStore_DBDataSet27;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Últimas vendas concluídas:";
            // 
            // rhinoStore_DBDataSet28
            // 
            this.rhinoStore_DBDataSet28.DataSetName = "RhinoStore_DBDataSet28";
            this.rhinoStore_DBDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "codigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            // 
            // idVendasDataGridViewTextBoxColumn
            // 
            this.idVendasDataGridViewTextBoxColumn.DataPropertyName = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.HeaderText = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.Name = "idVendasDataGridViewTextBoxColumn";
            this.idVendasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPesquisaCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPesquisaCompra";
            this.Text = "Pesquisa Compras";
            this.Load += new System.EventHandler(this.FormPesquisaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet28)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RhinoStore_DBDataSet27 rhinoStore_DBDataSet27;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private RhinoStore_DBDataSet27TableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.Label label1;
        private RhinoStore_DBDataSet28 rhinoStore_DBDataSet28;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}