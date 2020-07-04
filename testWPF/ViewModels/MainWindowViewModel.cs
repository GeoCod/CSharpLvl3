using MailSender.lib.MVVM;

namespace testWPF.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Наше новое окно";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value); //Вариант 3

            // Вариант 1
            //set => _Title = value; // В таком случае нет обратного информирования о изменении свойства

            // Вариант 2 - что бы не дублировать код этот метод реализован в библиотеке
            //set
            //{
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();
            //}
        }

        private string _TestValue = "90";

        public string TestValue
        {
            get => _TestValue;
            set => Set(ref _TestValue, value);
        }
    }
}
