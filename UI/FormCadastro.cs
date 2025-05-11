using System;
using System.Linq;
using System.Windows.Forms;
using BackEnd; 

namespace UI
{
    public partial class FormCadastro : Form
    {
        private readonly ValidationFormCadastro _validador;

        public FormCadastro()
        {
            InitializeComponent();
            btnEfetuarCadastro.Click += btnEfetuarCadastro_Click;

            btnVoltarParaTelaDeLogin.Click += btnVoltarParaTelaDeLogin_Click;

            _validador = new ValidationFormCadastro();
        }

        private void btnEfetuarCadastro_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBoxNomeCompleto.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;
            string confirmarSenha = textBoxConfirmarSenha.Text;
            DateTime dataNascimento = monthCalendarDataNascimento.SelectionStart;
            
            string mensagemErro;
            bool sucesso = _validador.CadastrarUsuario(nomeCompleto, email, senha, confirmarSenha, dataNascimento, out mensagemErro);

            if (sucesso)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaInicial telaCadastrarChamado = new TelaInicial();
                telaCadastrarChamado.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show(mensagemErro, "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Só limpa os campos se o erro for de usuário já existente
                if (!mensagemErro.Contains("Erro no cadastro"))
                {
                    textBoxNomeCompleto.Clear();
                    textBoxEmail.Clear();
                    textBoxSenha.Clear();
                    textBoxConfirmarSenha.Clear();
                    monthCalendarDataNascimento.SetDate(DateTime.Today);
                }
            }
        }

        private void btnVoltarParaTelaDeLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}