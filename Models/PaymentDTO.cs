using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Komunalka.Client.WPF.Models
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public DateTime Timestamp { get; set; }

        public ObservableCollection<PayingByCounterDTO> PayingsByCounterDTO { get; set; }
        public ObservableCollection<PayingFixedSummaDTO> PayingsFixedSummaDTO { get; set; }

        public PaymentDTO()
        {
            PayingsByCounterDTO = new ObservableCollection<PayingByCounterDTO>();
            PayingsFixedSummaDTO = new ObservableCollection<PayingFixedSummaDTO>();
        }
    }
}
