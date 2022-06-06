namespace Exercicio01WindowsForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(99, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(99, 60);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(102, 90);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(99, 123);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(99, 150);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(100, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(99, 231);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(153, 27);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(212, 20);
            this.tbNome.TabIndex = 7;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(153, 57);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(212, 20);
            this.tbTelefone.TabIndex = 8;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(153, 87);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(212, 20);
            this.tbCPF.TabIndex = 9;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(153, 120);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(212, 20);
            this.tbLogin.TabIndex = 10;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(153, 147);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(212, 20);
            this.tbSenha.TabIndex = 11;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(153, 187);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(94, 21);
            this.cbStatus.TabIndex = 12;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cbTipo.Location = new System.Drawing.Point(153, 228);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(94, 21);
            this.cbTipo.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(105, 301);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 49);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(244, 301);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 49);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 374);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Cadastro Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

