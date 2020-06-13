using System.Windows.Input;
//using CSharpLvl3.Models;
using MailSender.lib.Data;

namespace CSharpLvl3
{
    public partial class WpfMailSender
    {
        public WpfMailSender()
        {
            InitializeComponent();

            // Привязка данных через класс внутри проекта
            //cbSenderSelect.ItemsSource = VariablesClass.Senders;
            //cbSenderSelect.DisplayMemberPath = "Key";
            //cbSenderSelect.SelectedValuePath = "Value";

            //Привязка данных через ссылку на проект
            //cbSenderSelect.ItemsSource = TestData.Senders;
            //cbSmtpSelect.ItemsSource = TestData.Servers;

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
