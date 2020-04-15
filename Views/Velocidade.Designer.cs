namespace Semaforo
{
    partial class Velocidade
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
            this.GrpBoxViagem = new System.Windows.Forms.GroupBox();
            this.LblTempoHoras = new System.Windows.Forms.Label();
            this.LblDistanciaKm = new System.Windows.Forms.Label();
            this.TxtBoxTempo = new System.Windows.Forms.TextBox();
            this.TxtBoxDistancia = new System.Windows.Forms.TextBox();
            this.LblTempoGasto = new System.Windows.Forms.Label();
            this.LblDistancia = new System.Windows.Forms.Label();
            this.GrpBoxVelocidade = new System.Windows.Forms.GroupBox();
            this.LblVelMaxKmHora = new System.Windows.Forms.Label();
            this.TxtBoxVelMax = new System.Windows.Forms.TextBox();
            this.LblVelocidadeMaxima = new System.Windows.Forms.Label();
            this.LblVelocidadeMedia = new System.Windows.Forms.Label();
            this.TxtBoxVelMed = new System.Windows.Forms.TextBox();
            this.LblVelMedKmHora = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.GrpBoxViagem.SuspendLayout();
            this.GrpBoxVelocidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxViagem
            // 
            this.GrpBoxViagem.Controls.Add(this.LblTempoHoras);
            this.GrpBoxViagem.Controls.Add(this.LblDistanciaKm);
            this.GrpBoxViagem.Controls.Add(this.TxtBoxTempo);
            this.GrpBoxViagem.Controls.Add(this.TxtBoxDistancia);
            this.GrpBoxViagem.Controls.Add(this.LblTempoGasto);
            this.GrpBoxViagem.Controls.Add(this.LblDistancia);
            this.GrpBoxViagem.Location = new System.Drawing.Point(12, 12);
            this.GrpBoxViagem.Name = "GrpBoxViagem";
            this.GrpBoxViagem.Size = new System.Drawing.Size(235, 100);
            this.GrpBoxViagem.TabIndex = 0;
            this.GrpBoxViagem.TabStop = false;
            this.GrpBoxViagem.Text = "Dados da viagem";
            // 
            // LblTempoHoras
            // 
            this.LblTempoHoras.AutoSize = true;
            this.LblTempoHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempoHoras.Location = new System.Drawing.Point(189, 58);
            this.LblTempoHoras.Name = "LblTempoHoras";
            this.LblTempoHoras.Size = new System.Drawing.Size(40, 13);
            this.LblTempoHoras.TabIndex = 10;
            this.LblTempoHoras.Text = "Horas";
            // 
            // LblDistanciaKm
            // 
            this.LblDistanciaKm.AutoSize = true;
            this.LblDistanciaKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDistanciaKm.Location = new System.Drawing.Point(189, 23);
            this.LblDistanciaKm.Name = "LblDistanciaKm";
            this.LblDistanciaKm.Size = new System.Drawing.Size(24, 13);
            this.LblDistanciaKm.TabIndex = 9;
            this.LblDistanciaKm.Text = "Km";
            // 
            // TxtBoxTempo
            // 
            this.TxtBoxTempo.Location = new System.Drawing.Point(84, 55);
            this.TxtBoxTempo.Name = "TxtBoxTempo";
            this.TxtBoxTempo.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxTempo.TabIndex = 6;
            // 
            // TxtBoxDistancia
            // 
            this.TxtBoxDistancia.Location = new System.Drawing.Point(84, 20);
            this.TxtBoxDistancia.Name = "TxtBoxDistancia";
            this.TxtBoxDistancia.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxDistancia.TabIndex = 5;
            // 
            // LblTempoGasto
            // 
            this.LblTempoGasto.AutoSize = true;
            this.LblTempoGasto.Location = new System.Drawing.Point(6, 58);
            this.LblTempoGasto.Name = "LblTempoGasto";
            this.LblTempoGasto.Size = new System.Drawing.Size(72, 13);
            this.LblTempoGasto.TabIndex = 3;
            this.LblTempoGasto.Text = "Tempo gasto:";
            // 
            // LblDistancia
            // 
            this.LblDistancia.AutoSize = true;
            this.LblDistancia.Location = new System.Drawing.Point(6, 26);
            this.LblDistancia.Name = "LblDistancia";
            this.LblDistancia.Size = new System.Drawing.Size(54, 13);
            this.LblDistancia.TabIndex = 2;
            this.LblDistancia.Text = "Distância:";
            // 
            // GrpBoxVelocidade
            // 
            this.GrpBoxVelocidade.Controls.Add(this.LblVelMaxKmHora);
            this.GrpBoxVelocidade.Controls.Add(this.TxtBoxVelMax);
            this.GrpBoxVelocidade.Controls.Add(this.LblVelocidadeMaxima);
            this.GrpBoxVelocidade.Location = new System.Drawing.Point(277, 12);
            this.GrpBoxVelocidade.Name = "GrpBoxVelocidade";
            this.GrpBoxVelocidade.Size = new System.Drawing.Size(235, 100);
            this.GrpBoxVelocidade.TabIndex = 1;
            this.GrpBoxVelocidade.TabStop = false;
            // 
            // LblVelMaxKmHora
            // 
            this.LblVelMaxKmHora.AutoSize = true;
            this.LblVelMaxKmHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVelMaxKmHora.Location = new System.Drawing.Point(115, 54);
            this.LblVelMaxKmHora.Name = "LblVelMaxKmHora";
            this.LblVelMaxKmHora.Size = new System.Drawing.Size(55, 13);
            this.LblVelMaxKmHora.TabIndex = 8;
            this.LblVelMaxKmHora.Text = "Km/hora";
            // 
            // TxtBoxVelMax
            // 
            this.TxtBoxVelMax.Location = new System.Drawing.Point(9, 51);
            this.TxtBoxVelMax.Name = "TxtBoxVelMax";
            this.TxtBoxVelMax.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxVelMax.TabIndex = 7;
            // 
            // LblVelocidadeMaxima
            // 
            this.LblVelocidadeMaxima.AutoSize = true;
            this.LblVelocidadeMaxima.Location = new System.Drawing.Point(6, 26);
            this.LblVelocidadeMaxima.Name = "LblVelocidadeMaxima";
            this.LblVelocidadeMaxima.Size = new System.Drawing.Size(143, 13);
            this.LblVelocidadeMaxima.TabIndex = 4;
            this.LblVelocidadeMaxima.Text = "Velocidade máxima permitida";
            // 
            // LblVelocidadeMedia
            // 
            this.LblVelocidadeMedia.AutoSize = true;
            this.LblVelocidadeMedia.Location = new System.Drawing.Point(105, 159);
            this.LblVelocidadeMedia.Name = "LblVelocidadeMedia";
            this.LblVelocidadeMedia.Size = new System.Drawing.Size(94, 13);
            this.LblVelocidadeMedia.TabIndex = 2;
            this.LblVelocidadeMedia.Text = "Velocidade média:";
            // 
            // TxtBoxVelMed
            // 
            this.TxtBoxVelMed.BackColor = System.Drawing.Color.Thistle;
            this.TxtBoxVelMed.Enabled = false;
            this.TxtBoxVelMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxVelMed.Location = new System.Drawing.Point(204, 156);
            this.TxtBoxVelMed.Name = "TxtBoxVelMed";
            this.TxtBoxVelMed.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxVelMed.TabIndex = 3;
            // 
            // LblVelMedKmHora
            // 
            this.LblVelMedKmHora.AutoSize = true;
            this.LblVelMedKmHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVelMedKmHora.Location = new System.Drawing.Point(310, 159);
            this.LblVelMedKmHora.Name = "LblVelMedKmHora";
            this.LblVelMedKmHora.Size = new System.Drawing.Size(55, 13);
            this.LblVelMedKmHora.TabIndex = 4;
            this.LblVelMedKmHora.Text = "Km/hora";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(21, 223);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(130, 23);
            this.BtnNovo.TabIndex = 5;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(214, 223);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(120, 23);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisualizar.Location = new System.Drawing.Point(392, 223);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(120, 23);
            this.BtnVisualizar.TabIndex = 7;
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.UseVisualStyleBackColor = true;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // Velocidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 258);
            this.Controls.Add(this.BtnVisualizar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LblVelMedKmHora);
            this.Controls.Add(this.TxtBoxVelMed);
            this.Controls.Add(this.LblVelocidadeMedia);
            this.Controls.Add(this.GrpBoxVelocidade);
            this.Controls.Add(this.GrpBoxViagem);
            this.Name = "Velocidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Running 1.0";
            this.GrpBoxViagem.ResumeLayout(false);
            this.GrpBoxViagem.PerformLayout();
            this.GrpBoxVelocidade.ResumeLayout(false);
            this.GrpBoxVelocidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxViagem;
        private System.Windows.Forms.Label LblTempoHoras;
        private System.Windows.Forms.Label LblDistanciaKm;
        private System.Windows.Forms.TextBox TxtBoxTempo;
        private System.Windows.Forms.TextBox TxtBoxDistancia;
        private System.Windows.Forms.Label LblTempoGasto;
        private System.Windows.Forms.Label LblDistancia;
        private System.Windows.Forms.GroupBox GrpBoxVelocidade;
        private System.Windows.Forms.Label LblVelMaxKmHora;
        private System.Windows.Forms.TextBox TxtBoxVelMax;
        private System.Windows.Forms.Label LblVelocidadeMaxima;
        private System.Windows.Forms.Label LblVelocidadeMedia;
        private System.Windows.Forms.TextBox TxtBoxVelMed;
        private System.Windows.Forms.Label LblVelMedKmHora;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnVisualizar;
    }
}

