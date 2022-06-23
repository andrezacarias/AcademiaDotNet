namespace DesafioWindowsFormsOOArquivo
{
    partial class TelaPrincipal
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
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblListaEsta = new System.Windows.Forms.Label();
            this.lblListaSaiu = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(26, 68);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(69, 20);
            this.tbPlaca.TabIndex = 0;
            this.tbPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(30, 52);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(50, 13);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(150, 102);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(109, 13);
            this.lblHoraEntrada.TabIndex = 6;
            this.lblHoraEntrada.Text = "HORA ENTRADA:";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaida.Location = new System.Drawing.Point(150, 154);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(87, 13);
            this.lblHoraSaida.TabIndex = 7;
            this.lblHoraSaida.Text = "HORA SAÍDA:";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(152, 52);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(107, 13);
            this.lblDataEntrada.TabIndex = 8;
            this.lblDataEntrada.Text = "DATA ENTRADA:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(26, 108);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(92, 30);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.Location = new System.Drawing.Point(27, 168);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(91, 25);
            this.btnSaida.TabIndex = 11;
            this.btnSaida.Text = "SAIDA";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 257);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 173);
            this.listBox1.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(295, 257);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 173);
            this.listBox2.TabIndex = 13;
            // 
            // lblListaEsta
            // 
            this.lblListaEsta.AutoSize = true;
            this.lblListaEsta.Location = new System.Drawing.Point(53, 241);
            this.lblListaEsta.Name = "lblListaEsta";
            this.lblListaEsta.Size = new System.Drawing.Size(184, 13);
            this.lblListaEsta.TabIndex = 14;
            this.lblListaEsta.Text = "Lista de veículos no estacionamento:";
            // 
            // lblListaSaiu
            // 
            this.lblListaSaiu.AutoSize = true;
            this.lblListaSaiu.Location = new System.Drawing.Point(307, 241);
            this.lblListaSaiu.Name = "lblListaSaiu";
            this.lblListaSaiu.Size = new System.Drawing.Size(199, 13);
            this.lblListaSaiu.TabIndex = 15;
            this.lblListaSaiu.Text = "Veiculos que saíram do estacionamento:";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(153, 68);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(106, 20);
            this.dtpDataEntrada.TabIndex = 16;
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(153, 118);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(104, 20);
            this.dtpHoraEntrada.TabIndex = 18;
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(151, 183);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(106, 20);
            this.dtpHoraSaida.TabIndex = 19;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 461);
            this.Controls.Add(this.dtpHoraSaida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.lblListaSaiu);
            this.Controls.Add(this.lblListaEsta);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.tbPlaca);
            this.Name = "TelaPrincipal";
            this.Text = "Gerenciamento de Entrada e Saída.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblListaEsta;
        private System.Windows.Forms.Label lblListaSaiu;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
    }
}

