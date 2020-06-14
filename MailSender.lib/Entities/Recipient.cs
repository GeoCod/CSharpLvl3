
namespace MailSender.lib.Entities
{
    /// <summary>Получатель письма</summary>
    public class Recipient
    {
        /// <summary>Имя отправителя</summary>
        public string Name { get; set; }

        /// <summary>e-mail отправителя</summary>
        public string Adress { get; set; }
    }
}
