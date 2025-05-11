using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using BackEnd;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //btnCriarConta.Click += btnCriarConta_Click;
            btnLogin.Click += btnLogin_Click;
            checkBoxMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;

            // Deixa a senha oculta ao iniciar
            textBoxSenha.UseSystemPasswordChar = true;
        }

        //private void btnCriarConta_Click(object sender, EventArgs e)
        //{
        //    FormCadastro cadastroForm = new FormCadastro();
        //    cadastroForm.ShowDialog();
        //    this.Hide();
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;

            //try
            //{
            //    var validador = new ValidationFormLogin();
            //    bool loginValido = validador.VerificarUsuario(email, senha);

            //    if (loginValido)
            //    {
            //        MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // abrir tela principal
            //        CadastrarChamado telaChamado = new CadastrarChamado();
            //        telaChamado.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuário ou senha inválidos. Verifique os dados ou crie uma conta.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Não foi possível efetuar o login. Tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                var validador = new ValidationFormLogin();
                bool loginValido = validador.VerificarUsuario(email, senha);

                if (loginValido)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // abrir tela principal
                    TelaInicial telaInicial = new TelaInicial();
                    telaInicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos. Verifique os dados ou crie uma conta.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível efetuar o login. Tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Gerar hash da senha
            string senhaHash = GerarHashSHA256(senha);
            //MessageBox.Show($"Senha criptografada:\n{senhaHash}", "Hash gerado");

            // Exemplo de simulação de verificação
            string hashSalvoNoBanco = "simulacaoDoHashDoBanco==";

            if (senhaHash == hashSalvoNoBanco)
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso");
            }
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = !checkBoxMostrarSenha.Checked;
        }

        private string GerarHashSHA256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
