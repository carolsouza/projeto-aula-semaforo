using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LblSenha_Click(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string senha;
            senha = TxtBoxSenha.Text;
            senha = senha.ToUpper();
            if (senha == "UNISAGRADO")
            {
                this.Close();
                DialogResult = DialogResult.OK;
                /*this.Hide();
                Velocidade formDestino = new Velocidade();
                formDestino.Show();*/
            }
            else
            {
                MessageBox.Show("Senha Inválida! Tente novamente!", "VALIDAÇÃO DE LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxSenha.Text = "";
                TxtBoxSenha.Focus(); //coloca o cursor dentro da box de txt senha

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
