using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Faktury.Commands;
using Faktury.Models;
using Faktury.Services;
using Faktury.Stores;
using Faktury.Utils;

namespace Faktury.ViewModels
{
    class InvoiceListViewModel : ViewModelBase
    {
        public ObservableCollection<InvoiceViewModel> Invoices {  get; set; }

        public ICommand SetOwnCompanyCommand { get; }
        public ICommand AddContractorCommand { get; }
        public ICommand InvoiceCreatorCommand { get; }

        public InvoiceListViewModel(
            NavigationService invoiceCreatorNavigationService, 
            NavigationService addContractorNavigationService,
            NavigationService setOwnCompanyNavigationService)
        {
            // Sample data for testing
            var vendor = new Company { Name = "Vendor Company", Address = "123 Main St", Nip = "1234567890", Regon = "0987654321" };
            var purchaser = new Company { Name = "Purchaser Company", Address = "456 Other St", Nip = "9876543210", Regon = "1234567890" };

            var products = new List<Product>
            {
                new Product { Name = "Product 1", Quantity = 2, UnitOfMeasure = "pcs", NetUnitPrice = 10.0, TaxRate = 23.0 },
                new Product { Name = "Product 2", Quantity = 1, UnitOfMeasure = "pcs", NetUnitPrice = 50.0, TaxRate = 8.0 },
            };
            
            Invoice invoice1 = new Invoice(1, vendor, purchaser, DateTime.Now, DateTime.Now.AddDays(-1), products);
            Invoice invoice2 = new Invoice(2, vendor, purchaser, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-3), products);

            Invoices = new ObservableCollection<InvoiceViewModel>
            {
                new InvoiceViewModel(invoice1),
                new InvoiceViewModel(invoice2)
                
            };

            InvoiceCreatorCommand = new NavigateCommand(invoiceCreatorNavigationService);
            AddContractorCommand = new NavigateCommand(addContractorNavigationService);
            SetOwnCompanyCommand = new NavigateCommand(setOwnCompanyNavigationService);
        }

    }
}
