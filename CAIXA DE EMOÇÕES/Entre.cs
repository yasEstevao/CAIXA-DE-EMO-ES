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
            string email = Email.Text;
            string Nome = NomeCompleto.Text;
            string senha = Senha.Text;

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conexão com o banco de dados
            string conexao = "Server=sqlexpress;Database=CJ3027902PR2;user id=aluno; password=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(conexao))
                {
                    con.Open();

                    // Consulta de verificação do login
                    string query = "SELECT COUNT(*) FROM DADOSusuario WHERE Email = @Email AND Nome = @NomeUsuario AND Senha = @Senha";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Você pode abrir outro formulário aqui, por exemplo:
                        Entre telaPrincipal = new Entre();
                        telaPrincipal.Show();
                        this.Hide(); // esconde o form de login
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
