using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q1
{
    public class TicketClass
    {
        // _____________________________________Note_________________________________________
        // constructer: is special methods used to create an object instance                 |
        // as ai say: constructors cannot be virtual the override to TicketSystemClass.cs    |
        // but can be done with constructor chaining                                         |
        // ----------------------------------------------------------------------------------/
        public TicketClass(string eventName, int seatNumber, TicketType ticketType)
        {
            this.eventName = eventName;
            this.seatNumber = seatNumber;
            this.ticketType = ticketType;
        }

        //private set > encapsulation: hiding internal data, i guess?
        public string eventName { get; private set; } 
        public int seatNumber { get; private set; }
        public TicketType ticketType { get; private set; }


        public void displayTicketInfo() {
            Console.WriteLine($"event: {eventName} | seat: {seatNumber} | type: {ticketType}");
        }

        public decimal getTicketPrice() {
            return 
                ticketType == TicketType.Regular ? 2m :
                ticketType == TicketType.VIP ? 4m :
                ticketType == TicketType.Backstage ? 8m :
                0m; // 0m is defualt value
        }



        public override string ToString()
        {
            return $"event {eventName} | seat {seatNumber} | type {ticketType}";
        }
    }
}
