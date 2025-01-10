using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faktury.Models;
using Faktury.Utils;
using Faktury.ViewModels;

namespace Faktury.Commands
{
    class AddInvoiceCommand : CommandBase
    {
        private readonly InvoiceCreatorViewModel _invoiceCreatorViewModel;

        public AddInvoiceCommand(InvoiceCreatorViewModel invoiceCreatorViewModel)
        {
            _invoiceCreatorViewModel = invoiceCreatorViewModel;
        }

        public override void Execute(object? parameter)
        {
            //Invoice newInvoice = new Invoice(_invoiceCreatorViewModel.)
        }
    }
}
