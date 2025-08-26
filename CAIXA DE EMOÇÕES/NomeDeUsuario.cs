using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAIXA_DE_EMOÇÕES
{
    public partial class NomeDeUsuario : Form
    {
        // 🔹 String de conexão como atributo da classe
        private string connectionString = "Server=sqlexpress;Database=CJ3027902PR2;user id=aluno; password=aluno;";

        public NomeDeUsuario()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text.Trim();
            string senha = TxtSenha.Text.Trim();

            // Validação de campos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha usuário e senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 🔹 Verifica se usuário já existe
                    if (UsuarioExiste(conn, usuario))
                    {
                        MessageBox.Show("Esse usuário já existe!", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 🔹 Insere novo usuário
                    InserirUsuario(conn, usuario, senha);
                }

                MessageBox.Show("Usuário criado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar usuário:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Método para verificar se usuário já existe
        private bool UsuarioExiste(SqlConnection conn, string usuario)
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NomeUsuario = @usuario";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // 🔹 Método para inserir novo usuário
        private void InserirUsuario(SqlConnection conn, string usuario, string senha)
        {
            string query = "INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@Usuario, @Senha)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
