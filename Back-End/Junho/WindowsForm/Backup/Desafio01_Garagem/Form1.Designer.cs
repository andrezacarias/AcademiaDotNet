﻿namespace Desafio01_Garagem
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
            this.lblVeiculosEstacionados = new System.Windows.Forms.Label();
            this.lblVeiculosSaida = new System.Windows.Forms.Label();
            this.dgEstacionados = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSaida = new System.Windows.Forms.DataGridView();
            this.PlacaSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstacionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).BeginInit();
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
            // lblVeiculosEstacionados
            // 
            this.lblVeiculosEstacionados.AutoSize = true;
            this.lblVeiculosEstacionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosEstacionados.Location = new System.Drawing.Point(32, 205);
            this.lblVeiculosEstacionados.Name = "lblVeiculosEstacionados";
            this.lblVeiculosEstacionados.Size = new System.Drawing.Size(190, 13);
            this.lblVeiculosEstacionados.TabIndex = 8;
            this.lblVeiculosEstacionados.Text = "Lista de Veículos Estacionados:";
            // 
            // lblVeiculosSaida
            // 
            this.lblVeiculosSaida.AutoSize = true;
            this.lblVeiculosSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculosSaida.Location = new System.Drawing.Point(31, 423);
            this.lblVeiculosSaida.Name = "lblVeiculosSaida";
            this.lblVeiculosSaida.Size = new System.Drawing.Size(179, 13);
            this.lblVeiculosSaida.TabIndex = 9;
            this.lblVeiculosSaida.Text = "Lista de Veículos que Saíram:";
            // 
            // dgEstacionados
            // 
            this.dgEstacionados.AllowDrop = true;
            this.dgEstacionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Data,
            this.Hora});
            this.dgEstacionados.Location = new System.Drawing.Point(35, 221);
            this.dgEstacionados.Name = "dgEstacionados";
            this.dgEstacionados.Size = new System.Drawing.Size(343, 163);
            this.dgEstacionados.TabIndex = 11;
            this.dgEstacionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstacionados_CellContentClick_1);
            // 
            // Placa
            // 
            this.Placa.FillWeight = 50F;
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // dgSaida
            // 
            this.dgSaida.AllowDrop = true;
            this.dgSaida.AllowUserToAddRows = false;
            this.dgSaida.AllowUserToDeleteRows = false;
            this.dgSaida.AllowUserToResizeColumns = false;
            this.dgSaida.AllowUserToResizeRows = false;
            this.dgSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlacaSai,
            this.Horas,
            this.Permanencia,
            this.Valor});
            this.dgSaida.Location = new System.Drawing.Point(35, 439);
            this.dgSaida.MultiSelect = false;
            this.dgSaida.Name = "dgSaida";
            this.dgSaida.Size = new System.Drawing.Size(444, 149);
            this.dgSaida.TabIndex = 12;
            // 
            // PlacaSai
            // 
            this.PlacaSai.HeaderText = "Placa";
            this.PlacaSai.Name = "PlacaSai";
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            // 
            // Permanencia
            // 
            this.Permanencia.HeaderText = "Permanencia";
            this.Permanencia.Name = "Permanencia";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // TelaPrincipalGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 612);
            this.Controls.Add(this.dgSaida);
            this.Controls.Add(this.dgEstacionados);
            this.Controls.Add(this.lblVeiculosSaida);
            this.Controls.Add(this.lblVeiculosEstacionados);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgEstacionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).EndInit();
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
        private System.Windows.Forms.Label lblVeiculosEstacionados;
        private System.Windows.Forms.Label lblVeiculosSaida;
        private System.Windows.Forms.DataGridView dgEstacionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridView dgSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaSai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}

