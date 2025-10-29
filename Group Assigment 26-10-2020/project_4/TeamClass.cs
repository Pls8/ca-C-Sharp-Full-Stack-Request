using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_4
{
    public class TeamClass
    {
        public TeamClass(string namE, string coacH)
        {
            this.namE = namE;
            this.coacH = coacH;
            this.playeR = new List<string>();
        }

        public string namE { get; set; }
        public string coacH { get; set; }
        public List<string> playeR{ get; set; }
    }
}
