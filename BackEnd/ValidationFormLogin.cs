using System;
using System.Text.RegularExpressions;
using Npgsql;

namespace BackEnd
{
    public class ValidationFormLogin
    {
        private readonly ConectionBD _conexaoBD;

        public ValidationFormLogin()
        {
            _conexaoBD = new ConectionBD();
        }

        public void ValidarUsuario(string email, string senha)
        {
            // 1. Validação dos campos
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("O campo email é obrigatório.");

            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("O campo senha é obrigatório.");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Formato de email inválido.");

            if (senha.Length < 6)
                throw new ArgumentException("A senha deve ter no mínimo 6 caracteres.");

            // 2. Inserção no banco de dados usando a classe ConectionBD
            try
            {
                using var conn = _conexaoBD.GetConnection();
                using var cmd = new NpgsqlCommand("INSERT INTO usuarios (email, senha) VALUES (@e, @s)", conn);
                cmd.Parameters.AddWithValue("e", email);
                cmd.Parameters.AddWithValue("s", senha); // Em produção, use hash!

                cmd.ExecuteNonQuery();
                Console.WriteLine("Usuário inserido com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir no banco de dados: {ex.Message}");
                throw;
            }
        }

        // Validar usuário:
        public bool VerificarUsuario(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Email e senha são obrigatórios!");

            try
            {
                using var conn = _conexaoBD.GetConnection();
                using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM usuarios WHERE email = @e AND senha = @s", conn);
                cmd.Parameters.AddWithValue("e", email);
                cmd.Parameters.AddWithValue("s", senha); // Em produção, compare hashes!

                var result = (long)cmd.ExecuteScalar();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar o banco de dados: {ex.Message}");
                throw;
            }
        }
    }
}