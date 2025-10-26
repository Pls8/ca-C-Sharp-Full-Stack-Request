using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.Models.project_2
{
    public class CafeClass
    {
        public CafeClass(string namE, decimal pricE, Menu menu)
        {
            this.namE = namE;
            this.pricE = pricE;
            this.menu = menu;
        }

        public string namE { get; set; }
        public decimal pricE { get; set; }
        public Menu menu { get; set; }


        public virtual void displayDesc() {
            Console.WriteLine($"{namE} | {pricE}.OMR | {menu}");
        }



    }
}
