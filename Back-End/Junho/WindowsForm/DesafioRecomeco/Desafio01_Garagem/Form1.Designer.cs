namespace Desafio01_Garagem
{
    partial class TelaPrincipalGaragem
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
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblHoraEntradaSaida = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lbEstacionados = new System.Windows.Forms.ListBox();
            this.lblVeiculosEstacionados = new System.Windows.Forms.Label();
            this.lblVeiculosSaida = new System.Windows.Forms.Label();
            this.lbSairam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(25, 33);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(50, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "PLACA:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(28, 50);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(100, 20);
            this.tbPlaca.TabIndex = 1;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(25, 78);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(78, 13);
            this.lblOperacao.TabIndex = 2;
            this.lblOperacao.Text = "OPERAÇÃO:";
            // 
            // cbOperacao
            // 
            this.cbOperacao.AccessibleDescription = "Escolha a operação: Entrada ou Saída";
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cbOperacao.Location = new System.Drawing.Point(28, 95);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(100, 21);
            this.cbOperacao.TabIndex = 3;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(144, 93);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(87, 23);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "EXECUTAR";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblHoraEntradaSaida
            // 
            this.lblHoraEntradaSaida.AutoSize = true;
            this.lblHoraEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntradaSaida.Location = new System.Drawing.Point(25, 131);
            this.lblHoraEntradaSaida.Name = "lblHoraEntradaSaida";
            this.lblHoraEntradaSaida.Size = new System.Drawing.Size(150, 13);
            this.lblHoraEntradaSaida.TabIndex = 5;
            this.lblHoraEntradaSaida.Text = "HORA ENTRADA SAIDA:";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(31, 156);
            this.mtbData.Mask = "00:00";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(55, 20);
            this.mtbData.TabIndex = 6;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // lbEstacionados
            // 
            this.lbEstacionados.FormattingEnabled = true;
            this.lbEstacionados.Location = new System.Drawing.Point(31, 216);
            this.lbEstacionados.Name = "lbEstacionados";
            this.lbEstacionados.Size = new System.Drawing.Size(273, 173);
            this.lbEstacionados.TabIndex = 7;
            // 
            // lblVeiculosEstacionados
            // 
            this.lblVeiculosEstacionados.AutoSize = true;
            this.lblVeiculosEstacionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosEstacionados.Location = new System.Drawing.Point(31, 197);
            this.lblVeiculosEstacionados.Name = "lblVeiculosEstacionados";
            this.lblVeiculosEstacionados.Size = new System.Drawing.Size(190, 13);
            this.lblVeiculosEstacionados.TabIndex = 8;
            this.lblVeiculosEstacionados.Text = "Lista de Veículos Estacionados:";
            // 
            // lblVeiculosSaida
            // 
            this.lblVeiculosSaida.AutoSize = true;
            this.lblVeiculosSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosSaida.Location = new System.Drawing.Point(31, 396);
            this.lblVeiculosSaida.Name = "lblVeiculosSaida";
            this.lblVeiculosSaida.Size = new System.Drawing.Size(179, 13);
            this.lblVeiculosSaida.TabIndex = 9;
            this.lblVeiculosSaida.Text = "Lista de Veículos que Saíram:";
            // 
            // lbSairam
            // 
            this.lbSairam.FormattingEnabled = true;
            this.lbSairam.Location = new System.Drawing.Point(36, 419);
            this.lbSairam.Name = "lbSairam";
            this.lbSairam.Size = new System.Drawing.Size(267, 173);
            this.lbSairam.TabIndex = 10;
            // 
            // TelaPrincipalGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 612);
            this.Controls.Add(this.lbSairam);
            this.Controls.Add(this.lblVeiculosSaida);
            this.Controls.Add(this.lblVeiculosEstacionados);
            this.Controls.Add(this.lbEstacionados);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblHoraEntradaSaida);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.cbOperacao);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Name = "TelaPrincipalGaragem";
            this.Text = "Grerenciamento de Garagem.";
            this.Load += new System.EventHandler(this.TelaPrincipalGaragem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.ComboBox cbOperacao;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblHoraEntradaSaida;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.ListBox lbEstacionados;
        private System.Windows.Forms.Label lblVeiculosEstacionados;
        private System.Windows.Forms.Label lblVeiculosSaida;
        private System.Windows.Forms.ListBox lbSairam;
    }
}

