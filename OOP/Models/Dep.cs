using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models
{
    public class Dep
    {
        public int depId;
        public string depName;
        public string depDescription;
        //string depDescription;    //defualt private 



        // Void return nothing, DataType return value and must have (return;)
        public string firstName;
        public string lastName;

        public void Greating1()
        {
            Console.WriteLine("Hello");
        }
        public string Greating2(){
            return $"Welcome {this.firstName} {this.lastName} ";
        }

        public static string Greating3() { return "Static"; }

        public static void Swap(ref int i, ref int j) { 
            // Emp.Swap(ref a, ref b)
            int temp = i;
            i = j;
            j = temp;
        }

        //funcation with one value return
        public bool IsEven(int i) => i % 2 == 0;
        public bool IsEvenIF(int x) {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public void SwapNoRef( int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void SwapOut(ref int a, ref int b, out int M)
        {
            int temp = a;
            a = b;
            b = temp;
            M = a * b;
        }

        //// with => and without it 
        public int SquareSingleLine(int x) => x * x;
        public int SquareAsBlock(int x)
        {
            return x * x;
        }


    }

}
