using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientStore
    {
        IEnumerable<Recipient> Get();

        void Edit(int id, Recipient Recipient);

        void SaveChanges();
    }
}
