using System.Windows;

namespace testWPF
{
    /// <summary>Логика взаимодействия для SendEndWindow.xaml</summary>
    public partial class SendEndWindow : Window
    {
        public SendEndWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
