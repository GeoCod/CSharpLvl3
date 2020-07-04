using MailSender.lib.Data;
using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Services
{
    public class RecipientStoreInMemory
    {
        public IEnumerable<Recipient> Get() => TestData.Recipients;
    }
}
