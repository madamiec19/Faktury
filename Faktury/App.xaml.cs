using System.Configuration;
using System.Data;
using System.Windows;
using Faktury.Models;
using Faktury.Services;
using Faktury.Stores;
using Faktury.ViewModels;

namespace Faktury
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;


        public App()
        {
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateInvoiceListViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private InvoiceCreatorViewModel CreateInvoiceCreatorViewModel()
        {
            return new InvoiceCreatorViewModel(new NavigationService(_navigationStore, CreateInvoiceListViewModel));
        }

        private InvoiceListViewModel CreateInvoiceListViewModel()
        {
            return new InvoiceListViewModel(new NavigationService( _navigationStore, CreateInvoiceCreatorViewModel));
        }
    }

}
