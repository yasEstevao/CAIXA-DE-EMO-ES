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
    public partial class FmlLogin : Form
    {
        public FmlLogin()
        {
            InitializeComponent();
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            NomeDeUsuario Product = new NomeDeUsuario();
            Product.Show();
        }
    }
}
