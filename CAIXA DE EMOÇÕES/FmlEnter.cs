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
    public partial class FmlEnter : Form
    {
        public FmlEnter()
        {
            InitializeComponent();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNext2_Click(object sender, EventArgs e)
        {
            string EMAIL = BtnNext2.Text;
            string NAME = TxtNameUser.Text;
            string PASSWORD = TxtPassword.Text;
            MessageBox.Show("EMAIL:" + EMAIL + "NAME: " + NAME + "SEMHA:" + PASSWORD);
        }
    }
}
