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

namespace CAIXA_DE_EMOÇÕES
{
    public partial class Entre : Form
    {
        public Entre()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            string email = Email.Text;
            string Nome = NomeCompleto.Text;
            string senha = Senha.Text;

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ⚡ Ajuste a connection string conforme seu servidor
            string conexao = @"Data Source=.\SQLEXPRESS; Initial Catalog=CJ3027902PR2;User ID=aluno;Password=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(conexao))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM DADOSusuario WHERE Email = @Email AND Nome = @Nome AND Senha = @Senha";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Senha", senha); // senha pura, igual está salva no banco

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            NovaAba product = new NovaAba();
                            product.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

