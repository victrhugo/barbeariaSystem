using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    class Servicos
    {
        public static void CadastrarServico(string nome, decimal preco, int duracao)
        {
            using (SqlConnection conexao = BarbeariaContext.ObterConexao())
            {
                string query = "INSERT INTO Servicos (Nome, Preco, Duracao) VALUES (@Nome, @Preco, @Duracao)";
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Preco", preco);
                    comando.Parameters.AddWithValue("@Duracao", duracao);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Serviço cadastrado com sucesso!");
                }
            }
        }
    }
}
