
namespace MailSender.lib.Entities
{
    /// <summary>Получатель письма</summary>
    public class Recipient
    {
        /// <summary>ID получателя</summary>
        public int Id { get; set; }

        /// <summary>Имя получателя</summary>
        public string Name { get; set; }

        /// <summary>e-mail получателя</summary>
        public string Adress { get; set; }
    }
}
