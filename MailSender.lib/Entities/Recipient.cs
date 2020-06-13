using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    public class Recipient
    {
        /// <summary>Имя отправителя</summary>
        public string Name { get; set; }

        /// <summary>e-mail отправителя</summary>
        public string Adress { get; set; }
    }
}
