using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using CSharpLvl3.Infrastructure.Commands;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Entities;
using MailSender.lib.Services;
using MailSender.lib.Services.Interfaces;

namespace CSharpLvl3.ViewModels
{
    public class WpfMailSenderViewModel : ViewModelBase
    {
        #region Поля
        private string _Title = "Расылщик";

        private readonly IRecipientsManager _RecipientsManager;
        #endregion


        #region Свойства

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion


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

        #region LoadRecipientsDataCommand
        /// <summary>Команда загружающая данные на форму</summary>
        public ICommand LoadRecipientsDataCommand { get; }

        private bool CanLoadRecipientsDataCommandExecute() => true;

        private void OnLoadRecipientsDataCommandExecuted()
        {
            Recipients = new ObservableCollection<Recipient>(_RecipientsManager.GetAll());
        }
        #endregion

        #region SaveRecipientChangesCommand
        /// <summary>Команда загружающая данные на форму</summary>
        public ICommand SaveRecipientChangesCommand { get; }

        private bool CanSaveRecipientChangesCommandExecute(Recipient recipient) => recipient != null;

        private void OnSaveRecipientChangesCommandExecuted(Recipient recipient)
        {
            _RecipientsManager.Edit(recipient);
            _RecipientsManager.SaveChanges();
        }
        #endregion

        #endregion


        // При обновлении коллекции оповещаем интерфейс
        private ObservableCollection<Recipient> _Recipients;
        public ObservableCollection<Recipient> Recipients
        {
            get => _Recipients;
            private set => Set(ref _Recipients, value);
        }

        private Recipient _SelectRecipient;

        public Recipient SelectedRecipient
        {
            get => _SelectRecipient;
            set => Set(ref _SelectRecipient, value);
        }

        
        public WpfMailSenderViewModel(IRecipientsManager RecipientsManager)
        {
            _RecipientsManager = RecipientsManager;

            #region Команды

            CloseApplicationCommnd = new LambdaCommand(OnCloseApplicationCommndExecuted, CanCloseApplicationCommndExecute);

            LoadRecipientsDataCommand = new RelayCommand(OnLoadRecipientsDataCommandExecuted, CanLoadRecipientsDataCommandExecute);

            SaveRecipientChangesCommand = new RelayCommand<Recipient>(OnSaveRecipientChangesCommandExecuted, CanSaveRecipientChangesCommandExecute);

            #endregion
        }
    }
}
