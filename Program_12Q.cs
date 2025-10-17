using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;

namespace hw
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //________________________________________________________________________________________1
            Console.WriteLine("//Q1 - Write a C# program to print the first 10 even numbers.");            
            //any number divied by 2 with no reminder is EVEN number, python way
            //by doing iteration foreach number in array_number
            int[] number = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            foreach (int num in number) { 
                if(num % 2 == 0){ 
                    Console.WriteLine($"{num} is even");
                    //else { Console.WriteLine($"{num} is odd");
                }
            }
            Console.WriteLine();


            //________________________________________________________________________________________2
            Console.WriteLine("//Q2 - Write a C# program to print the first 15 Fibonacci numbers.");
            //Fibonacci number are sum if two previos number
            //Fn = Fn-1 + Fn-2
            //start from 0, 1, ? | 0+1=1 [0,1,1] | 1+1+2 [0,1,1,2] | 1+2=3 [0,1,1,2,3, .....]
            int num1 = 0, num2 = 1, num3;
            Console.WriteLine("15 Fibonacci numbers ");
            for (int i = 0; i < 15; i++) {
                num3 = num1 + num2; // first must assign value to num3 
                num1 = num2;  // do shift number
                num2 = num3;
                Console.WriteLine($"_{i+1} : {num3}");
            }
            Console.WriteLine();


            //________________________________________________________________________________________3
            Console.WriteLine("//Q3 - Write a C# program to print the first 10 powers of 2");            
            //using pre-define funcation math.pow(number,power)
            Console.WriteLine("10 Number of Powers 2 ");
            for (double i = 1; i <= 10; i++)
            {
                double x = i;
                x = Math.Pow(x, 2);
                Console.WriteLine($"_{i} : {x}");
            }
            Console.WriteLine();



            //________________________________________________________________________________________4
            Console.WriteLine("//Q4 -Write a C# program to find the largest number in an array of integers");
            int[] numQ4 = [3, 4, 6, 2, 1, 7, 9];

            //Using max pre-define funcation .max()
            int max = numQ4.Max();
            Console.WriteLine($"MAX Number by max funcation {max}");

            //using itteration loop to check each number in array that comber each value 
            //if it's grater than or equal variable 'largeNum' than store it in each iteration 
            int largeNum = 0;
            foreach (int n in numQ4)
            {
                if (n >= largeNum)
                {
                    largeNum = n;
                }                
            }
            Console.WriteLine($"The large number by foreach method : {largeNum}");
            Console.WriteLine();



            //________________________________________________________________________________________5
            Console.WriteLine("//5-Write a C# program to print a pattern of stars.(Square)");
            //this is simple one, from what i see in source they use two itreation at same time
            //forLoop inside andother forLoop
            for (int i = 0; i < 4 ; i++)
            {
                Console.WriteLine("********");
            }
            Console.WriteLine();




            //________________________________________________________________________________________6
            Console.WriteLine("6-Write a C# program to check if a given number is prime or not.");
            //prime numbers that can be divided by 1 and it self with no remiander
            //any number that can be divided other than 1 and it self is composite number

            //Console.WriteLine("Enter Number to check if Prime Or Not: ");
            //int primeNum = Convert.ToInt32(Console.ReadLine());

            //from ByteHide website they explain that any number less than or equal <= 1 will be excluded
            //and number 2 is only the even prime number, so start chek next to 2 
            int[] parray= [7,32,45,14,13,45,67,13,15,997];
            foreach (int n in parray) {
                int i;
                for (i = 2; i * i <= n; i++) {
                    if (n % i == 0) {
                        // if remainder is not 1 or number is self then it is not prime, I guess?
                        Console.WriteLine($"{n} is not a prime number");
                        break; //without break all number in list will consider as prime
                    }
                    //else { Console.WriteLine($"{n} prime number"); }
                    
                }
                if (i * i > n){
                     // i * i is like √49 = 7 x 7 
                     //at the time n become 7 which increace by one it will be 7 x 7 
                    Console.WriteLine($"{n} is prime number");
                }
            }
            Console.WriteLine();



            //________________________________________________________________________________________7
            Console.WriteLine("7-Write a C# program to calculate the sum of the digits of a given integer");
            //base 10 (decimal) > digit % 10 | digit / 10, don't understand why like this way!

            int digit = 4114;
            string digitToString = digit.ToString(); // '4' '1' '2' '4'
            int[] numArray = new int[digitToString.Length];

            for (int i = 0; i < digitToString.Length; i++)
            {
                numArray[i] = digitToString[i] - '0';
                //Convert each char digit to int, from what i understand - '0' is must in C# 
                //ASCII (and Unicode), characters '0' to '9' have consecutive numeric codes
            }

            int sumDigit = 0;
            foreach (int n in numArray) { 
                sumDigit = sumDigit + n; 
            }
            Console.WriteLine("Sum of digit " + digit + " is " + sumDigit);

            //Array way
            //int[] digitArray = [4, 1, 1, 4];
            //foreach (int n in digitArray) { 
            //    sumDigit = sumDigit + n; 
            //}
            //Console.WriteLine("Sum of digit " + sumDigit);
            Console.WriteLine();




            //________________________________________________________________________________________8
            Console.WriteLine("//8-Write a C# program to reverse a string");
            //Console.WriteLine("Enter String To be reversed: ");
            //string firstStr = Console.ReadLine();
            // the idea is to use indexing in such way start from last char
            // T E S T
            // 0 1 2 3 
            string mStr = "TEST";
            string reversStr = ""; // act as place holder for revrsed string
            for (int i = mStr.Length - 1; i >= 0; i--) {
                // 4 - 1 = 3 ,i > = going backward until index 0 which is first character

                reversStr = reversStr + mStr[i];
                //this line will keep add char index to reversStr at position [i]
            }
            Console.WriteLine("The Reversed String: " + reversStr);
            Console.WriteLine();




            //________________________________________________________________________________________9
            Console.WriteLine("9-Write a C# program to count the number of vowels in a given string.");
            //English alphabet, vowels are the following letters
            //vowel is a speech sound pronounced without any stricture in the vocal tract
            //A, E, I, O, U     |    a, e, i, o, u
            //i don't understand any thing about this
            //*but it seem that is to go in each char of string and combare it if it's equal any of vowels char

            //Console.WriteLine("Enter String To count Vowels letter: ");
            //string vowStr = Console.ReadLine();
            string vowStr = "makeen";
            int vowCount = 0;
            foreach (char c in vowStr) {
                // use '' single one for char and, used one |or to make condition going
                // regardless of the first operand value
                if ( c == 'a' | c == 'e' | c == 'i' | c == 'o' | c == 'u') { 
                    vowCount = vowCount + 1;
                }
            }
            Console.WriteLine($"Number of Vowels char in {vowStr} is: {vowCount}");
            Console.WriteLine();




            //________________________________________________________________________________________10
            Console.WriteLine("//10-Write a C# program to find the sum of all even numbers from 1 to 100");
            //same as Q1 but this time defin int variable that will hold sum of all even number
            //if it match the condition of mod, at the end of forLoop it will run the outside
            //forLoop CW with var evenNumSum that hold all the sum of even
            int evenNumSum = 0;
            for (int i = 0; i <= 100; i++) { 
                if (i % 2 == 0) { evenNumSum = evenNumSum + i; }
            }
            Console.WriteLine($"The sum of even number {evenNumSum}");
            Console.WriteLine();




            //________________________________________________________________________________________11
            Console.WriteLine("//11-Write a C# program to find the factorial of a number");
            //factorial product of all positive descending integers of that number
            // 4! = 4 x 3 x 2 x 1 = 24
            // facrNum to 1 , when 1 x 1 = 1
            int numberToBeFact = 4, factNum = 1;            
            for (int i = 1; i <= numberToBeFact; i++){
                // as long i less than or equle given number it will loop and increase by one 
                // 1 <= 4 yse factNum = 1x1 | 2 <= 4 yes factNum = 2x1 | 3 <= 4 yes factNum = 2x3 
                // 4 <= 4 yes factNum = 6x4 | 5 <= 4 no
                factNum = factNum * i;
            }
            Console.WriteLine($"Factorial of {numberToBeFact} is: {factNum}");
            Console.WriteLine();




            //________________________________________________________________________________________12
            Console.WriteLine("12-Write a C# program to sort an array of integers in ascending order");
            //                  0  1  2   3   4
            int[] unSortArry = [4, 9, 2, 42, 12];

            //useing predefined funcation
            Console.WriteLine("Using Array.Sort method");
            Console.WriteLine("Unsorted array");
            foreach (int i in unSortArry) { Console.WriteLine(" " + i); }

            Console.WriteLine("Sorted array");
            Array.Sort(unSortArry);
            foreach (int i in unSortArry) { Console.WriteLine(" " + i); }            
            Console.WriteLine();


            //something like this in Java, without using method
            //0 to 4 , .Length = 5 but less than < will make it index to 4
            //first forLoop act as postion/pointer
            Console.WriteLine("Without using Array.Sort method");
            for (int i = 0; i < unSortArry.Length; i++){
                // first ittration 0 minInex is 0 = 4
                int minIndex = i;

                //second forLoop act as scearch to find small value in array
                //Is the current element at position j smaller than the one at minIndex?
                //array[index] will give the value at that index
                for (int j = i + 1; j < unSortArry.Length; j++){
                    if (unSortArry[j] < unSortArry[minIndex]){
                        // update minIndex condtion of it is a small number
                        minIndex = j;
                    }
                }
                //this will store first number in temp at index minIndex
                int temp = unSortArry[minIndex];
                //the number at minInex been assign to number at index i = 0  first index
                unSortArry[minIndex] = unSortArry[i];
                unSortArry[i] = temp;
                Console.WriteLine(temp);
            }

        }
    }
}
