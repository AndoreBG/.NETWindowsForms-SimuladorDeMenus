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
using System.Reflection;
using AxWMPLib;
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
            else if (confirmacao == DialogResult.No)
            {
                MessageBox.Show(
                    "Retorno cancelado!",
                    "Confirmação",
                    MessageBoxButtons.OK
                );
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            SoundPlayer sus = new SoundPlayer();
            sus.Stream = Properties.Resources.sus;
            sus.Play();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            string caminhoTemporario = Path.Combine(Path.GetTempPath(), "cat-breakdancing.mp4");

            if (File.Exists(caminhoTemporario))
            {
                File.Delete(caminhoTemporario);
            }

            File.WriteAllBytes(caminhoTemporario, Properties.Resources.cat_breakdancing); 

            wmpVideo.URL = caminhoTemporario;

            wmpVideo.Ctlcontrols.play();
        }
    }
}
