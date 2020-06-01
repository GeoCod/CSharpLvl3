using System;
using System.Windows;
using System.Net;
using System.Net.Mail;
using System.Security;

namespace testWPF
{
    public partial class WpfTestMailSender : Window
    {
        public WpfTestMailSender()
        {
            InitializeComponent();
        }

        private void OnSendButtonClick(object sender, RoutedEventArgs e)
        {
            var message_subject = $"Тестовое сообщение от {DateTime.Now}";
            var message_body = $"Тело сообщения - {DateTime.Now}";

            const string from = "test5000999@yandex.ru";
            const string to = "test5000888@gmail.com";

            try
            {
                using (var message = new MailMessage(from, to))
                {
                    message.Subject = message_subject;
                    message.Body = message_body;

                    const string server_address = "smtp.yandex.ru";
                    const int server_port = 25;
                    using (var client = new SmtpClient(server_address, server_port))
                    {
                        client.EnableSsl = true;

                        string user_name = UserNameEdit.Text;
                        SecureString user_password = PasswordEdit.SecurePassword;

                        client.Credentials = new NetworkCredential(user_name, user_password);
                        client.Send(message);

                        MessageBox.Show("Почта отправлена!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
