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
            

            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T
            Console.WriteLine("\t\t\t_______Student Grade System_________");
            string[] stdName = new string[3];
            int[] stdGrade = new int[3];
            int tempStdNumber = 0, choiseStd = 0;
            do {
               Console.WriteLine("\t\t\t\t_____Option____");                
               Console.WriteLine("1.add student | 2.update grade | 3.view all student & grade | 4.statistics | 5.Exit");
               choiseStd = int.Parse(Console.ReadLine());

               switch (choiseStd)
               {
                   case 1: //add
                       if(tempStdNumber >= stdName.Length) {                   //check array size
                           Console.WriteLine("System is full!");
                           return;
                       }

                       Console.WriteLine("Enter sutdent Name: ");                  //Name  
                       string stdNameInput = Console.ReadLine().ToLower();     
                       if (string.IsNullOrEmpty(stdNameInput)){
                           //Name check
                           Console.WriteLine("Invalid input!");
                           return;
                       }

                       Console.WriteLine($"Enter [{stdNameInput}]  Grade: ");      //Grade    
                       int gradeInput = int.Parse(Console.ReadLine());                         
                       if (gradeInput <= 0 || gradeInput >= 100)
                       {   //Grade value range validation
                           Console.WriteLine("Invalide Grade!");
                           return;
                       }

                       stdName[tempStdNumber] = stdNameInput;
                       stdGrade[tempStdNumber] = gradeInput;
                       tempStdNumber++;
                       Console.WriteLine($"student _{stdName}_ added with grade _{gradeInput}_");
                   break;
                       //End Case 1


                   case 2: //update
                       if (tempStdNumber == 0)
                       {
                           Console.WriteLine("No students yet!");
                           return;
                       }

                       Console.WriteLine("Enter student name to update: ");
                       stdNameInput = Console.ReadLine().ToLower();

                       //student search 
                       int foundIndex = -1; // like before, start from -1 not 0  > 0 will point at index!
                       for (int i = 0; i < tempStdNumber; i++) {
                           if (stdName[i] == stdNameInput)
                           {
                               foundIndex = i;
                               break;
                           }
                       }

                       if (foundIndex != -1)
                       {
                           Console.WriteLine($"Grade of student {stdName[foundIndex]} is {stdGrade[foundIndex]} ");
                           Console.WriteLine("Enter Grade to update:");
                           int newGrade = int.Parse(Console.ReadLine());

                           if (newGrade < 0 || newGrade >= 100)
                           {
                               Console.WriteLine("Invalid grade");
                               return;
                           }

                           stdGrade[foundIndex] = newGrade;
                           Console.WriteLine($"student {stdName[foundIndex]} grade been update to: {stdGrade[foundIndex]}");
                       }
                       else { 
                           Console.WriteLine("Student not Found!");
                       }
                   break;
                   //End case 2


                   case 3: //view
                       if (tempStdNumber == 0)
                       {
                           Console.WriteLine("No students yet!");
                           return;
                       }
                       Console.WriteLine("Student Name \t Grade");
                       Console.WriteLine("---------------------");
                       for (int i = 0; i < tempStdNumber; i++)
                       {
                           Console.WriteLine($"{stdName[i]} \t\t {stdGrade[i]}");
                       }
                       break;
                       //END case 3

                   case 4: //statistics
                       if (tempStdNumber == 0)
                       {
                           Console.WriteLine("No students yet!");
                           return;
                       }
                       // Array method will count all elemnt, it will not work corcatly
                       //Console.WriteLine($"Avrage Grade {stdGrade.Average()}");
                       //Console.WriteLine($"Hights Grade {stdGrade.Max()}");
                       //Console.WriteLine($"Lowest Grade {stdGrade.Min()}");

                       int totalGrade = 0;

                       //for Min/Max to work we need to assign this value with first index value of array stdGrade
                       //the comparison will be from first index value until it's find value high/low than assign one
                       int highGrade = stdGrade[0], loweGrade = stdGrade[0];
                       string lowStd = stdName[0], highStd = stdName[0];

                       for (int i = 0; i < tempStdNumber; i++)
                       {                            
                           totalGrade += stdGrade[i];

                           if (stdGrade[i] > highGrade)
                           {
                               highGrade = stdGrade[i];
                               highStd = stdName[i];
                           }

                           if (stdGrade[i] < loweGrade)
                           {
                               loweGrade = stdGrade[i];
                               lowStd = stdName[i];
                           }
                       }
                       double avgGrade = (double)totalGrade / tempStdNumber;

                       Console.WriteLine("______Statistics______");
                       Console.WriteLine($"Average Grade: {avgGrade}");
                       Console.WriteLine($"Highest Grade: {highGrade} | {highStd}");
                       Console.WriteLine($"Lowest Grade:  {loweGrade} | {lowStd}");

                       //double avg = stdGrade.Sum() / stdGrade.Length;
                       break;

                   case 5:
                       Console.WriteLine("Exit");
                       break;

                   default:
                       Console.WriteLine("Enter from 1 ~ 5");
                       break;
               }
            }while (choiseStd != 5);


            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion





        }
    }

}
