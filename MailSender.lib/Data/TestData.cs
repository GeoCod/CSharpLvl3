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
            new Server {Id = 0, Name = "Яндекс", Adress = "smtp.yandex.ru", Port = 587, Login = "UserLogin", Password = "UserPass".Encode(3)},
            new Server {Id = 1, Name = "Mail.ru", Adress = "smtp.mail.ru", Port = 465, Login = "UserLogin", Password = "UserPass".Encode(3)},
            new Server {Id = 2, Name = "Google", Adress = "smtp.gmail.com", Port = 465, Login = "UserLogin", Password = "UserPass".Encode(3)},
            new Server {Id = 3, Name = "Рамблер", Adress = "smtp.rambler.ru ", Port = 465, Login = "UserLogin", Password = "UserPass".Encode(3)},
        };

        /// <summary>Список отправителей</summary>
        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender {Id = 0, Name = "Иванов", Adress = "ivanov@server.ru" },
            new Sender {Id = 1, Name = "Петров", Adress = "petrov@server.ru" },
            new Sender {Id = 2, Name = "Сидоров", Adress = "sidorov@server.ru" },
        };

        /// <summary>Список получателей</summary>
        public static List<Recipient> Recipients { get; } = new List<Recipient>
        {
            new Recipient {Id = 0, Name = "Попов", Adress = "popov@server.ru" },
            new Recipient {Id = 1, Name = "Федотов", Adress = "fedotov@server.ru" },
            new Recipient {Id = 2, Name = "Капустин", Adress = "kapustin@server.ru" },
        };
    }
}
