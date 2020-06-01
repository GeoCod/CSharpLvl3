using System.Windows;
using System.Windows.Input;
using CSharpLvl3.Infrastructure.Commands;

namespace CSharpLvl3.ViewModels
{
    internal class WpfMailSenderViewModel
    {
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
