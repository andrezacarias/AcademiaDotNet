namespace GerenciamentoDeVendas
{
    partial class FormCadastroVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbItemVenda = new System.Windows.Forms.TextBox();
            this.tbIdProduto = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbIdVenda = new System.Windows.Forms.TextBox();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.rhinoStore_DBDataSet = new GerenciamentoDeVendas.RhinoStore_DBDataSet();
            this.rhinoStoreDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rhinoStore_DBDataSet3 = new GerenciamentoDeVendas.RhinoStore_DBDataSet3();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet3TableAdapters.vendasTableAdapter();
            this.idVendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStoreDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Item Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id da Venda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Total:";
            // 
            // tbItemVenda
            // 
            this.tbItemVenda.Location = new System.Drawing.Point(113, 83);
            this.tbItemVenda.Name = "tbItemVenda";
            this.tbItemVenda.Size = new System.Drawing.Size(100, 20);
            this.tbItemVenda.TabIndex = 6;
            // 
            // tbIdProduto
            // 
            this.tbIdProduto.Location = new System.Drawing.Point(113, 110);
            this.tbIdProduto.Name = "tbIdProduto";
            this.tbIdProduto.Size = new System.Drawing.Size(100, 20);
            this.tbIdProduto.TabIndex = 7;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(113, 172);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidade.TabIndex = 8;
            // 
            // tbIdVenda
            // 
            this.tbIdVenda.Location = new System.Drawing.Point(113, 143);
            this.tbIdVenda.Name = "tbIdVenda";
            this.tbIdVenda.Size = new System.Drawing.Size(100, 20);
            this.tbIdVenda.TabIndex = 9;
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Location = new System.Drawing.Point(113, 204);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(100, 20);
            this.tbValorTotal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cadastro de Vendas";
            // 
            // dgVenda
            // 
            this.dgVenda.AutoGenerateColumns = false;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendasDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dgVenda.DataSource = this.vendasBindingSource;
            this.dgVenda.Location = new System.Drawing.Point(34, 255);
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.Size = new System.Drawing.Size(541, 220);
            this.dgVenda.TabIndex = 13;
            // 
            // rhinoStore_DBDataSet
            // 
            this.rhinoStore_DBDataSet.DataSetName = "RhinoStore_DBDataSet";
            this.rhinoStore_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rhinoStoreDBDataSetBindingSource
            // 
            this.rhinoStoreDBDataSetBindingSource.DataSource = this.rhinoStore_DBDataSet;
            this.rhinoStoreDBDataSetBindingSource.Position = 0;
            // 
            // rhinoStore_DBDataSet3
            // 
            this.rhinoStore_DBDataSet3.DataSetName = "RhinoStore_DBDataSet3";
            this.rhinoStore_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.rhinoStore_DBDataSet3;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // idVendasDataGridViewTextBoxColumn
            // 
            this.idVendasDataGridViewTextBoxColumn.DataPropertyName = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.HeaderText = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.Name = "idVendasDataGridViewTextBoxColumn";
            this.idVendasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "codigoCliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // FormCadastroVendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(587, 514);
            this.Controls.Add(this.dgVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.tbIdVenda);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.tbIdProduto);
            this.Controls.Add(this.tbItemVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroVendas";
            this.Text = "FormCadastroVendas";
            this.Load += new System.EventHandler(this.FormCadastroVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStoreDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbItemVenda;
        private System.Windows.Forms.TextBox tbIdProduto;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbIdVenda;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.BindingSource rhinoStoreDBDataSetBindingSource;
        private RhinoStore_DBDataSet rhinoStore_DBDataSet;
        private RhinoStore_DBDataSet3 rhinoStore_DBDataSet3;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private RhinoStore_DBDataSet3TableAdapters.vendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}