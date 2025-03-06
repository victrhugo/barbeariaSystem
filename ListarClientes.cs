using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    class ListarCliente
    {

        public static void ListarClientes()
        {
            using (SqlConnection conexao = BarbeariaContext.ObterConexao())
            {
                string query = "SELECT Id, Nome, Telefone FROM Clientes";

                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        Console.WriteLine("\n=== Lista de Clientes ===");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Id"]}, Nome: {reader["Nome"]}, Telefone: {reader["Telefone"]}");
                        }
                    }
                }
            }
        }
    }
}
