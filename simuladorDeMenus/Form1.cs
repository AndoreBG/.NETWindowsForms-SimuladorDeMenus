using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simuladorDeMenus
{
    public partial class Form1 : Form
    {
        public static class variavelGlobal
        {
            public static string nome;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            variavelGlobal.nome = txtNome.Text;

            Iniciou iniciou = new Iniciou();
            iniciou.Show();

            this.Hide();
        }
    }
}
