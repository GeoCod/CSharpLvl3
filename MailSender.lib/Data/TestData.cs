using MailSender.lib.Entities;
using MailSender.lib.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Data
{
    /// <summary>Тестовые данные</summary>
    public static class TestData
    {
        /// <summary>Список серверов</summary>
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server {Name = "Яндекс", Adress = "smtp.yandex.ru", Port = 587, Login = "UserLogin", Password = "UserPass"},
            new Server {Name = "Mail.ru", Adress = "smtp.mail.ru", Port = 465, Login = "UserLogin", Password = "UserPass"},
            new Server {Name = "Google", Adress = "smtp.gmail.com", Port = 465, Login = "UserLogin", Password = "UserPass"},
            new Server {Name = "Рамблер", Adress = "smtp.rambler.ru ", Port = 465, Login = "UserLogin", Password = "UserPass"},
        };

        /// <summary>Список отправителей</summary>
        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender { Name = "Иванов", Adress = "ivanov@server.ru" },
            new Sender { Name = "Петров", Adress = "petrov@server.ru" },
            new Sender { Name = "Сидоров", Adress = "sidorov@server.ru" },
        };
    }
}
