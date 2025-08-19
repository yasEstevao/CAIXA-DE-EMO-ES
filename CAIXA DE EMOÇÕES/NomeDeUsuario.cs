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
    public partial class NomeDeUsuario : Form
    {
        // 🔹 Aqui sim: string de conexão é atributo da classe
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=CaixaEmocoesDB;Integrated Security=True";

        public NomeDeUsuario()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = TxtUsuario.Text.Trim();
                string senha = TxtSenha.Text.Trim();

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Preencha usuário e senha.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verifica se já existe usuário
                    string checkUser = "SELECT COUNT(*) FROM Usuarios WHERE NomeUsuario = @usuario";
                    using (SqlCommand cmd = new SqlCommand(checkUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Esse usuário já existe!", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insere novo usuário
                    string insert = "INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@usuario, @senha)";
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.ExecuteNonQuery();
                    }
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
    }
}
