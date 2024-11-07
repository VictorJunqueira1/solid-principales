using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.D.Correct
{
    public class PostgreSqlUserRepository : IUserRepository
    {
        public void SaveUser(string username)
        {
            Console.WriteLine($"Salvando usuário '{username}' no banco PostgreSQL.");
            // Código de conexão e inserção no PostgreSQL
        }
    }
}