using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.D.Correct
{
    public class MySqlUserRepository : IUserRepository
    {
        public void SaveUser(string username)
        {
            Console.WriteLine($"Salvando usuário '{username}' no banco MySQL.");
            // Código de conexão e inserção no MySQL
        }
    }
}