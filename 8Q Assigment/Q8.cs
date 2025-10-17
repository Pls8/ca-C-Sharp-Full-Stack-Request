using ConsoleApp12_10_2025.Models;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp12_10_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙈𝙤𝙫𝙞𝙚 𝙏𝙝𝙚𝙖𝙩𝙧𝙚 𝙎𝙚𝙖𝙩 𝘽𝙤𝙤𝙠𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ///         𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙈𝙤𝙫𝙞𝙚 𝙏𝙝𝙚𝙖𝙩𝙧𝙚 𝙎𝙚𝙖𝙩 𝘽𝙤𝙤𝙠𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T 
                     
            char[,] seats = new char[5, 5];
            for (int row = 0; row < 5; row++) {
               for (int col = 0; col < 5; col++) {
                   seats[row, col] = 'A';
               }
            }
            Console.WriteLine("1.Seat Avaliable | 2.Book a Seats | 3.Cancel Booking | 4.show seats count");
            int menuOpt = int.Parse(Console.ReadLine());

            switch (menuOpt)
            {
               case 1:
                   Console.WriteLine("   0 1 2 3 4");
                   Console.WriteLine("____________");
                   for (int row = 0; row < 5; row++)
                   {
                       Console.Write(row + "| "); //WriteLine will make new line "Enter"
                       for (int col = 0; col < 5; col++)
                       {
                           Console.Write($"{seats[row, col]} ");
                       }
                       Console.WriteLine();
                   }
                   break;
               default:
                   break;
            }

            do {


               Console.WriteLine("Enter Row Number: ");
               int rowIn = int.Parse(Console.ReadLine());
               Console.WriteLine("Enter Column Number: ");
               int colIn = int.Parse(Console.ReadLine());

               if (seats[rowIn, colIn] == 'X') {
                   Console.WriteLine("Seat Alrady taking!");
               } else {
                   seats[rowIn, colIn] = 'X';
               }


            } while (true);



               char[,] seats = new char[5, 5];

               // Initialize all seats to 'A' (Available)
               for (int row = 0; row < 5; row++)
               {
                   for (int col = 0; col < 5; col++)
                   {
                       seats[row, col] = 'A';
                   }
               }

               while (true)
               {
                   Console.Clear();
                   Console.WriteLine("=== Movie Theater Seat Booking ===");
                   DisplaySeats(seats);

                   Console.Write("Enter row (0 to 4): ");
                   int row = int.Parse(Console.ReadLine());

                   Console.Write("Enter column (0 to 4): ");
                   int col = int.Parse(Console.ReadLine());

                   // Check if seat is already booked
                   if (seats[row, col] == 'X')
                   {
                       Console.WriteLine(" Seat already booked. Try another one.");
                   }
                   else
                   {
                       seats[row, col] = 'X';
                       Console.WriteLine("Seat booked successfully!");
                   }

                   Console.Write("Book another seat? (y/n): ");
                   string again = Console.ReadLine().ToLower();
                   if (again != "y") break;
               }

               Console.WriteLine("Final seat layout:");
               DisplaySeats(seats);

               static void DisplaySeats(char[,] seats)
            {
                Console.WriteLine("   0 1 2 3 4");
                for (int row = 0; row < 5; row++)
                {
                    Console.Write(row + ": ");
                    for (int col = 0; col < 5; col++)
                    {
                        Console.Write(seats[row, col] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
               

            //------------------------------------------------------------------------------------------------- E N D
            //                  𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙈𝙤𝙫𝙞𝙚 𝙏𝙝𝙚𝙖𝙩𝙧𝙚 𝙎𝙚𝙖𝙩 𝘽𝙤𝙤𝙠𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion




        }
    }

}
