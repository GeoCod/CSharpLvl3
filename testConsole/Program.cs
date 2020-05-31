using System.Net.Mail;


namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mm = new MailMessage("оправитель@yandex.ru", "получатель@yandex.ru");
            mm.Subject = "Заголовок письма";
            mm.Body = "Содержимое письма";

            mm.IsBodyHtml = false; //не используем html в теле письма
        }
    }
}
