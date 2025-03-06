using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    class Reserva
    {
        public static void ReservarHorario(int clienteId, int servicoId, DateTime dataHora)
        {
            using (SqlConnection conexao = BarbeariaContext.ObterConexao())
            {
                string query = "INSERT INTO Reservas (ClienteId, ServicoId, DataHora) VALUES (@ClienteId, @ServicoId, @DataHora)";
                
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@ClienteId", clienteId);
                    comando.Parameters.AddWithValue("@ServicoId", servicoId);
                    comando.Parameters.AddWithValue("@DataHora", dataHora);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Reserva cadastrada com sucesso!");
                }
            }
        }
    }
}
