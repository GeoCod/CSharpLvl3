using MailSender.lib.Entities.Base;
using MailSender.lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MailSender.lib.Services
{
    public abstract class DataStoreInMemory<T> : IDataStore<T> where T : BaseEntity
    {
        /// <summary>Список объектов в памяти</summary>
        private readonly List<T> _Items;

        protected DataStoreInMemory(List<T> Items = null) => Items = _Items ?? new List<T>();

        public IEnumerable<T> GetAll() => _Items;

        public T GetById(int id) => _Items.FirstOrDefault(item => item.Id == id);

        public int Create(T item)
        {
            if (_Items.Contains(item)) return item.Id;
            item.Id = _Items.Count == 0
                ? 1
                : _Items.Max(r => r.Id) + 1;
            _Items.Add(item);
            return item.Id;
        }

        public abstract void Edit(int id, T item);

        public T Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
                _Items.Remove(item);
            return item;
        }

        public void SaveChanges()
        {
            System.Diagnostics.Debug.WriteLine($"Сохранение изменений в хранилище {typeof(T)}.");
        }
    }
}
