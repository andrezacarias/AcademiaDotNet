namespace GerenciamentoDeVendas
{
    partial class FormCarrinho
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rhinoStore_DBDataSet5 = new GerenciamentoDeVendas.RhinoStore_DBDataSet5();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rhinoStore_DBDataSet6 = new GerenciamentoDeVendas.RhinoStore_DBDataSet6();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.idVendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idItemVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rhinoStore_DBDataSet4 = new GerenciamentoDeVendas.RhinoStore_DBDataSet4();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rhinoStore_DBDataSet1 = new GerenciamentoDeVendas.RhinoStore_DBDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.itensVendidosTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet4TableAdapters.itensVendidosTableAdapter();
            this.clienteTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet5TableAdapters.ClienteTableAdapter();
            this.produtosTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet6TableAdapters.produtosTableAdapter();
            this.rhinoStore_DBDataSet16 = new GerenciamentoDeVendas.RhinoStore_DBDataSet16();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet16TableAdapters.ClientesTableAdapter();
            this.btnApagarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(389, 65);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(389, 114);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientesBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.rhinoStore_DBDataSet5;
            // 
            // rhinoStore_DBDataSet5
            // 
            this.rhinoStore_DBDataSet5.DataSetName = "RhinoStore_DBDataSet5";
            this.rhinoStore_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.produtosBindingSource;
            this.comboBox2.DisplayMember = "nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.rhinoStore_DBDataSet6;
            // 
            // rhinoStore_DBDataSet6
            // 
            this.rhinoStore_DBDataSet6.DataSetName = "RhinoStore_DBDataSet6";
            this.rhinoStore_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto:";
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.AutoGenerateColumns = false;
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendasDataGridViewTextBoxColumn,
            this.idItemVendaDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.idProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dgCarrinho.DataSource = this.itensVendidosBindingSource;
            this.dgCarrinho.Location = new System.Drawing.Point(33, 247);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.Size = new System.Drawing.Size(543, 281);
            this.dgCarrinho.TabIndex = 6;
            // 
            // idVendasDataGridViewTextBoxColumn
            // 
            this.idVendasDataGridViewTextBoxColumn.DataPropertyName = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.HeaderText = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.Name = "idVendasDataGridViewTextBoxColumn";
            this.idVendasDataGridViewTextBoxColumn.Width = 60;
            // 
            // idItemVendaDataGridViewTextBoxColumn
            // 
            this.idItemVendaDataGridViewTextBoxColumn.DataPropertyName = "idItemVenda";
            this.idItemVendaDataGridViewTextBoxColumn.HeaderText = "idItemVenda";
            this.idItemVendaDataGridViewTextBoxColumn.Name = "idItemVendaDataGridViewTextBoxColumn";
            this.idItemVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "valorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "valorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // itensVendidosBindingSource
            // 
            this.itensVendidosBindingSource.DataMember = "itensVendidos";
            this.itensVendidosBindingSource.DataSource = this.rhinoStore_DBDataSet4;
            // 
            // rhinoStore_DBDataSet4
            // 
            this.rhinoStore_DBDataSet4.DataSetName = "RhinoStore_DBDataSet4";
            this.rhinoStore_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "CARRINHO DE COMPRAS";
            // 
            // rhinoStore_DBDataSet1
            // 
            this.rhinoStore_DBDataSet1.DataSetName = "RhinoStore_DBDataSet";
            this.rhinoStore_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Itens no carrinho:";
            // 
            // itensVendidosTableAdapter
            // 
            this.itensVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // rhinoStore_DBDataSet16
            // 
            this.rhinoStore_DBDataSet16.DataSetName = "RhinoStore_DBDataSet16";
            this.rhinoStore_DBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.rhinoStore_DBDataSet16;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnApagarCompra
            // 
            this.btnApagarCompra.Location = new System.Drawing.Point(389, 173);
            this.btnApagarCompra.Name = "btnApagarCompra";
            this.btnApagarCompra.Size = new System.Drawing.Size(75, 21);
            this.btnApagarCompra.TabIndex = 11;
            this.btnApagarCompra.Text = "APAGAR";
            this.btnApagarCompra.UseVisualStyleBackColor = true;
            // 
            // FormCarrinho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(615, 552);
            this.Controls.Add(this.btnApagarCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgCarrinho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarrinho";
            this.Text = "FormCarrinho";
            this.Load += new System.EventHandler(this.FormCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgCarrinho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private RhinoStore_DBDataSet rhinoStore_DBDataSet1;
        private System.Windows.Forms.Label label5;
        private RhinoStore_DBDataSet4 rhinoStore_DBDataSet4;
        private System.Windows.Forms.BindingSource itensVendidosBindingSource;
        private RhinoStore_DBDataSet4TableAdapters.itensVendidosTableAdapter itensVendidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private RhinoStore_DBDataSet5 rhinoStore_DBDataSet5;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private RhinoStore_DBDataSet5TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private RhinoStore_DBDataSet6 rhinoStore_DBDataSet6;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private RhinoStore_DBDataSet6TableAdapters.produtosTableAdapter produtosTableAdapter;
        private RhinoStore_DBDataSet16 rhinoStore_DBDataSet16;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private RhinoStore_DBDataSet16TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btnApagarCompra;
    }
}