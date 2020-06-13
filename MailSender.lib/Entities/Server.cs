namespace MailSender.lib.Entityes
{
    /// <summary>Почтовый сервер</summary>
    public class Server
    {
        /// <summary>Название сервера</summary>
        public string Name { get; set; }

        /// <summary>Адрес сервера</summary>
        public string Adress { get; set; }

        /// <summary>Порт сервера</summary>
        public int Port { get; set; }

        /// <summary>Использование SSL соединения</summary>
        public bool UseSSL { get; set; }

        /// <summary>Логин отправителя</summary>
        public string Login { get; set; }

        /// <summary>Пароль отправителя</summary>
        public string Password { get; set; }
    }
}
