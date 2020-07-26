using MailSender.lib.Entities.Base;
using System.Collections;
using System.Collections.Generic;

namespace MailSender.lib.Entities
{
    public class Mail : BaseEntity
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        //public ICollection Attachments { get; set; } = new List<MailAttachment>();
    }
}
