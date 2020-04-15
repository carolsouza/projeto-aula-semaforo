namespace Semaforo.Views
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BtnVelMedia = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVelMedia
            // 
            this.BtnVelMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVelMedia.Image = ((System.Drawing.Image)(resources.GetObject("BtnVelMedia.Image")));
            this.BtnVelMedia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVelMedia.Location = new System.Drawing.Point(12, 12);
            this.BtnVelMedia.Name = "BtnVelMedia";
            this.BtnVelMedia.Size = new System.Drawing.Size(126, 104);
            this.BtnVelMedia.TabIndex = 3;
            this.BtnVelMedia.Text = "Calcular Velocidade Média";
            this.BtnVelMedia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVelMedia.UseVisualStyleBackColor = true;
            this.BtnVelMedia.Click += new System.EventHandler(this.BtnVelMedia_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.Location = new System.Drawing.Point(144, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(126, 104);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnVelMedia);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVelMedia;
        private System.Windows.Forms.Button BtnSair;
    }
}