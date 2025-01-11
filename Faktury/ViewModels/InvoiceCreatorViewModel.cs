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
using Faktury.Utils;

namespace Faktury.ViewModels
{
    class InvoiceCreatorViewModel : ViewModelBase
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        private DateTime _issueDate;
        public DateTime IssueDate 
        { 
            get
            {
                return _issueDate;
            }
            set
            {
                _issueDate = value;
                OnPropertyChanged(nameof(IssueDate));
            }
        }
       
        private DateTime _invoiceDate;
        public DateTime InvoiceDate
        {
            get
            {
                return _invoiceDate;
            }
            set
            {
                _invoiceDate = value; 
                OnPropertyChanged(nameof(InvoiceDate));
            }
        }

        private string _productName;
        public string ProductName { 
            get 
            { 
                return _productName;  
            } 
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }
        private double _quantity;
        public double Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        private double _unitPrice;
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                OnPropertyChanged(nameof(UnitPrice));
            }
        }

        private double _unitOfMeasure;
        public double UnitOfMeasure
        {
            get
            {
                return _unitOfMeasure;
            }
            set
            {
                _unitOfMeasure = value;
                OnPropertyChanged(nameof(UnitOfMeasure));
            }
        }

        private double _taxRate;
        public double TaxRate
        {
            get
            {
                return _taxRate;
            }
            set
            {
                _taxRate = value;
                OnPropertyChanged(nameof(TaxRate));
            }
        }

        private Company _selectedCompany;
        public Company SelectedCompany
        {
            get
            {
                return _selectedCompany;
            }
            set
            {
                _selectedCompany = value;
                OnPropertyChanged(nameof(SelectedCompany));
            }
        }

        private Company _ownCompany;
        public Company OwnCompany
        {
            get
            {
                return _ownCompany;
            }
            set
            {
                _ownCompany = value;
                OnPropertyChanged(nameof(OwnCompany));
            }
        }

        public ObservableCollection<Company?> UserCompanies { get; set; }

        public ObservableCollection<Product> Products { get; set; }

        public ICommand AddProductCommand { get; }
        public ICommand AddInvoiceCommand { get; }
        public ICommand CancelInvoiceCommand { get; }


        public InvoiceCreatorViewModel(NavigationService invoiceListNavigationService)
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 1, Name = "Product Aaaaaaaaa saf dsa fdsg sd fads fass s", Quantity = 1, NetUnitPrice = 100, TaxRate = 8 },
                new Product { Id = 2, Name = "Product B", Quantity = 1, NetUnitPrice = 100, TaxRate = 23 }
            };
            SelectedCompany = new Company { Id = 2, Name = "Company sp. z o.o.", Address = "ul. Nowa 9 \n05-430 Radom", Nip = "2343453452", Regon = "432423524" };


            CancelInvoiceCommand = new NavigateCommand(invoiceListNavigationService);
        }
    }
}
