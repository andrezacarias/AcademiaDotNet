namespace ProgramaDeCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.tbModeloCarro = new System.Windows.Forms.TextBox();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.cbQtdPortas = new System.Windows.Forms.ComboBox();
            this.lblQtdPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(415, 386);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 52);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(539, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLimpar.Size = new System.Drawing.Size(101, 52);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(195, 28);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(210, 20);
            this.tbFabricante.TabIndex = 2;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(101, 28);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(60, 13);
            this.lblFabricante.TabIndex = 3;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.Location = new System.Drawing.Point(195, 54);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(210, 20);
            this.tbModeloCarro.TabIndex = 4;
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.Location = new System.Drawing.Point(86, 57);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(88, 13);
            this.lblModeloCarro.TabIndex = 5;
            this.lblModeloCarro.Text = "Modelo do Carro:";
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar condicionado",
            "Direção Hidráulica",
            "Freios ABS",
            "Air Bag",
            "Vidros Elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(195, 119);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(210, 94);
            this.lbOpcionais.TabIndex = 6;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(89, 119);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(57, 13);
            this.lblOpcionais.TabIndex = 7;
            this.lblOpcionais.Text = "Opcionais:";
            // 
            // cbQtdPortas
            // 
            this.cbQtdPortas.FormattingEnabled = true;
            this.cbQtdPortas.Items.AddRange(new object[] {
            "2 Portas",
            "3 Portas",
            "4 portas",
            "5 Portas"});
            this.cbQtdPortas.Location = new System.Drawing.Point(195, 242);
            this.cbQtdPortas.Name = "cbQtdPortas";
            this.cbQtdPortas.Size = new System.Drawing.Size(210, 21);
            this.cbQtdPortas.TabIndex = 8;
            // 
            // lblQtdPortas
            // 
            this.lblQtdPortas.AutoSize = true;
            this.lblQtdPortas.Location = new System.Drawing.Point(62, 242);
            this.lblQtdPortas.Name = "lblQtdPortas";
            this.lblQtdPortas.Size = new System.Drawing.Size(112, 13);
            this.lblQtdPortas.TabIndex = 9;
            this.lblQtdPortas.Text = "Quantidade de portas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQtdPortas);
            this.Controls.Add(this.cbQtdPortas);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.lblModeloCarro);
            this.Controls.Add(this.tbModeloCarro);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox tbModeloCarro;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.ComboBox cbQtdPortas;
        private System.Windows.Forms.Label lblQtdPortas;
    }
}

