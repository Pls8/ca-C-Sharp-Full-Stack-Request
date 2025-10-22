using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q7
{
    public class LightClass : IDevice // ctrl + . > implment interface
    {
        bool isOn;
        int brightLevel;


        public string lightName { get; set; }
        public LightClass(string lightName)
        {
            isOn = false;
            brightLevel = 5;    //1 to 10
            this.lightName = lightName;
        }

        


        // interface imp
        public void showStatus()
        {
            string status = isOn ? "on" : "off";
            Console.WriteLine($"{lightName} Light | status {status}, bright level {brightLevel}%");
        }

        public void turnOff()
        {
            isOn = false;
            Console.WriteLine($"{lightName} light turnd off");
        }

        public void turnOn()
        {
            isOn = true;
            Console.WriteLine($"{lightName} light turnd on");
        }


        //light level method
        public void setBrightLevel(int lvl) {
            if (lvl < 0) { lvl = 0; }

            if (lvl > 10) { lvl = 10; }
        }


        //light level controll
        public void inrecsBrightLevel()
        {
            if (brightLevel < 100)
            {
                brightLevel += 1;
                Console.WriteLine($"{lightName} bright level increse to {brightLevel}%");
            }
        }

        public void decreasBrightLevel()
        {
            if (brightLevel > 0)
            {
                brightLevel -= 1;
                Console.WriteLine($"{lightName} bright level decrease to {brightLevel}%");
            }
        }


    }
}
