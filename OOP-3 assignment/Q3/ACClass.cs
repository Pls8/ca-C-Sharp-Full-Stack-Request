using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q3
{
    public class ACClass : ISmaretDeviceInterface
    {
        bool isOn;
        int temp = 0;

        public DeviceType DeviceType { get; set; }
        
        public ACClass() { DeviceType = DeviceType.AC; }



        public void turnOn()
        {
            isOn = true;
            temp = 25;
            Console.WriteLine("AC is On");
        }
        public void turnOff()
        {
            isOn = false;
            temp = 20;
            Console.WriteLine("AC is Off");
        }
        public void showStatus()
        {
            string status = isOn ? "ON" : "OFF";
            Console.WriteLine($"AC status {status} | temperature {temp}%");
        }
    }
}
