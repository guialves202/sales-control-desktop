using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.model
{
    public class SaleProducts
    {
        public int id { get; set; }
        public int saleId { get; set; }
        public int productId { get; set; }
        public int productQuantity { get; set; }
        public decimal subtotal { get; set; }
    }
}
