using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXA_DE_EMOÇÕES
{
    public partial class Janela : Form
    {
        public Janela()
        {
            InitializeComponent();
        }

        private void Btn_enter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja Bem Vindo!",
                "aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
Environment.Exit(0 );
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
           
        }

        private void Janela_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click_1(object sender, EventArgs e)
        {
            Entre Product = new Entre();
            Product.Show();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            FmlLogin Product = new FmlLogin();
           Product.Show();
        }
    }
}
