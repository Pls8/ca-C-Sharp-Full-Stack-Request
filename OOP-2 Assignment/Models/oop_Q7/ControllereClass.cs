using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q7
{
    public class ControllereClass
    {
        IDevice[] deviceS;
        int deviceCount;


        public ControllereClass(int maxDevice = 4)  //defult value 4
        {
            deviceS = new IDevice[maxDevice];
            deviceCount = 0;
        }
        
        //device imp IDevice
        public void addDevice(IDevice device) {
            if (deviceCount >= deviceS.Length) {
                Console.WriteLine("Controller is full");
                return;
            }

            deviceS[deviceCount++] = device;
            //deviceCount++;
            Console.WriteLine($"device add to controller");
        }

        public void onAllDevice(){
            Console.WriteLine("____Trun on all devices____");
            for (int i = 0; i < deviceCount; i++) {
                deviceS[i].turnOn();
            }
        }

        public void offAllDevice()
        {
            Console.WriteLine("____Trun off all devices____");
            for (int i = 0; i < deviceCount; i++)
            {
                deviceS[i].turnOff();
            }
        }

        public void showDeviceStatus() {
            Console.WriteLine("All devices status");

            for (int i = 0; i < deviceCount; i++)
            {
                deviceS[i].showStatus();
            }
        }

        public void controlDeviceIndex(int index) {
            if (index < 0 || index >= deviceCount)
            {
                Console.WriteLine("Invalid index");
                return ;
            }

            Console.WriteLine($"Device controlling {index + 1}");
            deviceS[index].turnOn();
            deviceS[index].showStatus();
            deviceS[index].turnOff();
            
        }

        // number of device
        public int getDeviceCount() {
            return deviceCount;
        }




    }
}
