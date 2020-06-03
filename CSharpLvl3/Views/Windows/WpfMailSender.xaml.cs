using System;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Windows;
using System.Windows.Input;

namespace CSharpLvl3
{
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void GroupBox_ColorChanged(object sender, RoutedPropertyChangedEventArgs<System.Windows.Media.Color> e)
        {

        }
    }
}
