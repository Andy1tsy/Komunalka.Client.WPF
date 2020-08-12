using System;
using System.Collections.Generic;
using System.Text;

namespace Komunalka.Client.WPF.Models
{
    public class PayingFixedSummaDTO
    {
        public string ServiceProviderNane { get; set; }
        public string Account { get; set; }
        public decimal Summa { get; set; }

        public PayingFixedSummaDTO()
        {

        }
    }
}
