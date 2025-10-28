using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q3
{
    public interface ISmaretDeviceInterface
    {
        DeviceType DeviceType { get; set; }

        void turnOn();
        void turnOff();
        void showStatus();
    }
}
