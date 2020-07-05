using MailSender.lib.Data;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Services
{
    public class RecipientStoreInMemory : IRecipientStore
    {
        public IEnumerable<Recipient> Get() => TestData.Recipients;

        public void Edit(int id, Recipient recipient)
        {
            // т.к. это хранилище данных в памяти, то здесь ничего не делаем
        }

        public void SaveChanges()
        {
            // т.к. это хранилище данных в памяти, то здесь ничего не делаем
        }
    }
}
