using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q3
{
    public class FanClass : ISmaretDeviceInterface
    {
        bool isOn;
        int speed = 0;

        public DeviceType DeviceType { get; set; }
        public FanClass() { DeviceType = DeviceType.fan; }


        public void turnOn() { isOn = true; speed = 3; Console.WriteLine("Fan is On"); }
        public void turnOff() { isOn = false; speed = 0; Console.WriteLine("Fan is Off"); }
        public void showStatus()
        {
            string status = isOn ? "ON" : "OFF";
            Console.WriteLine($"Fan status {status} | speed {speed}%");
        }
    }
}
