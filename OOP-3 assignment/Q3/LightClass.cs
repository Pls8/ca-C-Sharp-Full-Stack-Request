using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q3
{
    public class LightClass : ISmaretDeviceInterface
    {
        bool isOn;
        int brightness = 0;

        public DeviceType DeviceType { get; set; }
        public LightClass() { DeviceType = DeviceType.light; }


        public void turnOn() { isOn = true; brightness = 0; Console.WriteLine("Light is On"); }
        public void turnOff() { isOn = false; brightness = 5; Console.WriteLine("Light is Off"); }
        public void showStatus() { 
            string status = isOn ? "ON" : "OFF";
            Console.WriteLine($"Light status {status} | bright {brightness}%");
        }

    }
}
