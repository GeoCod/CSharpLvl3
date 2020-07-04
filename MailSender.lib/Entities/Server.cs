namespace MailSender.lib.Entities
{
    /// <summary>Почтовый сервер</summary>
    public class Server
    {
        /// <summary>ID сервера</summary>
        public int Id { get; set; }

        /// <summary>Название сервера</summary>
        public string Name { get; set; }

        /// <summary>Адрес сервера</summary>
        public string Adress { get; set; }

        /// <summary>Порт сервера</summary>
        public int Port { get; set; }

        /// <summary>Использование SSL соединения</summary>
        public bool UseSSL { get; set; } = true;

        /// <summary>Логин отправителя</summary>
        public string Login { get; set; }

        /// <summary>Пароль отправителя</summary>
        public string Password { get; set; }
    }
}
