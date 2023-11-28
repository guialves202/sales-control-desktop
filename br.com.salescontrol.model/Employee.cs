using salesControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.salescontrol.model
{
    public class Employee : Customer
    {
        public string password { get; set; }
        public string position { get; set; }
        public EmployeeAccessLevel accessLevel { get; set; }
    }
}
