using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public double NetUnitPrice { get; set; }
        public double TaxRate { get; set; }

        public double TaxAmount => TaxRate * 0.01 * NetAmount;
        public double NetAmount => NetUnitPrice * Quantity;
        public double TotalPrice => TaxAmount + NetAmount;
    }
}
