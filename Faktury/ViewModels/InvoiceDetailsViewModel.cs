using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faktury.Models;
using Faktury.Utils;

namespace Faktury.ViewModels
{
    class InvoiceDetailsViewModel : ViewModelBase
    {
        private Invoice _invoice;
        public int Id => _invoice.Id;

        public string InvoiceNumber => $"Invoice {_invoice.Id}/{_invoice.InvoiceDate.Year}";

        public Company Vendor => _invoice.Vendor;

        public Company Purchaser => _invoice.Purchaser;

        public DateTime IssueDate => _invoice.IssueDate;

        public DateTime InvoiceDate => _invoice.InvoiceDate;

        public List<Product> Products => _invoice.Products;

        public double TaxAmount5 => _invoice.GetTaxAmmount(5.0);

        public double TaxAmount8 => _invoice.GetTaxAmmount(8.0);

        public double TaxAmount23 => _invoice.GetTaxAmmount(23.0);

        public double NetAmount => _invoice.GetNetAmount();

        public double FullAmount => _invoice.GetFullAmount();

        public InvoiceDetailsViewModel()
        {
            var vendor = new Company { Name = "Vendor Company", Address = "123 Main St", Nip = "1234567890", Regon = "0987654321" };
            var purchaser = new Company { Name = "Purchaser Company", Address = "456 Other St", Nip = "9876543210", Regon = "1234567890" };

            var products = new List<Product>
            {
            new Product { Name = "Product 1", Quantity = 2, UnitOfMeasure = "pcs", NetUnitPrice = 10.0, TaxRate = 23.0 },
            new Product { Name = "Product 2", Quantity = 1, UnitOfMeasure = "pcs", NetUnitPrice = 50.0, TaxRate = 8.0 },
            };

            _invoice = new Invoice(1, vendor, purchaser, DateTime.Now, DateTime.Now.AddDays(-1), products);
        }
    }
}
