using MailSender.lib.Entities;
using System.Windows;

namespace CSharpLvl3
{
    /// <summary>Логика взаимодействия для SenderEditor.xaml</summary>
    public partial class SenderEditor
    {
        public SenderEditor(Sender Sender)
        {
            InitializeComponent();
            DataContext = Sender;
        }

        private void OnOkButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
