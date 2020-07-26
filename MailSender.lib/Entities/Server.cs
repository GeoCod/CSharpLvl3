using MailSender.lib.Entities.Base;

namespace MailSender.lib.Entities
{
    /// <summary>Почтовый сервер</summary>
    public class Server : NamedEntity
    {
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
