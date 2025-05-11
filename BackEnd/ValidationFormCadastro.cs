using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Npgsql;

namespace BackEnd
{
    public class ValidationFormCadastro
    {
        private readonly ConectionBD _conexaoBD;

        public ValidationFormCadastro()
        {
            _conexaoBD = new ConectionBD();
        }

        public bool CadastrarUsuario(string nomeCompleto, string email, string senha, string confirmarSenha, DateTime dataNascimento, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            // Validações:
            if (string.IsNullOrWhiteSpace(nomeCompleto))
            {
                mensagemErro = "O nome completo é obrigatório.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensagemErro = "O e-mail informado é inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(senha) || senha.Length < 6)
            {
                mensagemErro = "A senha deve conter pelo menos 6 caracteres.";
                return false;
            }

            if (senha != confirmarSenha)
            {
                mensagemErro = "As senhas não coincidem.";
                return false;
            }

            if (dataNascimento > DateTime.Now.AddYears(-12))
            {
                mensagemErro = "A idade mínima para cadastro é de 18 anos.";
                return false;
            }

            try
            {
                // Verificar se já existe algum usuário com nome, e-mail ou senha iguais
                string queryVerifica = @"
                SELECT COUNT(*) FROM usuarios 
                WHERE email = @Email OR nome_completo = @NomeCompleto OR senha = @Senha";

                var parametrosVerifica = new Dictionary<string, object>
                {
                    { "@Email", email },
                    { "@NomeCompleto", nomeCompleto },
                    { "@Senha", senha }
                };

                object resultado = _conexaoBD.ExecutarEscalar(queryVerifica, parametrosVerifica);
                int quantidade = Convert.ToInt32(resultado);

                if (quantidade > 0)
                {
                    mensagemErro = "Já existe um usuário com os mesmos dados informados (nome, e-mail ou senha).";
                    return false;
                }

                // Inserção no banco
                string query = "INSERT INTO usuarios (nome_completo, email, senha, data_nascimento) VALUES (@NomeCompleto, @Email, @Senha, @DataNascimento)";
                var parametros = new Dictionary<string, object>
                {
                    { "@NomeCompleto", nomeCompleto },
                    { "@Email", email },
                    { "@Senha", senha },
                    { "@DataNascimento", dataNascimento }
                };

                _conexaoBD.ExecutarComando(query, parametros);
                return true;
                }
                catch (Exception ex)
                {
                    mensagemErro = $"Erro ao cadastrar usuário: {ex.Message}";
                    return false;
                }

        }
    }
}