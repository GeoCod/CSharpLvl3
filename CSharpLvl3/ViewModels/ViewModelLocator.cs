using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;

namespace CSharpLvl3.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            // Регистрируем сервисы
            var services = SimpleIoc.Default;

            services.Register<WpfMailSenderViewModel>();

            services.Register<RecipientsManager>();
            services.Register<RecipientStoreInMemory>();
        }

        public WpfMailSenderViewModel MainWindowViewModel => ServiceLocator.Current.GetInstance<WpfMailSenderViewModel>();
    }
}
