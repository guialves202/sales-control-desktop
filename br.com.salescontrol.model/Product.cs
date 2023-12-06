using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.model
{
    public class Product
    {
        public int code { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public int supplierId { get; set; }
    }
}
