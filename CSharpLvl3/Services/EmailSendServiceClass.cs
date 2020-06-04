using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace CSharpLvl3.Services
{
    public class EmailSendServiceClass
    {
        public EmailSendServiceClass()
        {
            //List<string> listStrMails = new List<string> { "testEmail@gmail.com", "email@yandex.ru" };
            //string strPassword = passwordBox.Password;
            //foreach (string mail in listStrMails)
            //{
            //    using (MailMessage mm = new MailMessage("sender@yandex.ru", mail))
            //    {
            //        mm.Subject = "Привет из C#";
            //        mm.Body = "Hello, world!";
            //        mm.IsBodyHtml = false;

            //        using (SmtpClient sc = new SmtpClient("smtp.yandex.ru", 25))
            //        {
            //            sc.EnableSsl = true;
            //            sc.Credentials = new NetworkCredential("sender@yandex.ru", strPassword);
            //            try
            //            {
            //                sc.Send(mm);
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Невозможно отправить письмо " + ex.ToString());
            //            }
            //        }
            //    }
            //}
            //MessageBox.Show("Работа завершена.");

        }
    }
}
