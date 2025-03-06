using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    class Listar
    {
        public static void ListarReservas()
        {
            using (SqlConnection conexao = BarbeariaContext.ObterConexao())
            {
                string query = @"  
               SELECT r.Id, c.Nome AS Cliente, s.Nome AS Servico, r.DataHora  
               FROM Reservas r  
               JOIN Clientes c ON r.ClienteId = c.Id  
               JOIN Servicos s ON r.ServicoId = s.Id  
               ORDER BY r.DataHora";
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Cliente: {reader["Cliente"]}, Servico: {reader["Servico"]}, DataHora: {reader["DataHora"]}");
                        }
                    }
                }
            }
        }
    }
}
