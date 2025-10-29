using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_3
{
    public class CustomerClass
    {
        public CustomerClass(string customerName, string phoneNumber)
        {
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
        }

        public string customerName { get; set; }
        public string phoneNumber { get; set; }


    }
}
