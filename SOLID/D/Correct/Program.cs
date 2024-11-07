using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.D.Correct
{
    public class Program
    {
        public static void Main()
        {
            // Para usar o MySQL
            IUserRepository mySqlRepository = new MySqlUserRepository();
            UserManager userManagerMySql = new UserManager(mySqlRepository);
            userManagerMySql.RegisterUser("Victor");

            // Para usar o PostgreSQL
            IUserRepository postgreSqlRepository = new PostgreSqlUserRepository();
            UserManager userManagerPostgreSql = new UserManager(postgreSqlRepository);
            userManagerPostgreSql.RegisterUser("Gustavo");
        }
    }
}