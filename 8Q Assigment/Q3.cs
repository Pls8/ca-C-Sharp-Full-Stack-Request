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
            
            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙄𝙣𝙫𝙚𝙣𝙩𝙤𝙧𝙮 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙄𝙣𝙫𝙚𝙣𝙩𝙤𝙧𝙮 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 
            //_______________________________________________________________ S T A R T

            string[] products = { "apple", "orange", "milk", "bread", "eggs" };
            int[] quantities = { 5, 7, 2, 3, 10 };
            dynamic choice;
            do { 
               Console.WriteLine("1.View all product | 2.add stock | 3.sell product | 4.check product | 5.exit"); // M e n u
               choice = int.TryParse(Console.ReadLine(), out int convertChoise) ? convertChoise : "Error, input from 1 ~ 5";

               //user input process switch/case
               switch (choice)
               {
                   case 1: // view
                       viewProductQuantits(products, quantities);
                       break;
                   case 2: // add
                       addStock(products, quantities);
                       break;
                   case 3: // sell
                       sellProduct(products, quantities);
                       break;
                   case 4: // check
                       checkQ(products, quantities);
                       break;
                   default:
                       Console.WriteLine("Invalid!, Must be 1 ~ 5");
                       break;
               }
            } while (choice != 5);
            //\\\\\\\\\\\
            //𝙫𝙞𝙚𝙬 𝙢𝙚𝙩𝙝𝙤𝙙
            static void viewProductQuantits(string[] array1, int[] array2) {
               Console.WriteLine("Product\t\tQuantity");
               Console.WriteLine("___________________");
               for (int i = 0; i < array1.Length; i++)
               {
                   Console.WriteLine($"{array1[i]} \t\t {array2[i]}");
               }
            }
            //\\\\\\\\\\\
            //𝙖𝙙𝙙 𝙢𝙚𝙩𝙝𝙤𝙙
            static void addStock(string[] array1, int[] array2) {
               Console.WriteLine("Enter product name: ");
               string pdName = Console.ReadLine().ToLower(); // .ToLower() to make sure input lower case
               int foundPdIndex = -1;                          //serach product
               for (int i = 0; i < array1.Length; i++)
               {
                   if (string.Equals(pdName, array1[i]))
                   { //array1[i].ToLower() == pdName.ToLower()
                       foundPdIndex = i;                       // index in variable by name of porduct, use it to find index of quantities
                       break;
                   }
               }
               if (foundPdIndex != -1) // -1 cuz if it was  index = 0  it will think for first index
               {
                   Console.WriteLine($"Enter quantity to added for {array1[foundPdIndex]}");
                   int qToAdd = int.Parse(Console.ReadLine());
                   if (qToAdd > 0)
                   {
                       array2[foundPdIndex] += qToAdd;
                       Console.WriteLine($"Srock added! {array2[foundPdIndex]} for {array1[foundPdIndex]}");
                   }
                   else { Console.WriteLine("Invalid qunatity, must be +"); }
               }
               else { Console.WriteLine("Product not found!"); }
            }
            //\\\\\\\\\\
            //𝙨𝙚𝙡𝙡 𝙢𝙚𝙩𝙝𝙤𝙙
            static void sellProduct(string[] array1, int[] array2) {
               Console.WriteLine("Enter product name to sell: ");
               string pdName = Console.ReadLine().ToLower();

               //-----------------------Note: search by string then assign index correspond to it---------------------------//
               // search funcation by name from input user that will match first name product then it will assign index to variable
               // again -1 to make sure index accurate 0 or Null may get some error, i guess
               //serach product__________________________________________________________________________________________//
               int foundPdIndex = -1;                                                                                   
               for (int i = 0; i < array1.Length; i++)                                                                  
               {                                                                                                        
                   if (string.Equals(pdName, array1[i]))                                                                
                   {      //  ^ other way to write .Equals array1[i].ToLower() == pdName.ToLower()                      
                       foundPdIndex = i;                       // index in variable by name of porduct_Array,           
                       break;                                 //  use it to find index of quantities_Array              
                   }                                                                                                    
               }                                                                                                        
               
               if (foundPdIndex != -1) {
                   Console.WriteLine($"Enter quantity to be sell of {array1[foundPdIndex]} :");
                   int qSellAmount = int.Parse(Console.ReadLine());
                   if (qSellAmount > 0) {
                       if (qSellAmount <= array2[foundPdIndex])
                       {
                           array2[foundPdIndex] -= qSellAmount;
                           Console.WriteLine($"{array1[foundPdIndex]} been sold, remaining: {array2[foundPdIndex]}");
                       }
                       else { Console.WriteLine("Unavilable stock!"); }
                   } else { Console.WriteLine("Invalid qunatity, must be +"); }
               }
               else { Console.WriteLine("Product not found!"); }
            }
            //\\\\\\\\\\\\\
            //𝘾𝙝𝙚𝙘𝙠 𝙈𝙚𝙩𝙝𝙤𝙙
            static void checkQ(string[] array1, int[] array2) {
               Console.WriteLine("Enter product name to check it's quantities");
               string pdName = Console.ReadLine().ToLower(); // .ToLower() to make sure input lower case
               int foundPdIndex = -1;                          
               //serach product
               for (int i = 0; i < array1.Length; i++)
               {       //array1[i].ToLower() == pdName.ToLower()
                   if (string.Equals(pdName, array1[i]))
                   { 
                       // index in variable by name of porduct, use it to find index of quantities
                       foundPdIndex = i;                                               
                       break;
                   }
               }
               if (foundPdIndex != -1) // -1 cuz if it was  index = 0  it will think for first index
               {
                   Console.WriteLine($"product: {array1[foundPdIndex]} | {array2[foundPdIndex]} ");
               }
               else { Console.WriteLine("Product not found!"); }
            }

            //------------------------------------------------------------------------------------------------- E N D
            //                  𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙄𝙣𝙫𝙚𝙣𝙩𝙤𝙧𝙮 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion








        }
    }

}
