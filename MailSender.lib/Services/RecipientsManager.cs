using System;
using System.Collections.Generic;
using System.Text;
using MailSender.lib.Entities;

namespace MailSender.lib.Services
{
    /// <summary>Осуществление работы с получателями</summary>
    public class RecipientsManager
    {
        // В последнующем надо создать хранлилища для фалов, БД и т.п. и передавать их классы в менеджер

        private RecipientStoreInMemory _Store;

        public RecipientsManager(RecipientStoreInMemory Store) { _Store = Store; }

        /// <summary>Вывод всех получателей</summary>
        public IEnumerable<Recipient> GetAll()
        {
            return _Store.Get();
        }

        /// <summary>Добавление получателя</summary>
        public void Add(Recipient NewRecipient)
        {

        }

        public void Edit(Recipient Recipient)
        {
            _Store.Edit(Recipient.Id, Recipient);
        }

        public void SaveChanges()
        {
            _Store.SaveChanges();
        }

        // Delete(Recipient)...
    }
}
