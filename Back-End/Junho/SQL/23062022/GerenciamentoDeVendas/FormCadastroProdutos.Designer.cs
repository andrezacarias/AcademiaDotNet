namespace GerenciamentoDeVendas
{
    partial class FormCadastroProdutos
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
            this.lblIdProdutos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdProduto = new System.Windows.Forms.TextBox();
            this.tbCodEAN = new System.Windows.Forms.TextBox();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.lblCadastroProdutos = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnApagarProduto = new System.Windows.Forms.Button();
            this.rhinoStore_DBDataSet7 = new GerenciamentoDeVendas.RhinoStore_DBDataSet7();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet7TableAdapters.produtosTableAdapter();
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rhinoStore_DBDataSet10 = new GerenciamentoDeVendas.RhinoStore_DBDataSet10();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rhinoStore_DBDataSet8 = new GerenciamentoDeVendas.RhinoStore_DBDataSet8();
            this.produtosTableAdapter1 = new GerenciamentoDeVendas.RhinoStore_DBDataSet8TableAdapters.produtosTableAdapter();
            this.rhinoStore_DBDataSet9 = new GerenciamentoDeVendas.RhinoStore_DBDataSet9();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new GerenciamentoDeVendas.RhinoStore_DBDataSet9TableAdapters.ClienteTableAdapter();
            this.produtosTableAdapter2 = new GerenciamentoDeVendas.RhinoStore_DBDataSet10TableAdapters.produtosTableAdapter();
            this.rhinoStore_DBDataSet11 = new GerenciamentoDeVendas.RhinoStore_DBDataSet11();
            this.produtosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter3 = new GerenciamentoDeVendas.RhinoStore_DBDataSet11TableAdapters.produtosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rhinoStore_DBDataSet12 = new GerenciamentoDeVendas.RhinoStore_DBDataSet12();
            this.produtosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter4 = new GerenciamentoDeVendas.RhinoStore_DBDataSet12TableAdapters.produtosTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProdutos
            // 
            this.lblIdProdutos.AutoSize = true;
            this.lblIdProdutos.Location = new System.Drawing.Point(28, 64);
            this.lblIdProdutos.Name = "lblIdProdutos";
            this.lblIdProdutos.Size = new System.Drawing.Size(59, 13);
            this.lblIdProdutos.TabIndex = 0;
            this.lblIdProdutos.Text = "Id Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod. EAN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estoque:";
            // 
            // tbIdProduto
            // 
            this.tbIdProduto.Location = new System.Drawing.Point(130, 64);
            this.tbIdProduto.Name = "tbIdProduto";
            this.tbIdProduto.Size = new System.Drawing.Size(210, 20);
            this.tbIdProduto.TabIndex = 5;
            // 
            // tbCodEAN
            // 
            this.tbCodEAN.Location = new System.Drawing.Point(130, 101);
            this.tbCodEAN.Name = "tbCodEAN";
            this.tbCodEAN.Size = new System.Drawing.Size(210, 20);
            this.tbCodEAN.TabIndex = 6;
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(130, 131);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(210, 20);
            this.tbNomeProduto.TabIndex = 7;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(130, 163);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(210, 20);
            this.tbPreco.TabIndex = 8;
            // 
            // tbEstoque
            // 
            this.tbEstoque.Location = new System.Drawing.Point(130, 200);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(210, 20);
            this.tbEstoque.TabIndex = 9;
            // 
            // lblCadastroProdutos
            // 
            this.lblCadastroProdutos.AutoSize = true;
            this.lblCadastroProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProdutos.Location = new System.Drawing.Point(194, 24);
            this.lblCadastroProdutos.Name = "lblCadastroProdutos";
            this.lblCadastroProdutos.Size = new System.Drawing.Size(211, 24);
            this.lblCadastroProdutos.TabIndex = 10;
            this.lblCadastroProdutos.Text = "Cadastro de Produtos";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(412, 64);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(87, 54);
            this.btnCadastrarProduto.TabIndex = 11;
            this.btnCadastrarProduto.Text = "CADASTRAR PRODUTO";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnApagarProduto
            // 
            this.btnApagarProduto.Location = new System.Drawing.Point(412, 169);
            this.btnApagarProduto.Name = "btnApagarProduto";
            this.btnApagarProduto.Size = new System.Drawing.Size(87, 51);
            this.btnApagarProduto.TabIndex = 13;
            this.btnApagarProduto.Text = "APAGAR";
            this.btnApagarProduto.UseVisualStyleBackColor = true;
            // 
            // rhinoStore_DBDataSet7
            // 
            this.rhinoStore_DBDataSet7.DataSetName = "RhinoStore_DBDataSet7";
            this.rhinoStore_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.rhinoStore_DBDataSet7;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "produtos";
            this.produtosBindingSource2.DataSource = this.rhinoStore_DBDataSet10;
            // 
            // rhinoStore_DBDataSet10
            // 
            this.rhinoStore_DBDataSet10.DataSetName = "RhinoStore_DBDataSet10";
            this.rhinoStore_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            this.produtosBindingSource1.DataSource = this.rhinoStore_DBDataSet8;
            // 
            // rhinoStore_DBDataSet8
            // 
            this.rhinoStore_DBDataSet8.DataSetName = "RhinoStore_DBDataSet8";
            this.rhinoStore_DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // rhinoStore_DBDataSet9
            // 
            this.rhinoStore_DBDataSet9.DataSetName = "RhinoStore_DBDataSet9";
            this.rhinoStore_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.rhinoStore_DBDataSet9;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter2
            // 
            this.produtosTableAdapter2.ClearBeforeFill = true;
            // 
            // rhinoStore_DBDataSet11
            // 
            this.rhinoStore_DBDataSet11.DataSetName = "RhinoStore_DBDataSet11";
            this.rhinoStore_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource3
            // 
            this.produtosBindingSource3.DataMember = "produtos";
            this.produtosBindingSource3.DataSource = this.rhinoStore_DBDataSet11;
            // 
            // produtosTableAdapter3
            // 
            this.produtosTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.codEANDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(31, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 256);
            this.dataGridView1.TabIndex = 14;
            // 
            // rhinoStore_DBDataSet12
            // 
            this.rhinoStore_DBDataSet12.DataSetName = "RhinoStore_DBDataSet12";
            this.rhinoStore_DBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource4
            // 
            this.produtosBindingSource4.DataMember = "produtos";
            this.produtosBindingSource4.DataSource = this.rhinoStore_DBDataSet12;
            // 
            // produtosTableAdapter4
            // 
            this.produtosTableAdapter4.ClearBeforeFill = true;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // codEANDataGridViewTextBoxColumn
            // 
            this.codEANDataGridViewTextBoxColumn.DataPropertyName = "CodEAN";
            this.codEANDataGridViewTextBoxColumn.HeaderText = "CodEAN";
            this.codEANDataGridViewTextBoxColumn.Name = "codEANDataGridViewTextBoxColumn";
            // 
            // FormCadastroProdutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(618, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnApagarProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.lblCadastroProdutos);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.tbCodEAN);
            this.Controls.Add(this.tbIdProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroProdutos";
            this.Text = "FormCadastroProdutos";
            this.Load += new System.EventHandler(this.FormCadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhinoStore_DBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdProduto;
        private System.Windows.Forms.TextBox tbCodEAN;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.Label lblCadastroProdutos;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnApagarProduto;
        private RhinoStore_DBDataSet7 rhinoStore_DBDataSet7;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private RhinoStore_DBDataSet7TableAdapters.produtosTableAdapter produtosTableAdapter;
        private RhinoStore_DBDataSet8 rhinoStore_DBDataSet8;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private RhinoStore_DBDataSet8TableAdapters.produtosTableAdapter produtosTableAdapter1;
        private RhinoStore_DBDataSet9 rhinoStore_DBDataSet9;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private RhinoStore_DBDataSet9TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private RhinoStore_DBDataSet10 rhinoStore_DBDataSet10;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private RhinoStore_DBDataSet10TableAdapters.produtosTableAdapter produtosTableAdapter2;
        private RhinoStore_DBDataSet11 rhinoStore_DBDataSet11;
        private System.Windows.Forms.BindingSource produtosBindingSource3;
        private RhinoStore_DBDataSet11TableAdapters.produtosTableAdapter produtosTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RhinoStore_DBDataSet12 rhinoStore_DBDataSet12;
        private System.Windows.Forms.BindingSource produtosBindingSource4;
        private RhinoStore_DBDataSet12TableAdapters.produtosTableAdapter produtosTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEANDataGridViewTextBoxColumn;
    }
}