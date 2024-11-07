using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.D.Wrong
{
    public class UserManager
    {
        private MySqlUserRepository _mySqlRepository;
        private PostgreSqlUserRepository _postgreSqlRepository;

        public UserManager()
        {
            // A classe UserManager decide qual banco usar e cria as instâncias
            _mySqlRepository = new MySqlUserRepository();
            _postgreSqlRepository = new PostgreSqlUserRepository();
        }

        public void RegisterUserInMySql(string username)
        {
            _mySqlRepository.SaveUser(username);
        }

        public void RegisterUserInPostgreSql(string username)
        {
            _postgreSqlRepository.SaveUser(username);
        }
    }
}