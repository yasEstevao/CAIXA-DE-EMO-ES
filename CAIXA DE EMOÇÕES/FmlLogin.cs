using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CAIXA_DE_EMOÇÕES
{
    public partial class FmlLogin : Form
    {
        public FmlLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ncomp = TxtName.Text;
            string Email = txtEmail1.Text;
            string telefone = MtbTelefone.Text;
            string endereco = txbAdress.Text;
            string CPF = MtbCPF.Text;

            string conexaoString = "Server=SQLexpress;Database=DDCLIENTES;User Id=aluno; Password=aluno;";
            string query = "INSERT INTO USURIO VALUES (@Ncomp, @Email,@telefone,@endereco, @CPF)";

            using (SqlConnection conexao = new SqlConnection(conexaoString))
            {
                conexao.Open();

                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", Ncomp);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@ndereco", endereco);
                    comando.Parameters.AddWithValue("@CPF", CPF);

                    comando.ExecuteNonQuery();

                    FmlNameUser Product = new FmlNameUser();
                    Product.Show();
                }
            }
        }
    }
}
