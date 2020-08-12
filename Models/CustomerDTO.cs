using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Komunalka.Client.WPF.Models
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ObservableCollection<PaymentDTO> PaymentsDTO { get; set; }
        public CustomerDTO()
        {
            PaymentsDTO = new ObservableCollection<PaymentDTO>();
        }
    }
}
