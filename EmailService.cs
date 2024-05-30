using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab
{
    public class EmailService
    {
        private static readonly Lazy<EmailService> lazy = new Lazy<EmailService>(() => new EmailService());

        private EmailService()
        {
            Console.WriteLine("Экземпляр EmailService создан.");
        }
        public static EmailService GetInstance()
        {
            return lazy.Value;
        }
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Отправка письмо на {to} по теме \"{subject}\" и содержанием \"{body}\"");
        }
    }
}
