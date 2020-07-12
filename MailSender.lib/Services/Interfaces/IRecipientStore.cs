using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Services.Interfaces
{
    public interface IRecipientStore
    {
        IEnumerable<Recipient> GetAll();

        Recipient GetById(int id);

        int Create(Recipient Recipient);

        void Edit(int id, Recipient Recipient);

        Recipient Remove(int id);

        void SaveChanges();
    }
}
