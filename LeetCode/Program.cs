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
            


            #region 𝙍𝙤𝙢𝙖𝙣 𝙩𝙤 𝙄𝙣𝙩𝙚𝙜𝙚𝙧 (𝙇𝙚𝙚𝙩𝘾𝙤𝙙𝙚)
            //////////////////////////////////////////////////////////////////
            ///             13.𝙍𝙤𝙢𝙖𝙣 𝙩𝙤 𝙄𝙣𝙩𝙚𝙜𝙚𝙧 (𝙇𝙚𝙚𝙩𝘾𝙤𝙙𝙚)
            //_______________________________________________________________ S T A R T
            //// using string insted of char is best to itratet in each letter as if it's array
            //Console.Write("Enter Roman char: I | V | X | L | C | D | M \n");
            //string? input1 = Console.ReadLine().ToUpper();
            //string romanIn = string.IsNullOrEmpty(input1) ? "Invalid input!" : input1;
            //int total = 0;
            //for (int i = 0; i < romanIn.Length; i++)
            //{
            //    int index0 = 0, index1 = 0;

            //    // Get value of current Roman char
            //    if (romanIn[i] == 'I') { index0 = 1; }
            //    else if (romanIn[i] == 'V') { index0 = 5; }
            //    else if (romanIn[i] == 'X') { index0 = 10; }
            //    else if (romanIn[i] == 'L') { index0 = 50; }
            //    else if (romanIn[i] == 'C') { index0 = 100; }
            //    else if (romanIn[i] == 'D') { index0 = 500; }
            //    else if (romanIn[i] == 'M') { index0 = 1000; }

            //    // Get value of next Roman char, if there
            //    if (i + 1 < romanIn.Length){
            //        if (romanIn[i + 1] == 'I') { index1 = 1; }
            //        else if (romanIn[i + 1] == 'V') { index1 = 5; }
            //        else if (romanIn[i + 1] == 'X') { index1 = 10; }
            //        else if (romanIn[i + 1] == 'L') { index1 = 50; }
            //        else if (romanIn[i + 1] == 'C') { index1 = 100; }
            //        else if (romanIn[i + 1] == 'D') { index1 = 500; }
            //        else if (romanIn[i + 1] == 'M') { index1 = 1000; }
            //    }

            //    //___________________________________Note: Roman idea is whice one first____________________________.
            //    // any Roman char smaller than the next Roman char like I & V it will be suptraction IV > 1 - 5 = 4 |
            //    // and in revers manner V first then I > 5 + 1 = 6                                                  |
            //    // Input IV index0 will have I, index1 will have V                                                  |
            //    // and since it for loop it will itrate on each string index  and sup/add to total                  |
            //    //--------------------------------------------------------------------------------------------------/

            //    if (index0 < index1)
            //    {
            //        total -= index0;
            //    }
            //    else
            //    {
            //        total += index0;
            //    }
            //}
            //Console.WriteLine($"Result: {total}");

            //------------------------------------------------------------------------------------------------- E N D
            //                          13.𝙍𝙤𝙢𝙖𝙣 𝙩𝙤 𝙄𝙣𝙩𝙚𝙜𝙚𝙧 (𝙇𝙚𝙚𝙩𝘾𝙤𝙙𝙚)
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion


        }
    }


}
