using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q7
{
    internal class ThermostatClass : IDevice
    {
        bool isOn;
        double currntTemp;
        double targetTemp;

        public ThermostatClass(string thermoName)
        {
            this.thermoName = thermoName;
            isOn = false;
            currntTemp = 30.0;
            targetTemp = 27.0;   
        }

        public string thermoName { get; set; }


        //interface imp > ctrl + . at CLass name
        // interface imp
        public void showStatus()
        {
            string status = isOn ? "on" : "off";
            Console.WriteLine($"{thermoName} thremostat | status {status}," +
                $" current {currntTemp}C, target {targetTemp}C ");
        }

        public void turnOff()
        {
            isOn = false;
            Console.WriteLine($"{thermoName} thermostat  turnd off");
        }

        public void turnOn()
        {
            isOn = true;
            Console.WriteLine($"{thermoName} thermostat  turnd on");
        }




        //thremo level method
        public void setThermoLevel(double temp)
        {
            targetTemp = temp;
            Console.WriteLine($"{thermoName} target temp set {targetTemp}");

            //if (isOn) {
            //    adjustTemp();
            //}
        }


        //thremo level controll
        public void inrecsTemp()
        {
            targetTemp += 1;
            Console.WriteLine($"{thermoName} increse, current target temp {targetTemp}C");

            if (isOn) { adjustTemp(); }
        }

        public void decreasTemp()
        {
            targetTemp -= 1;
            Console.WriteLine($"{thermoName} decrease, current target temp {targetTemp}C");

            if (isOn) { adjustTemp(); }

        }




        //common method, this will adujst temp base on target temp var
        void adjustTemp()
        {
            if (currntTemp < targetTemp)
            {
                currntTemp += 1;
                Console.WriteLine($"{thermoName} increse temp, current {currntTemp}C");
            }
            else if (currntTemp > targetTemp)
            {
                currntTemp -= 1;
                Console.WriteLine($"{thermoName} decrease temp, current {currntTemp}");
            }

        }





    }
}
