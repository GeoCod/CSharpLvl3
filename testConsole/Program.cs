using System.Net;
using System.Net.Mail;


namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage msg = new MailMessage("оправитель@yandex.ru", "получатель@yandex.ru");
            msg.Subject = "Заголовок письма";
            msg.Body = "Содержимое письма";
            msg.IsBodyHtml = false; //не используем html в теле письма
            msg.Attachments.Add(new Attachment("c:\\file.txt"));

            SmtpClient client = new SmtpClient("smtp.yandex.ru", 25);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("UserName", "UserPassword");

            client.Send(msg);
        }
    }
}
