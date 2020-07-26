using MailSender.lib.Entities.Base;
using System;

namespace MailSender.lib.Entities
{
    /// <summary>Задача планировщика</summary>
    public class SchedulerTask : BaseEntity
    {
        /// <summary>Время выполнения задания</summary>
        public DateTime Time { get; set; }

        /// <summary>Отправитель почты в задании</summary>
        public Sender Sender { get; set; }

        /// <summary>Список получателей почты</summary>
        public MailingList Recipients { get; set; }

        /// <summary>Сервер, через который надо отправить почту</summary>
        public Server Server { get; set; }

        /// <summary>Письмо, которое требуется разослать</summary>
        public Mail Mail { get; set; }
    }
}
