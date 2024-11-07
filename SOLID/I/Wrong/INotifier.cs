using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.I.Wrong
{
    public interface INotifier
    {
        void SendEmail(string message);
        void SendSms(string message);
    }
    public class EmailNotifier : INotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Enviando email: " + message);
        }
        public void SendSms(string message)
        {
            throw new NotImplementedException();
        }
    }
}

// Problema: EmailNotifier é forçado a implementar SendSms, que não faz sentido para esta classe.