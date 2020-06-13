using MailSender.lib.Entities;
using MailSender.lib.Service;
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
            new Server {Name = "Яндекс", Adress = "smtp.yandex.ru", Port = 587, Login = "UserLogin", Password = "UserPass".Encode(3)},
            new Server {Name = "Mail.ru", Adress = "smtp.mail.ru", Port = 465, Login = "UserLogin", Password = "UserPass".Encode(3)},
            new Server {Name = "Google", Adress = "smtp.gmail.com", Port = 465, Login = "UserLogin", Password = "UserPass".Encode(3)},
            new Server {Name = "Рамблер", Adress = "smtp.rambler.ru ", Port = 465, Login = "UserLogin", Password = "UserPass".Encode(3)},
        };

        /// <summary>Список отправителей</summary>
        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender { Name = "Иванов", Adress = "ivanov@server.ru" },
            new Sender { Name = "Петров", Adress = "petrov@server.ru" },
            new Sender { Name = "Сидоров", Adress = "sidorov@server.ru" },
        };

        /// <summary>Список получателей</summary>
        public static List<Recipient> Recipients { get; } = new List<Recipient>
        {
            new Recipient { Name = "Попов", Adress = "popov@server.ru" },
            new Recipient { Name = "Федотов", Adress = "fedotov@server.ru" },
            new Recipient { Name = "Капустин", Adress = "kapustin@server.ru" },
        };
    }
}
