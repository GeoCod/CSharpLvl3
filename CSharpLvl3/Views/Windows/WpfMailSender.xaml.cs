using System.Windows;
using System.Windows.Input;
//using MailSender.lib.Data;
using MailSender.lib.Entities;
using MailSender.lib.Service;

namespace CSharpLvl3
{
    public partial class WpfMailSender
    {
        public WpfMailSender()
        {
            InitializeComponent();

            // Привязка данных через класс внутри проекта
            //SendersList.ItemsSource = VariablesClass.Senders;
            //SendersList.DisplayMemberPath = "Key";
            //SendersList.SelectedValuePath = "Value";

            //Привязка данных через ссылку на проект
            //SendersList.ItemsSource = TestData.Senders;
            //ServersList.ItemsSource = TestData.Servers;

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OnSendButtonClick(object Sender, RoutedEventArgs e)
        {
            var recipient = RecipientsList.SelectedItem as Recipient;
            var sender = SendersList.SelectedItem as Sender;
            var server = ServersList.SelectedItem as Server;

            if (recipient is null || sender is null || server is null) return;

            var mail_sender = new MailSender.lib.Services.MailSender(server.Adress, server.Port, server.UseSSL, server.Login, server.Password.Decode(3));

            mail_sender.Send(MailHeader.Text, MailBody.Text, sender.Adress, recipient.Adress);
        }

        private void OnSenderEditClick(object Sender, RoutedEventArgs e)
        {
            var sender = SendersList.SelectedItem as Sender;
            if (sender is null) return;

            var dialog = new SenderEditor(sender);

            if (dialog.ShowDialog() != true) return;
            //внести изменения в sender
        }
    }
}
