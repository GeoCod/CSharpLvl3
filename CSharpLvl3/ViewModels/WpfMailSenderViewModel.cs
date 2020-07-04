using System.Windows;
using System.Windows.Input;
using CSharpLvl3.Infrastructure.Commands;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace CSharpLvl3.ViewModels
{
    public class WpfMailSenderViewModel : ViewModelBase
    {
        #region Поля
        private string _Title = "Расылщик";
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

        #endregion

        public WpfMailSenderViewModel()
        {
            #region Команды

            CloseApplicationCommnd = new LambdaCommand(OnCloseApplicationCommndExecuted, CanCloseApplicationCommndExecute);

            #endregion
        }
    }
}
