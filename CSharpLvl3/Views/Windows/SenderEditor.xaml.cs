using MailSender.lib.Entities;
using System.Windows;

namespace CSharpLvl3
{
    /// <summary>Логика взаимодействия для SenderEditor.xaml</summary>
    public partial class SenderEditor
    {
        public string NameValue { get => NameEditor.Text; set => NameEditor.Text = value; }
        public string AdressValue { get => NameEditor.Text; set => AdressEditor.Text = value; }
        public SenderEditor(Sender Sender)
        {
            InitializeComponent();
            NameValue = Sender.Name;
            AdressValue = Sender.Adress;
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
