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
            this.btnListaProduto = new System.Windows.Forms.Button();
            this.btnHomeProduto = new System.Windows.Forms.Button();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.dgIdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Produto:";
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
            this.btnCadastrarProduto.Location = new System.Drawing.Point(412, 77);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(75, 37);
            this.btnCadastrarProduto.TabIndex = 11;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // btnListaProduto
            // 
            this.btnListaProduto.Location = new System.Drawing.Point(412, 133);
            this.btnListaProduto.Name = "btnListaProduto";
            this.btnListaProduto.Size = new System.Drawing.Size(75, 23);
            this.btnListaProduto.TabIndex = 12;
            this.btnListaProduto.Text = "Ir para Lista";
            this.btnListaProduto.UseVisualStyleBackColor = true;
            // 
            // btnHomeProduto
            // 
            this.btnHomeProduto.Location = new System.Drawing.Point(412, 191);
            this.btnHomeProduto.Name = "btnHomeProduto";
            this.btnHomeProduto.Size = new System.Drawing.Size(75, 23);
            this.btnHomeProduto.TabIndex = 13;
            this.btnHomeProduto.Text = "HOME";
            this.btnHomeProduto.UseVisualStyleBackColor = true;
            // 
            // dgVendas
            // 
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdVenda,
            this.dgCodigoCliente,
            this.dgValorTotal,
            this.dgPreco,
            this.dgEstoque});
            this.dgVendas.Location = new System.Drawing.Point(34, 243);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.Size = new System.Drawing.Size(544, 211);
            this.dgVendas.TabIndex = 14;
            // 
            // dgIdVenda
            // 
            this.dgIdVenda.HeaderText = "Id Produtos";
            this.dgIdVenda.Name = "dgIdVenda";
            // 
            // dgCodigoCliente
            // 
            this.dgCodigoCliente.HeaderText = "Cod EAN";
            this.dgCodigoCliente.Name = "dgCodigoCliente";
            // 
            // dgValorTotal
            // 
            this.dgValorTotal.HeaderText = "Nome";
            this.dgValorTotal.Name = "dgValorTotal";
            // 
            // dgPreco
            // 
            this.dgPreco.HeaderText = "Preço";
            this.dgPreco.Name = "dgPreco";
            // 
            // dgEstoque
            // 
            this.dgEstoque.HeaderText = "Estoque";
            this.dgEstoque.Name = "dgEstoque";
            // 
            // FormCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 483);
            this.Controls.Add(this.dgVendas);
            this.Controls.Add(this.btnHomeProduto);
            this.Controls.Add(this.btnListaProduto);
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
            this.Name = "FormCadastroProdutos";
            this.Text = "FormCadastroProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
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
        private System.Windows.Forms.Button btnListaProduto;
        private System.Windows.Forms.Button btnHomeProduto;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEstoque;
    }
}