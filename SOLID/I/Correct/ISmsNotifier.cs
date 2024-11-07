using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.I.Correct
{
    public interface ISmsNotifier
    {
        void SendSms(string message);
    }

    public class EmailNotifier : IEmailNotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Enviando email: " + message);
        }
    }
}

// Correção: As interfaces foram segregadas. 
// EmailNotifier implementa apenas IEmailNotifier, e não é forçado a implementar métodos desnecessários.