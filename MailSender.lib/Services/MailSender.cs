using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace MailSender.lib.Services
{
    public class MailSender
    {
        private readonly string _ServerAdress;
        private readonly int _Port;
        private bool _UseSSL;
        private string _Login;
        private string _Password;

        public MailSender(string ServerAdress, int Port, bool UseSSL, string Login, string Password)
        {
            _ServerAdress = ServerAdress;
            _Port = Port;
            _UseSSL = UseSSL;
            _Login = Login;
            _Password = Password;
        }

        public void Send(string Subject, string Body, string From, string To)
        {
            using (var message = new MailMessage(From, To))
            {
                message.Subject = Subject;
                message.Body = Body;

                var login = new NetworkCredential(_Login, _Password);
                using (var client = new SmtpClient(_ServerAdress, _Port) { EnableSsl = _UseSSL, Credentials = login })
                    client.Send(message);
            }
        }
    }


    public class DebugMailSender
    {
        private readonly string _ServerAdress;
        private readonly int _Port;
        private bool _UseSSL;
        private string _Login;
        private string _Password;

        public DebugMailSender(string ServerAdress, int Port, bool UseSSL, string Login, string Password)
        {
            _ServerAdress = ServerAdress;
            _Port = Port;
            _UseSSL = UseSSL;
            _Login = Login;
            _Password = Password;
        }

        public void Send(string Subject, string Body, string From, string To)
        {
            Debug.WriteLine("Отправка почты от {0} к {1} через {2}:{3}[{4}]\r\n{5}:{6}",
                From, To, _Port, _UseSSL ? "SSL" : "noSSL",
                Subject, Body);
        }
    }
}
