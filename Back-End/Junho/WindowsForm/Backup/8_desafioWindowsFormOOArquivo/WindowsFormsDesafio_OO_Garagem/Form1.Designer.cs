namespace WindowsFormsDesafio_OO_Garagem
{
    partial class LblHoraDeEntrada
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.lblListaveiculos = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lbEntrada = new System.Windows.Forms.ListBox();
            this.lbSaida = new System.Windows.Forms.ListBox();
            this.cbEntradaSaida = new System.Windows.Forms.ComboBox();
            this.lblEntradaSaida = new System.Windows.Forms.Label();
            this.lblEstadia = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lbValorEstadia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(27, 84);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(50, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(165, 84);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(152, 13);
            this.lblHoraEntrada.TabIndex = 2;
            this.lblHoraEntrada.Text = "HORA ENTRADA/SAÍDA:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(30, 100);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(100, 20);
            this.tbPlaca.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(178, 163);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "ENTRADA";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Location = new System.Drawing.Point(309, 163);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(100, 23);
            this.btnSaida.TabIndex = 9;
            this.btnSaida.Text = "SAÍDA";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblListaveiculos
            // 
            this.lblListaveiculos.AutoSize = true;
            this.lblListaveiculos.Location = new System.Drawing.Point(30, 220);
            this.lblListaveiculos.Name = "lblListaveiculos";
            this.lblListaveiculos.Size = new System.Drawing.Size(157, 13);
            this.lblListaveiculos.TabIndex = 14;
            this.lblListaveiculos.Text = "Lista de veículos estacionados:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(326, 220);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(147, 13);
            this.lblSaida.TabIndex = 15;
            this.lblSaida.Text = "Lista de veículos que saíram:";
            // 
            // lbEntrada
            // 
            this.lbEntrada.Enabled = false;
            this.lbEntrada.FormattingEnabled = true;
            this.lbEntrada.Location = new System.Drawing.Point(33, 249);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(245, 160);
            this.lbEntrada.TabIndex = 16;
            // 
            // lbSaida
            // 
            this.lbSaida.Enabled = false;
            this.lbSaida.FormattingEnabled = true;
            this.lbSaida.Location = new System.Drawing.Point(324, 249);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(248, 160);
            this.lbSaida.TabIndex = 17;
            // 
            // cbEntradaSaida
            // 
            this.cbEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEntradaSaida.FormattingEnabled = true;
            this.cbEntradaSaida.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbEntradaSaida.Location = new System.Drawing.Point(30, 163);
            this.cbEntradaSaida.Name = "cbEntradaSaida";
            this.cbEntradaSaida.Size = new System.Drawing.Size(100, 24);
            this.cbEntradaSaida.TabIndex = 18;
            // 
            // lblEntradaSaida
            // 
            this.lblEntradaSaida.AutoSize = true;
            this.lblEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaSaida.Location = new System.Drawing.Point(27, 147);
            this.lblEntradaSaida.Name = "lblEntradaSaida";
            this.lblEntradaSaida.Size = new System.Drawing.Size(78, 13);
            this.lblEntradaSaida.TabIndex = 19;
            this.lblEntradaSaida.Text = "OPERAÇÃO:";
            // 
            // lblEstadia
            // 
            this.lblEstadia.AutoSize = true;
            this.lblEstadia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadia.Location = new System.Drawing.Point(357, 84);
            this.lblEstadia.Name = "lblEstadia";
            this.lblEstadia.Size = new System.Drawing.Size(116, 13);
            this.lblEstadia.TabIndex = 20;
            this.lblEstadia.Text = "VALOR COBRADO:";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(168, 100);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(149, 20);
            this.dtpHoraEntrada.TabIndex = 22;
            // 
            // lbValorEstadia
            // 
            this.lbValorEstadia.FormattingEnabled = true;
            this.lbValorEstadia.Location = new System.Drawing.Point(360, 100);
            this.lbValorEstadia.Name = "lbValorEstadia";
            this.lbValorEstadia.Size = new System.Drawing.Size(113, 30);
            this.lbValorEstadia.TabIndex = 24;
            // 
            // LblHoraDeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 427);
            this.Controls.Add(this.lbValorEstadia);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.lblEstadia);
            this.Controls.Add(this.lblEntradaSaida);
            this.Controls.Add(this.cbEntradaSaida);
            this.Controls.Add(this.lbSaida);
            this.Controls.Add(this.lbEntrada);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblListaveiculos);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblPlaca);
            this.Name = "LblHoraDeEntrada";
            this.Text = "Gerenciamento de Entrada e Saída";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Label lblListaveiculos;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.ListBox lbEntrada;
        private System.Windows.Forms.ListBox lbSaida;
        private System.Windows.Forms.ComboBox cbEntradaSaida;
        private System.Windows.Forms.Label lblEntradaSaida;
        private System.Windows.Forms.Label lblEstadia;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.ListBox lbValorEstadia;
    }
}

