namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Number = [99999, 88888, 77777];
            //string[] Name = ["N1", "N2","N3"];

            //Console.WriteLine($"Customer Name {Name[0]} ," + $"The Number {Number[0]}");

            //int[] stdGrade = new int[3]; // array size 3 index
            //Number[0] = 55555; // assign by INDEX

            ////Condtion
            //// v2 ignore
            //string perfect = (Number[0] >= 0) ? "Number in system" : "Number not found in system";


            // any number divied by 2 with no reminder is EVEN number
            int[] num = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            if (num % 2 == 0) { Console.WriteLine($"Ëven Number {num}") };
            else { Console.WriteLine($"Odd Number {num}") };


        }
    }
}
