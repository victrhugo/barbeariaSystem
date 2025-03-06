using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    public class BarbeariaContext
    {
        private static string connectionString = "Server=DESKTOP-6H5PBKR\\SQLVICTOR;Database=BarbeariaDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }

    }
}
