using CAIXA_DE_EMOÇÕES;
using System;
using System.Data.SqlClient;
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
            string Nome = NomeCompleto.Text;
            string email = Email.Text;
            string telefone = Telefone.Text;   // use o mesmo nome do seu TextBox!
            string endereco = this.Endereco.Text;   // idem
            string cpf = CPF.Text;
            string Senha = senha.Text;

            // 🔹 Validação básica
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Preencha todas as colunas!");
                return;
            }

            string conexao = "Server=sqlexpress;Database=CJ3027902PR2;user id=aluno; password=aluno;";

            try
            {
                using (SqlConnection con = new SqlConnection(conexao))
                {
                    con.Open();

                    // 🔹 Inserir os dados no banco
                    string query = "INSERT INTO DADOSusuario (Nome, Email, Telefone, Endereco, CPF, Senha) " +
                                   "VALUES (@Nome, @Email, @Telefone, @Endereco, @CPF, @Senha)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@Senha", Senha);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Cliente cadastrado com sucesso!");
                }
                Entre Product = new Entre();
                Product.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro ao salvar: " + ex.Message);
              
            }
        }

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            
        {

        }
    }
}
