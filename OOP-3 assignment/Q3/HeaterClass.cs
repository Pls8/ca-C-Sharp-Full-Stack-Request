using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q3
{
    public class HeaterClass : ISmaretDeviceInterface
    {
        bool isOn;
        int temp = 0;

        public DeviceType DeviceType { get; set; }
        public HeaterClass() { DeviceType = DeviceType.heater; }


       

        public void turnOn() { 
            isOn = true;
            temp = 20;
            Console.WriteLine("Heater is On");
        }
        public void turnOff() { 
            isOn = false;
            temp = 30;
            Console.WriteLine("Heater is Off");
        }
        public void showStatus()
        {
            string status = isOn ? "ON" : "OFF";
            Console.WriteLine($"Heater status {status} | temperature {temp}%");
        }
    }
}
