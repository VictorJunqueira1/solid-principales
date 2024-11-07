using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.D.Correct
{
    public interface IUserRepository
    {
        void SaveUser(string username);
    }
}