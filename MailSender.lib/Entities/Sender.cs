
namespace MailSender.lib.Entities
{
    /// <summary>Отправитель письма</summary>
    public class Sender
    {
        /// <summary>ID отправителя</summary>
        public int Id { get; set; }

        /// <summary>Имя отправителя</summary>
        public string Name { get; set; }

        /// <summary>e-mail отправителя</summary>
        public string Adress { get; set; }
    }
}
