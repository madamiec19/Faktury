using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Faktury.Commands;
using Faktury.Services;
using Faktury.Utils;

namespace Faktury.ViewModels
{
    class AddContractorViewModel : ViewModelBase
    {
        public ICommand CancelContractorCreation { get; }

        public AddContractorViewModel(NavigationService invoiceListNavigationService)
        {
            CancelContractorCreation = new NavigateCommand(invoiceListNavigationService);
        }
    }
}
