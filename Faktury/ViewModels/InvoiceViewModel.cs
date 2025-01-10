using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faktury.Models;
using Faktury.Utils;

namespace Faktury.ViewModels
{
    class InvoiceViewModel : ViewModelBase
    {
        private Invoice _invoice;
        public int Id => _invoice.Id;

        public string InvoiceNumber => $"{_invoice.Id}/{_invoice.InvoiceDate.Year}";

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

        public InvoiceViewModel(Invoice invoice)
        {
            _invoice = invoice;
        }
    }
}
