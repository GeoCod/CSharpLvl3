using MailSender.lib.Data;
using MailSender.lib.Entities;
using MailSender.lib.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MailSender.lib.Services
{
    public class RecipientStoreInMemory : DataStoreInMemory<Recipient>, IRecipientStore
    {
        public RecipientStoreInMemory() : base(TestData.Recipients) { }

        public override void Edit(int id, Recipient recipient)
        {
            // притворяемся что мы работаем не с объектами в памяти, а с объектами в БД
            var db_recioient = GetById(id);
            if (db_recioient is null) return;

            db_recioient.Name = recipient.Name;
            db_recioient.Adress = recipient.Adress;
        }
    }
}
