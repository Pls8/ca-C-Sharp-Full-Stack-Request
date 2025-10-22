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


            #region Emp.cs OOP _ class call _ L 4 pt3 
            //////////////////////////////////////////////////////////////////
            ////                𝙊𝙊𝙋 _ 𝘾𝙡𝙖𝙨𝙨 𝘾𝙖𝙡𝙡 _ 𝙇 4 𝙋𝙏3 
            //_______________________________________________________________ S T A R T
            //Emp emp = new Emp();
            //emp.empId = 1;
            //emp.name = "test"; 

            Emp[] emp = new Emp[2]; // assing class to array?
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Emp(); //THE MOST IPMORTANT LINE, must emp init first in memory
                Console.WriteLine("Name ");
                emp[i].name = Console.ReadLine();
                Console.WriteLine("ID ");
                emp[i].empId = int.Parse(Console.ReadLine());
                Console.WriteLine("Wages ");
                emp[i].wag = decimal.Parse(Console.ReadLine());
                Console.WriteLine("hours");
                emp[i].hrs = double.Parse(Console.ReadLine());

                Console.WriteLine($"Your name {emp[i].name} and ID: {emp[i].empId}");
            }

            //change var to class name Emp it will work
            foreach (Emp item in emp)
            {
                //decimal netSalary = (item.wag * (decimal)item.hrs) - (item.wag * (decimal)(item.hrs Emp.taX); // this converation for wages use
                decimal netSalary = (item.wag * (decimal)item.hrs) - (item.wag * (decimal)(item.hrs * Emp.taX));
                // Emp.taX; to call constant use class name
                Console.WriteLine($"Name: {item.name} | ID: {item.empId} | Net Salary: {netSalary}");
            }


            //------------------------------------------------------------------------------------------------- E N D
            //                       OOP _ L 4 PT3 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion






            #region Department Class Call

            ////Department Class Call
            Dep dep = new Dep();
            // depId, depName, depDescroption are Instance
            dep.depId = 1;
            dep.depName = "IT";
            dep.depDescription = "Spec of Software";


            //Method
            Dep depNameGreat = new Dep();
            depNameGreat.firstName = "test";
            depNameGreat.lastName = "TEST";
            // call Method,   Console.WriteLine(depNameGreat.Greating());
            //string methodCall2 = depNameGreat.Greating1();
            string methodCall = depNameGreat.Greating2();
            Console.WriteLine(methodCall);

            //this will not swap since it pass only value
            //use ref to pass refrence(location)
            Dep RefOutWithOut = new Dep();
            int a = 3, b = 4, MultiSwap;
            RefOutWithOut.SwapNoRef(a, b);
            Console.WriteLine($"Swap A {a} NO");
            Console.WriteLine($"Swap B {b} NO");

            RefOutWithOut.SwapRef(ref a, ref b);
            Console.WriteLine($"Swap A {a} YES");
            Console.WriteLine($"Swap B {b} YES");

            RefOutWithOut.SwapOut(ref a, ref b, out MultiSwap);
            Console.WriteLine($"use refrence in a & b to get out multiblication {MultiSwap}");




            //velue type = stack
            //refernce type = stack/heap



            //TryParse is true / false
            //Don't have to use REF, use OUT

            // 
            int sumRes, mulRes;
            SumMult(a, b, out sumRes, out mulRes);
            Console.WriteLine(sumRes);
            Console.WriteLine(mulRes);
            static void SumMult(int x, int y, out int S, out int M)
            {
                S = x + y;
                M = x * y;
            }

            // method signature, same class with diffrent input type or process? 
            // void Print(int x)         
            // void Print(string name)  
            int x = 2;
            Dep singleLineAndNot = new Dep();
            Console.WriteLine(singleLineAndNot.SquareSingleLine(x));
            Console.WriteLine(singleLineAndNot.SquareAsBlock(x));

            // const / static is relate to CLASS it self, no need object to call
            // VOID use if no return need
            // instance > assign class to variable Emp emp = new Emp(), object ownership | instance emp.Show()
            // static > class static by class, class ownership                           | class    Emp.Show()


            // ^const is fixed value & cannot be changed and shred to all object in class
            // ^static is fixed value but can be changed similer to const shared it value to all object in class

            #endregion








            //________________________________________________________________ OOP Animal Class
            AnimalClass cat = new CatClass();
            CatClass cat1 = new CatClass();
            AnimalClass dog = new DogClass();
            AnimalClass eagle = new EagleClass();
            EagleClass duck = new DuckClass();
            EagleClass falcon = new FalconClass();


            Console.WriteLine($"cat: {cat.animalInfo()}");
            Console.WriteLine($"dog: {dog.animalInfo()}");
            Console.WriteLine($"egal: {eagle.animalInfo()}");
            Console.WriteLine($"falcon: {falcon.animalInfo()}");
            Console.WriteLine($"duck: {duck.animalInfo()}");


            //File Structure
            //... /           
            //├── Models /
            //│   ├── AnimalClas.cs
            //│   ├── CatClass.cs
            //│   ├── EgleClass.cs
            //|   ├── FalconClass.cs
            //│   └── DuckClass.cs
            //│
            //└── Program.cs

            //Console.WriteLine($"cat: {cat1.thisCatClass()}");
            //________________________________________________________________ OOP Animal Class  E N D









            //_____________________________________________________ Override & Virtual
            MainVirtualClass mainSub1 = new SubOverrideClass();
            mainSub1.sayHello();







        }
    }

    // ._______________________________Note: creating CLASS________________________________________.
    // | select Working Folder > Create Folder Name Models > right.Click Add > Class               |
    // | Change internal > public, Make sure the name start with upper case                        |
    // | while you can create class internally but not recomanded!                                 |
    // | public class Emp                                                                          |
    // | {   // it will be created outside [ internal class Program{},  static void Main(){} ]     |
    // |     //if public dose not mention it will privte as default                                |
    // |     public const double TAX = .03;                                                        |
    // | }                                                                                         |
    //  \-----------------------------------------------------------------------------------------/

}
