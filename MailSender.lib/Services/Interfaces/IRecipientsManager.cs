using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientsManager
    {
        IEnumerable<Recipient> GetAll();

        void Add(Recipient NewRecipient);

        void Edit(Recipient Recipient);

        void SaveChanges();
    }
}
