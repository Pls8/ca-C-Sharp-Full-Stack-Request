namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Number = [99999, 88888, 77777];
            string[] Name = ["N1", "N2","N3"];

            Console.WriteLine($"Customer Name {Name[0]} ," + $"The Number {Number[0]}");

            int[] stdGrade = new int[3]; // array size 3 index
            Number[0] = 55555; // assign by INDEX

            //Condtion 
            string perfect = (Number[0] >= 0) ? "Number in system" : "Number not found in system";

            


        }
    }
}
