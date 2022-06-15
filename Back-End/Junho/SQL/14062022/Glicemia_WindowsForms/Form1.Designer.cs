namespace Glicemia_WindowsForms
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
            this.listView_medidasGlicemia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Conectar = new System.Windows.Forms.Button();
            this.lbl_idMedidaGlicemia = new System.Windows.Forms.Label();
            this.lbl_valorGlicemia = new System.Windows.Forms.Label();
            this.lbl_dataMedida = new System.Windows.Forms.Label();
            this.lbl_idPaciente = new System.Windows.Forms.Label();
            this.textBox_idGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_ValorGlicemia = new System.Windows.Forms.TextBox();
            this.textBox_DataMedida = new System.Windows.Forms.TextBox();
            this.textBox_idPaciente = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemia
            // 
            this.listView_medidasGlicemia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemia.HideSelection = false;
            this.listView_medidasGlicemia.Location = new System.Drawing.Point(12, 12);
            this.listView_medidasGlicemia.Name = "listView_medidasGlicemia";
            this.listView_medidasGlicemia.Size = new System.Drawing.Size(428, 292);
            this.listView_medidasGlicemia.TabIndex = 0;
            this.listView_medidasGlicemia.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idGlicemia";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            // 
            // button_Conectar
            // 
            this.button_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Conectar.Location = new System.Drawing.Point(75, 318);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(97, 23);
            this.button_Conectar.TabIndex = 1;
            this.button_Conectar.Text = "CONECTAR";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click);
            // 
            // lbl_idMedidaGlicemia
            // 
            this.lbl_idMedidaGlicemia.AutoSize = true;
            this.lbl_idMedidaGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idMedidaGlicemia.Location = new System.Drawing.Point(63, 374);
            this.lbl_idMedidaGlicemia.Name = "lbl_idMedidaGlicemia";
            this.lbl_idMedidaGlicemia.Size = new System.Drawing.Size(69, 13);
            this.lbl_idMedidaGlicemia.TabIndex = 2;
            this.lbl_idMedidaGlicemia.Text = "idGlicemia:";
            // 
            // lbl_valorGlicemia
            // 
            this.lbl_valorGlicemia.AutoSize = true;
            this.lbl_valorGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorGlicemia.Location = new System.Drawing.Point(44, 412);
            this.lbl_valorGlicemia.Name = "lbl_valorGlicemia";
            this.lbl_valorGlicemia.Size = new System.Drawing.Size(92, 13);
            this.lbl_valorGlicemia.TabIndex = 3;
            this.lbl_valorGlicemia.Text = "Valor Glicemia:";
            // 
            // lbl_dataMedida
            // 
            this.lbl_dataMedida.AutoSize = true;
            this.lbl_dataMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataMedida.Location = new System.Drawing.Point(44, 454);
            this.lbl_dataMedida.Name = "lbl_dataMedida";
            this.lbl_dataMedida.Size = new System.Drawing.Size(83, 13);
            this.lbl_dataMedida.TabIndex = 4;
            this.lbl_dataMedida.Text = "Data Medida:";
            // 
            // lbl_idPaciente
            // 
            this.lbl_idPaciente.AutoSize = true;
            this.lbl_idPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idPaciente.Location = new System.Drawing.Point(52, 494);
            this.lbl_idPaciente.Name = "lbl_idPaciente";
            this.lbl_idPaciente.Size = new System.Drawing.Size(75, 13);
            this.lbl_idPaciente.TabIndex = 5;
            this.lbl_idPaciente.Text = "id Paciente:";
            // 
            // textBox_idGlicemia
            // 
            this.textBox_idGlicemia.Location = new System.Drawing.Point(138, 371);
            this.textBox_idGlicemia.Name = "textBox_idGlicemia";
            this.textBox_idGlicemia.Size = new System.Drawing.Size(146, 20);
            this.textBox_idGlicemia.TabIndex = 6;
            // 
            // textBox_ValorGlicemia
            // 
            this.textBox_ValorGlicemia.Location = new System.Drawing.Point(136, 409);
            this.textBox_ValorGlicemia.Name = "textBox_ValorGlicemia";
            this.textBox_ValorGlicemia.Size = new System.Drawing.Size(148, 20);
            this.textBox_ValorGlicemia.TabIndex = 7;
            // 
            // textBox_DataMedida
            // 
            this.textBox_DataMedida.Location = new System.Drawing.Point(137, 451);
            this.textBox_DataMedida.Name = "textBox_DataMedida";
            this.textBox_DataMedida.Size = new System.Drawing.Size(147, 20);
            this.textBox_DataMedida.TabIndex = 8;
            // 
            // textBox_idPaciente
            // 
            this.textBox_idPaciente.Location = new System.Drawing.Point(139, 491);
            this.textBox_idPaciente.Name = "textBox_idPaciente";
            this.textBox_idPaciente.Size = new System.Drawing.Size(145, 20);
            this.textBox_idPaciente.TabIndex = 9;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(186, 541);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(274, 318);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(116, 25);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 611);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textBox_idPaciente);
            this.Controls.Add(this.textBox_DataMedida);
            this.Controls.Add(this.textBox_ValorGlicemia);
            this.Controls.Add(this.textBox_idGlicemia);
            this.Controls.Add(this.lbl_idPaciente);
            this.Controls.Add(this.lbl_dataMedida);
            this.Controls.Add(this.lbl_valorGlicemia);
            this.Controls.Add(this.lbl_idMedidaGlicemia);
            this.Controls.Add(this.button_Conectar);
            this.Controls.Add(this.listView_medidasGlicemia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_medidasGlicemia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.Label lbl_idMedidaGlicemia;
        private System.Windows.Forms.Label lbl_valorGlicemia;
        private System.Windows.Forms.Label lbl_dataMedida;
        private System.Windows.Forms.Label lbl_idPaciente;
        private System.Windows.Forms.TextBox textBox_idGlicemia;
        private System.Windows.Forms.TextBox textBox_ValorGlicemia;
        private System.Windows.Forms.TextBox textBox_DataMedida;
        private System.Windows.Forms.TextBox textBox_idPaciente;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnRemover;
    }
}

