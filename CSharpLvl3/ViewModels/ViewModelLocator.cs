using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using MailSender.lib.Services;
using MailSender.lib.Services.Interfaces;

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

            services.Register<IRecipientsManager, RecipientsManager>();
            services.Register<IRecipientStore, RecipientStoreInMemory>();
        }

        public WpfMailSenderViewModel MainWindowViewModel => ServiceLocator.Current.GetInstance<WpfMailSenderViewModel>();
    }
}
