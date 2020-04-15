using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semaforo.Views;

namespace Semaforo
{   
    public partial class Velocidade : Form
    {

        public Velocidade()
        {
            InitializeComponent();
            TxtBoxVelMed.Text = "0";
            TxtBoxDistancia.Text = "0";
            TxtBoxTempo.Text = "0";
        }


        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtBoxDistancia.Text = "0";
            TxtBoxTempo.Text = "0";
            TxtBoxVelMax.Text = "";
            TxtBoxVelMed.Text = "0";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            float distancia = 0, tempo = 0, velmedia = 0;

            distancia = float.Parse(TxtBoxDistancia.Text);
            tempo = float.Parse(TxtBoxTempo.Text);
            if (distancia == 0 || tempo == 0)
            {
                MessageBox.Show("Digite os dados antes para calcular!", "DADOS FALTANDO", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                velmedia = distancia / tempo;
            }
            
            TxtBoxVelMed.Text = velmedia.ToString();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            
            float velMedia = float.Parse(TxtBoxVelMed.Text);

            if (velMedia == 0)
            {
                MessageBox.Show("Digite a velocidade antes para visualizar!", "DADOS FALTANDO", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                this.Hide();
                Visualizacao formDestino = new Visualizacao(TxtBoxVelMax.Text, TxtBoxVelMed.Text);
                formDestino.ShowDialog();
            }
            
        }
    }
}
