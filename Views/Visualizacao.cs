using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Semaforo.Views
{
    public partial class Visualizacao : Form
    {
        public Visualizacao(string valor1, string vm)
        {
            InitializeComponent();
            float acima = 0, permitida = 0, media = 0;
            string path = Directory.GetCurrentDirectory();
            TxtVelPermitida.Text = valor1;
            TxtVelMedia.Text = vm;

            permitida = float.Parse(valor1);
            media = float.Parse(vm);
           
            if (media > permitida)
            {
                timer1.Enabled = true;
                acima = (media - permitida);
                TxtVelExcedida.Text = acima.ToString();
                pictureBox1.Image = Image.FromFile("C:\\Users\\caahs\\Desktop\\Ciencia da Computação - USC\\C#\\Semaforo\\Imagens\\Sinal_vermelho.jpg");
                LblMsg1.Text = "Você está correndo risco com essa velocidade!!!";
                LblMsg2.Text = "RESPEITE OS LIMITES DE VELOCIDADE";
            }
            else
            {
                TxtVelExcedida.Text = "";
                LblMsg1.Text = "";
                pictureBox1.Image = Image.FromFile("C:\\Users\\caahs\\Desktop\\Ciencia da Computação - USC\\C#\\Semaforo\\Imagens\\Sinal_verde.jpg");
                LblMsg2.ForeColor = Color.Blue;
                LblMsg2.Text = "Você está dentro da velocidade";
            }
        }

        private void Visualizacao_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblMsg2.ForeColor = LblMsg2.ForeColor == Color.Red ? Color.Black : Color.Red;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
