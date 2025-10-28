using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q3
{
    public class SmartHomeClass
    {
        private List<ISmaretDeviceInterface> Devices; // Encapsulated
        public DeviceType DeviceType { get; set; }

        public SmartHomeClass(List<ISmaretDeviceInterface> dev)
        {            // Constructor Injection?
            //Devices = new List<ISmaretDeviceInterface>();
            Devices = dev;
        }

        public void turnOn()
        {
            Console.WriteLine("Turn On All devices");
            foreach (ISmaretDeviceInterface dev in Devices)
            {
                dev.turnOn();
            }
        }
        public void turnOff()
        {
            Console.WriteLine("Turn Off All devices");
            foreach (ISmaretDeviceInterface dev in Devices)
            {
                dev.turnOff();
            }
        }
        public void showStatus()
        {
            Console.WriteLine("All devices status");
            foreach (ISmaretDeviceInterface dev in Devices) { 
                dev.showStatus();
            }
        }

        //Indexer
        //public ISmaretDeviceInterface this[DeviceType type] {
        //    get {
        //        foreach (ISmaretDeviceInterface dev in Devices)
        //        {
        //            if (dev.DeviceType == type)
        //            {
        //                return dev;
        //            }
        //        }
        //        return null;
        //    }
        //}

        public ISmaretDeviceInterface this[DeviceType type]
        {
            get
            {
                foreach (ISmaretDeviceInterface dev in Devices)
                {
                    if (dev.DeviceType == type)
                    {
                        return dev;
                    }
                }
                return null;
            }
        }

    }
}
