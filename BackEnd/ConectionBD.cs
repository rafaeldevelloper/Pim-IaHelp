using Npgsql;
using System;

namespace BackEnd
{
    public class ConectionBD
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=softwareengenieer;Database=bd-iahelp";

        public NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar com o banco de dados: {ex.Message}");
                throw;
            }
        }

        public void ExecutarComando(string query, Dictionary<string, object> parametros)
        {
            using (var connection = GetConnection())
            using (var command = new NpgsqlCommand(query, connection))
            {
                foreach (var param in parametros)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                command.ExecuteNonQuery();
            }
        }

        public object ExecutarEscalar(string query, Dictionary<string, object> parametros)
        {
            using (var connection = GetConnection())
            using (var command = new NpgsqlCommand(query, connection))
            {
                foreach (var param in parametros)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                return command.ExecuteScalar();
            }
        }
    }
}