namespace CriptografiaAssimetrica
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriptografia = new System.Windows.Forms.Button();
            this.lblCripto = new System.Windows.Forms.Label();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescripto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbChave = new System.Windows.Forms.TextBox();
            this.btnCriptoSimetrico = new System.Windows.Forms.Button();
            this.btnDescriptoSimetrico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // tbFrase
            // 
            this.tbFrase.Location = new System.Drawing.Point(104, 33);
            this.tbFrase.Name = "tbFrase";
            this.tbFrase.Size = new System.Drawing.Size(164, 20);
            this.tbFrase.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frase criptografa:";
            // 
            // btnCriptografia
            // 
            this.btnCriptografia.Location = new System.Drawing.Point(207, 86);
            this.btnCriptografia.Name = "btnCriptografia";
            this.btnCriptografia.Size = new System.Drawing.Size(100, 44);
            this.btnCriptografia.TabIndex = 3;
            this.btnCriptografia.Text = "Cripto Assimetrica";
            this.btnCriptografia.UseVisualStyleBackColor = true;
            this.btnCriptografia.Click += new System.EventHandler(this.btnCriptografia_Click);
            // 
            // lblCripto
            // 
            this.lblCripto.AutoSize = true;
            this.lblCripto.Location = new System.Drawing.Point(230, 157);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(10, 13);
            this.lblCripto.TabIndex = 4;
            this.lblCripto.Text = "-";
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Location = new System.Drawing.Point(207, 196);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(100, 45);
            this.btnDescriptografar.TabIndex = 5;
            this.btnDescriptografar.Text = "Descripto Assimetrica";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase Descriptografada:";
            // 
            // lblDescripto
            // 
            this.lblDescripto.AutoSize = true;
            this.lblDescripto.Location = new System.Drawing.Point(230, 273);
            this.lblDescripto.Name = "lblDescripto";
            this.lblDescripto.Size = new System.Drawing.Size(10, 13);
            this.lblDescripto.TabIndex = 7;
            this.lblDescripto.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chave:";
            // 
            // txbChave
            // 
            this.txbChave.Location = new System.Drawing.Point(379, 35);
            this.txbChave.Name = "txbChave";
            this.txbChave.Size = new System.Drawing.Size(105, 20);
            this.txbChave.TabIndex = 9;
            // 
            // btnCriptoSimetrico
            // 
            this.btnCriptoSimetrico.Location = new System.Drawing.Point(379, 86);
            this.btnCriptoSimetrico.Name = "btnCriptoSimetrico";
            this.btnCriptoSimetrico.Size = new System.Drawing.Size(104, 44);
            this.btnCriptoSimetrico.TabIndex = 10;
            this.btnCriptoSimetrico.Text = "Cripto Simétrico";
            this.btnCriptoSimetrico.UseVisualStyleBackColor = true;
            this.btnCriptoSimetrico.Click += new System.EventHandler(this.btnCriptoSimetrico_Click);
            // 
            // btnDescriptoSimetrico
            // 
            this.btnDescriptoSimetrico.Location = new System.Drawing.Point(368, 196);
            this.btnDescriptoSimetrico.Name = "btnDescriptoSimetrico";
            this.btnDescriptoSimetrico.Size = new System.Drawing.Size(114, 44);
            this.btnDescriptoSimetrico.TabIndex = 11;
            this.btnDescriptoSimetrico.Text = "Descripto Simétrico";
            this.btnDescriptoSimetrico.UseVisualStyleBackColor = true;
            this.btnDescriptoSimetrico.Click += new System.EventHandler(this.btnDescriptoSimetrico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 363);
            this.Controls.Add(this.btnDescriptoSimetrico);
            this.Controls.Add(this.btnCriptoSimetrico);
            this.Controls.Add(this.txbChave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDescripto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.btnCriptografia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFrase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriptografia;
        private System.Windows.Forms.Label lblCripto;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescripto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbChave;
        private System.Windows.Forms.Button btnCriptoSimetrico;
        private System.Windows.Forms.Button btnDescriptoSimetrico;
    }
}

