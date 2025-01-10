using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury.Models
{
    class Invoice
    {
        public Invoice(int id, Company vendor, Company purchaser, DateTime issueDate, DateTime invoiceDate, List<Product> products)
        {
            Id = id;
            Vendor = vendor;
            Purchaser = purchaser;
            IssueDate = issueDate;
            InvoiceDate = invoiceDate;
            Products = products;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public Company Vendor { get; set; }
        public Company Purchaser { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<Product> Products { get; set; }

        public double GetTaxAmmount(double TaxRate)
        {
            double sum = 0;
            foreach (Product product in Products) {
                if(product.TaxRate == TaxRate)
                {
                    sum += product.TaxAmount;
                }
   
            }
            return sum;
        }

        public double GetNetAmount()
        {
            double sum = 0;
            foreach (Product product in Products)
            {
                sum += product.TaxRate;
            }
            return sum;
        }

        public double GetFullAmount()
        {
            double tax = GetTaxAmmount(5.0) + GetTaxAmmount(8.0) + GetTaxAmmount(23.0);
            return GetNetAmount() + tax;
        }

        

    }

    
}
