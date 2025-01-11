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
    class SetOwnCompanyViewModel : ViewModelBase
    {
        public ICommand CancelOwnCompanySetting { get; }
        public ICommand AddOwnCompany { get; }

        public SetOwnCompanyViewModel(NavigationService invoiceListNavigationService)
        {
            CancelOwnCompanySetting = new NavigateCommand(invoiceListNavigationService);
            AddOwnCompany = new NavigateCommand(invoiceListNavigationService);
        }

    }
}
