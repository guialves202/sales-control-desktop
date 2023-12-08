using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.model
{
    public class Sale
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public DateTime saleDate { get; set; }
        public decimal finalPrice { get; set; }
        public string observations { get; set; }
    }
}
