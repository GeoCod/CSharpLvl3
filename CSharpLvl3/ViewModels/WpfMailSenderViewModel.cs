using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using CSharpLvl3.Infrastructure.Commands;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Entities;
using MailSender.lib.Services;

namespace CSharpLvl3.ViewModels
{
    public class WpfMailSenderViewModel : ViewModelBase
    {
        #region Поля
        private string _Title = "Расылщик";

        private readonly RecipientsManager _RecipientsManager;
        #endregion


        #region Свойства

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion


        // При обновлении коллекции оповещаем интерфейс
        private ObservableCollection<Recipient> _Recipients;
        public ObservableCollection<Recipient> Recipients
        {
            get => _Recipients;
            private set => Set(ref _Recipients, value);
        }


        #region Команды

        #region CloseApplicationCommand
        /// <summary>Команда закрывающая приложение</summary>
        public ICommand CloseApplicationCommnd { get; }

        private bool CanCloseApplicationCommndExecute(object p) => true;

        /// <summary>Запуск в момент когда команда выпоняется</summary>
        /// <param name="p"></param>
        private void OnCloseApplicationCommndExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #endregion
        
        public WpfMailSenderViewModel(RecipientsManager RecipientsManager)
        {

            #region Команды

            CloseApplicationCommnd = new LambdaCommand(OnCloseApplicationCommndExecuted, CanCloseApplicationCommndExecute);

            #endregion

            _RecipientsManager = RecipientsManager;

            _Recipients = new ObservableCollection<Recipient>(_RecipientsManager.GetAll());
        }
    }
}
