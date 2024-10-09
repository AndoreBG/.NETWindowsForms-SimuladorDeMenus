using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static simuladorDeMenus.Form1;

namespace simuladorDeMenus
{
    public partial class Iniciou : Form
    {
        private string nome = variavelGlobal.nome;

        public Iniciou()
        {
            InitializeComponent();

            lblTitulo.Text += nome;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show(
                "Você realmente deseja voltar ao Menu Inicial?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if(confirmacao == DialogResult.Yes)
            {
                Form1 inicio = new Form1();
                inicio.Show();

                this.Close();
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            SoundPlayer sus = new SoundPlayer
            {
                Stream = Properties.Resources.sus
            };
            sus.Play();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();

            this.Hide();
        }
    }
}
