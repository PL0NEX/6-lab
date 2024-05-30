using _6_lab;

class Program
{
    static void Main(string[] args)
    {
        EmailService emailService = EmailService.GetInstance();
        emailService.SendEmail("email@example.com", "Тест", "Текст");

        EmailService emailService2 = EmailService.GetInstance();
        emailService2.SendEmail("email2@example.com", "Тест2", "Текст2");
    }
}