using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.I.Correct
{
    public interface IEmailNotifier
    {
        void SendEmail(string message);
    }
}