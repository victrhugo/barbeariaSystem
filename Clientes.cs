using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    class Clientes
    {
        public static void CadastarCliente(string nome, string telefone)
        {
            using (SqlConnection conexao = BarbeariaContext.ObterConexao())
            {
                string query = "INSERT INTO Clientes (Nome, Telefone) VALUES (@Nome, @Telefone)";

                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Telefone", telefone);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                }
            }
        }
    }
}
