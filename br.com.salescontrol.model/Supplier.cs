using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.model
{
    public class Supplier
    {
        public int code { get; set; }
        public string name { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string cellphone { get; set; }
        public string cep { get; set; }
        public string address { get; set; }
        public string addressNumber { get; set; }
        public string complement { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string uf { get; set; }
    }
}
