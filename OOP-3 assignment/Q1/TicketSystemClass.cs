using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q1
{
    public class TicketSystemClass
    {
        //public List<TicketClass> ticketClasses { get; set; }
        public TicketClass[] tickets;
        int ticketsCount;

        public TicketSystemClass(int sizeArry = 10)
        {
            this.tickets = new TicketClass[sizeArry];
            this.ticketsCount = 0;
        }


        // indexer, access tickets by seat number?
        // while the imp is understandable, the way is new
        public TicketClass this[int seatNum] {
            get {
                for (int i = 0; i < ticketsCount; i++) {
                    if (tickets[i].seatNumber == seatNum)
                    {
                        return tickets[i];
                    }
                }
                return null;
            }
        }

        public void findSeat(int st) {
            
            // must use in TicketClass > public override string ToString() <----------------------
            for (int i = 0; i < ticketsCount; i++) {                                            //|
                if (tickets[i].seatNumber == st)                                                //|
                {                                                                               //|
                    Console.WriteLine($"found > [ {tickets[i]} ]");                             //|
                                                 // ^-- this converion object to string! -----> //
                }
            }
        }




        //add ticket to system, by object?
        public void addTicket(TicketClass ticket)
        {
            if (ticketsCount >= tickets.Length)
            {
                Console.WriteLine("ticket system is full");
                return;
            }
            else if (this[ticket.seatNumber] != null)
            {
                Console.WriteLine($"Seat [ {ticket.seatNumber} ] already taken");
                return;
            }
            else
            {
                tickets[ticketsCount] = ticket;
                ticketsCount++;
                Console.WriteLine($"ticket add for seat [ {ticket.seatNumber} ]");
            }
        }


        //overloading method
        public void addTicket(string eventName, int seatNum, TicketType tkType)
        {
            TicketClass ticket = new TicketClass(eventName, seatNum, tkType);
            addTicket(ticket);
        }



        //method to count how many tickets are of each type
        public void countTkType() { 
            int regularTK = 0, vipTK = 0, backstagTK = 0;

            for (int i = 0; i < ticketsCount; i++) {
                switch (tickets[i].ticketType)
                {
                    case TicketType.Regular: regularTK++; break;

                    case TicketType.VIP: vipTK++; break;

                    case TicketType.Backstage: backstagTK++; break;

                }
            }
            Console.WriteLine(".....................Ticket Type Count.....................");
            Console.WriteLine($"regular [{regularTK}] | vip [{vipTK}] | backstage [{backstagTK}]");
        }


    }
}
