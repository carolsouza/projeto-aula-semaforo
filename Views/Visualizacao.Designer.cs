namespace Semaforo.Views
{
    partial class Visualizacao
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
            this.components = new System.ComponentModel.Container();
            this.LblVelPermitida = new System.Windows.Forms.Label();
            this.LblVelMedia = new System.Windows.Forms.Label();
            this.LblKm1 = new System.Windows.Forms.Label();
            this.LblKm2 = new System.Windows.Forms.Label();
            this.LblMsg1 = new System.Windows.Forms.Label();
            this.LblVelExcedida = new System.Windows.Forms.Label();
            this.LblMsg2 = new System.Windows.Forms.Label();
            this.TxtVelPermitida = new System.Windows.Forms.TextBox();
            this.TxtVelMedia = new System.Windows.Forms.TextBox();
            this.TxtVelExcedida = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVelPermitida
            // 
            this.LblVelPermitida.AutoSize = true;
            this.LblVelPermitida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVelPermitida.Location = new System.Drawing.Point(27, 32);
            this.LblVelPermitida.Name = "LblVelPermitida";
            this.LblVelPermitida.Size = new System.Drawing.Size(125, 13);
            this.LblVelPermitida.TabIndex = 0;
            this.LblVelPermitida.Text = "Velocidade permitida";
            // 
            // LblVelMedia
            // 
            this.LblVelMedia.AutoSize = true;
            this.LblVelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVelMedia.Location = new System.Drawing.Point(27, 72);
            this.LblVelMedia.Name = "LblVelMedia";
            this.LblVelMedia.Size = new System.Drawing.Size(107, 13);
            this.LblVelMedia.TabIndex = 1;
            this.LblVelMedia.Text = "Velocidade média";
            // 
            // LblKm1
            // 
            this.LblKm1.AutoSize = true;
            this.LblKm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKm1.Location = new System.Drawing.Point(301, 32);
            this.LblKm1.Name = "LblKm1";
            this.LblKm1.Size = new System.Drawing.Size(37, 13);
            this.LblKm1.TabIndex = 2;
            this.LblKm1.Text = "Km/h";
            // 
            // LblKm2
            // 
            this.LblKm2.AutoSize = true;
            this.LblKm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKm2.Location = new System.Drawing.Point(301, 63);
            this.LblKm2.Name = "LblKm2";
            this.LblKm2.Size = new System.Drawing.Size(37, 13);
            this.LblKm2.TabIndex = 3;
            this.LblKm2.Text = "Km/h";
            // 
            // LblMsg1
            // 
            this.LblMsg1.AutoSize = true;
            this.LblMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg1.Location = new System.Drawing.Point(27, 225);
            this.LblMsg1.Name = "LblMsg1";
            this.LblMsg1.Size = new System.Drawing.Size(82, 13);
            this.LblMsg1.TabIndex = 4;
            this.LblMsg1.Text = "Mensagem 1:";
            // 
            // LblVelExcedida
            // 
            this.LblVelExcedida.AutoSize = true;
            this.LblVelExcedida.Location = new System.Drawing.Point(27, 253);
            this.LblVelExcedida.Name = "LblVelExcedida";
            this.LblVelExcedida.Size = new System.Drawing.Size(105, 13);
            this.LblVelExcedida.TabIndex = 5;
            this.LblVelExcedida.Text = "Qtde Km/h excedida";
            // 
            // LblMsg2
            // 
            this.LblMsg2.AutoSize = true;
            this.LblMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg2.ForeColor = System.Drawing.Color.DarkRed;
            this.LblMsg2.Location = new System.Drawing.Point(27, 296);
            this.LblMsg2.Name = "LblMsg2";
            this.LblMsg2.Size = new System.Drawing.Size(78, 13);
            this.LblMsg2.TabIndex = 6;
            this.LblMsg2.Text = "Mensagem 2";
            // 
            // TxtVelPermitida
            // 
            this.TxtVelPermitida.BackColor = System.Drawing.SystemColors.Info;
            this.TxtVelPermitida.Location = new System.Drawing.Point(158, 32);
            this.TxtVelPermitida.Name = "TxtVelPermitida";
            this.TxtVelPermitida.Size = new System.Drawing.Size(100, 20);
            this.TxtVelPermitida.TabIndex = 7;
            // 
            // TxtVelMedia
            // 
            this.TxtVelMedia.BackColor = System.Drawing.SystemColors.Info;
            this.TxtVelMedia.Location = new System.Drawing.Point(158, 69);
            this.TxtVelMedia.Name = "TxtVelMedia";
            this.TxtVelMedia.Size = new System.Drawing.Size(100, 20);
            this.TxtVelMedia.TabIndex = 8;
            // 
            // TxtVelExcedida
            // 
            this.TxtVelExcedida.BackColor = System.Drawing.SystemColors.Info;
            this.TxtVelExcedida.Location = new System.Drawing.Point(138, 250);
            this.TxtVelExcedida.Name = "TxtVelExcedida";
            this.TxtVelExcedida.Size = new System.Drawing.Size(100, 20);
            this.TxtVelExcedida.TabIndex = 9;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(539, 286);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 10;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(379, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 251);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(422, 286);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // Visualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 318);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.TxtVelExcedida);
            this.Controls.Add(this.TxtVelMedia);
            this.Controls.Add(this.TxtVelPermitida);
            this.Controls.Add(this.LblMsg2);
            this.Controls.Add(this.LblVelExcedida);
            this.Controls.Add(this.LblMsg1);
            this.Controls.Add(this.LblKm2);
            this.Controls.Add(this.LblKm1);
            this.Controls.Add(this.LblVelMedia);
            this.Controls.Add(this.LblVelPermitida);
            this.Name = "Visualizacao";
            this.Text = "Visualização";
            this.Load += new System.EventHandler(this.Visualizacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVelPermitida;
        private System.Windows.Forms.Label LblVelMedia;
        private System.Windows.Forms.Label LblKm1;
        private System.Windows.Forms.Label LblKm2;
        private System.Windows.Forms.Label LblMsg1;
        private System.Windows.Forms.Label LblVelExcedida;
        private System.Windows.Forms.Label LblMsg2;
        private System.Windows.Forms.TextBox TxtVelPermitida;
        private System.Windows.Forms.TextBox TxtVelMedia;
        private System.Windows.Forms.TextBox TxtVelExcedida;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnVoltar;
    }
}