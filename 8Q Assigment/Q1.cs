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
           
           

            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝘽𝙖𝙣𝙠 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝙎𝙞𝙢𝙥𝙡𝙚 𝘽𝙖𝙣𝙠 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T

            //transaction will be by INDEX of array name
            string[] bkUserName = { "user1", "user2", "user3" };
            string[] bkPassword = { "123", "123", "123" };
            decimal[] bkBalance = { 100, 200, 300 };
            bool isAuth = false;
            int userIndex = -1;
            //login
            do {
               Console.Write("Username: ");
               string userUserName = Console.ReadLine();
               Console.Write("Password: ");
               string userPassword = Console.ReadLine();

               for (int i = 0; i < bkUserName.Length; i++) {
                   if (!(userUserName == bkUserName[i] && userPassword == bkPassword[i]))
                   {
                       if(bkUserName.Length == i) {
                           Console.WriteLine("Invalid user or password!");
                       }
                   }
                   else if (userUserName == bkUserName[i] && userPassword == bkPassword[i]) {
                       isAuth = true;
                       userIndex = i;
                       break;
                   }
               }
            } while (!isAuth);

            Console.WriteLine($"Welecome {bkUserName[userIndex]}, Balance {bkBalance[userIndex]}");
            Console.Write("Enter Number \n1.Deposite | 2.Withdraw | 3.Balance | 4.Transfer: ");
            int bkValOption =  int.Parse(Console.ReadLine());
            switch (bkValOption)
            {
               case 1:
                   Console.WriteLine("_________Deposite_________");
                   Console.WriteLine($"Bank amount {bkBalance[userIndex]}");
                   Console.Write("Enter amount to deposite: ");
                   int userInAmount = int.Parse(Console.ReadLine());
                   if (userInAmount <= 0)
                   {
                       Console.WriteLine("Invalid amount!");
                   }
                   else {
                       bkBalance[userIndex] += userInAmount;
                       Console.WriteLine($"User Balalnce: {bkBalance[userIndex]}");
                   }
                       break;
               case 2:
                   Console.WriteLine("_________Withdraw_________");
                   Console.WriteLine($"Bank amount {bkBalance[userIndex]}");
                   Console.Write("Enter amount to withdraw: ");
                   userInAmount = int.Parse(Console.ReadLine());
                   if (userInAmount <= 0)
                   {
                       Console.WriteLine("Invalid amount!");
                   }
                   else
                   {
                       bkBalance[userIndex] -= userInAmount;
                       Console.WriteLine($"User Balalnce: {bkBalance[userIndex]}");
                   }
                   break;
               case 3:
                   Console.WriteLine($"Current Balance {bkBalance[userIndex]}");
                   break;
               case 4:
                   Console.WriteLine("_________Transfer_________");
                   int tempReciveIndex = -1;

                   //show other user
                   Console.WriteLine("\t User ");
                   for (int i = 0; i < bkUserName.Length; i++)
                   { 
                       if (i != userIndex) {
                           Console.Write($" {bkUserName[i]} ");
                       }
                   }
                   Console.WriteLine("\nEnter the username you want to send money to: ");                    
                   string receiverUsername = Console.ReadLine().ToLower();

                   //find receiver name index
                   for (int i = 0; i < bkUserName.Length; i++)
                   {
                       if (bkUserName[i] == receiverUsername && i != userIndex)
                       {
                           // if user at index [i] match input Receiver _AND_ [i] not equal to current user index
                           tempReciveIndex = i;
                           break;
                       }
                       else if (tempReciveIndex == -1)
                       {
                           Console.WriteLine("Invalid receiver username!");
                           return;
                       }
                   }


                   //Amount to be transfer
                   Console.Write("Enter Amount transfer: ");
                   decimal transAmount;
                   transAmount = decimal.Parse(Console.ReadLine());
                   if (transAmount <= 0)
                   {
                       Console.WriteLine("Inalide!");                        
                   }
                   else if (transAmount > bkBalance[userIndex])
                   {
                       Console.WriteLine($"Insufficient amount, your balance {bkBalance[userIndex]}");
                       return;
                   }
                   else { 
                       bkBalance[userIndex] -= transAmount;
                       bkBalance[tempReciveIndex] += transAmount;
                       Console.WriteLine($"Transaction successful! | new balance {bkBalance[userIndex]}");
                       Console.WriteLine($"^ONLY FOR CHECK IF IT WORK^ user:{bkUserName[tempReciveIndex]} | {bkBalance[tempReciveIndex]}");
                   }
                   break;
               default:
                   break;
            }

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝙎𝙞𝙢𝙥𝙡𝙚 𝘽𝙖𝙣𝙠 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion





        }
    }

}
