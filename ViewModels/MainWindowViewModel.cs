using Komunalka.Client.WPF.Common;
using Komunalka.Client.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Komunalka.Client.WPF.ViewModels
{
    public class MainWindowViewModel : BindingBase
    {
        private CustomerDTO _currentCustomerDTO;
        public ObservableCollection<CustomerDTO> Customers { get; set; }
        public CustomerDTO CurrentCustomerDTO
        {
            get => _currentCustomerDTO;
            set
            {
                if (Equals(_currentCustomerDTO, value)) return;

                _currentCustomerDTO = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {

        }

    }
}
