using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MailSender.lib.MVVM
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Метод отслеживающий изменение свойств</summary>
        /// <param name="PropertyName">Название вызывавшего метода</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

            //Вариант 2 (устаревший)
            //var handlers = PropertyChanged;
            //if (handlers != null)
            //    handlers(this, new PropertyChangedEventArgs(PropertyName));
        }

        // В сеттерах свойств за которыми следим будем вызывать данный метод (для упрощения)
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
