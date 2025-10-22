using ConsoleApp12_10_2025.Models;
using ConsoleApp12_10_2025.Models.oop_Q7;
using ConsoleApp12_10_2025.Models.oop_Q8;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp12_10_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝘽𝙤𝙤𝙠 𝘾𝙡𝙖𝙨𝙨 𝙎𝙮𝙨𝙩𝙚𝙢 (𝙀𝙖𝙨𝙮)                  OOP-2 Assignment
            //////////////////////////////////////////////////////////////////
            ////           𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝘽𝙤𝙤𝙠 𝘾𝙡𝙖𝙨𝙨 𝙎𝙮𝙨𝙩𝙚𝙢 
            //_______________________________________________________________ S T A R T

            //                                                              Models / BookClass.cs
            Console.WriteLine("________ Book System __________");
            BookClass book1 = new BookClass(1234, "C#", "Name1", 2015);
            BookClass book2 = new BookClass(6789, "python", "Name2", 2017);
            BookClass book3 = new BookClass(9876, "java", "Name3", 1989);


            Console.WriteLine($"Book 1: {book1.PrintBookInfo()} | Older/Newer? {book1.isBookOlder()}");
            Console.WriteLine($"Book 2: {book2.PrintBookInfo()} | Older/Newer? {book2.isBookOlder()}");
            Console.WriteLine($"Book 3: {book3.PrintBookInfo()} | Older/Newer? {book3.isBookOlder()}");



            //book1.PrintBookInfo(1234, "C#", "Name1", 2015); // since passing in object is engh
            //------------------------------------------------------------------------------------------------- E N D
            //                       𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝘽𝙤𝙤𝙠 𝘾𝙡𝙖𝙨𝙨 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion










            //////////////////////////////////////////////////////////////////
            ////           𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙏𝙧𝙖𝙘𝙠𝙚𝙧 
            //_______________________________________________________________ S T A R T

            //                                                              Models / StudentClass.cs
            Console.WriteLine("________ Student Grade tracker __________");
            StudentClass std1 = new StudentClass(1, "Name1");
            StudentClass std2 = new StudentClass(2, "Name2");
            StudentClass std3 = new StudentClass(3, "Name3");

            //don't understand the Q, in which each student has it own grade for Subjects for one student or what the deal here?
            std1.AddGrade(65);
            std1.AddGrade(89);
            std1.AddGrade(78);

            Console.WriteLine($"avrage STD1: {std1.CalculateAvg()}");
            Console.WriteLine($"STD1 Report {std1.PrintStdReport()}");



            //------------------------------------------------------------------------------------------------- E N D
            //                      𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙏𝙧𝙖𝙘𝙠𝙚𝙧  
            ///////////////////////////////////////////////////////////////////////////////////////////////////














            //////////////////////////////////////////////////////////////////
            ////           𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙑𝙚𝙝𝙞𝙘𝙡𝙚 𝙃𝙞𝙚𝙧𝙖𝙧𝙘𝙝𝙮 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T
            //                                                              Models / VehicleClass.cs
            //                                                              Models / CarClass.cs
            //                                                              Models / TruckClass.cs
            Console.WriteLine("________ Vehicle system __________");
            VehicleClass v1 = new VehicleClass("Name", "Name", 2009);
            Console.WriteLine($"Main vehicle: {v1.DisplayInfo()}");

            CarClass car1 = new CarClass("Name1", "Name1", 2014, 4);

            Console.WriteLine($"Car class: {car1.DisplayInfo()}");

            TruckClass truck1 = new TruckClass("Name2", "Name2", 2018, 1200);
            Console.WriteLine($"Truck class: {truck1.DisplayInfo()}");


            //------------------------------------------------------------------------------------------------- E N D
            //                       𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙑𝙚𝙝𝙞𝙘𝙡𝙚 𝙃𝙞𝙚𝙧𝙖𝙧𝙘𝙝𝙮 𝙎𝙮𝙨𝙩𝙚𝙢  
            ///////////////////////////////////////////////////////////////////////////////////////////////////














            //////////////////////////////////////////////////////////////////
            ////            𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙀-𝘾𝙤𝙢𝙢𝙚𝙧𝙘𝙚 𝙊𝙧𝙙𝙚𝙧 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T


            //                                                              Models / ProductClass.cs
            //                                                              Models / OrderClass.cs
            Console.WriteLine("___________/ Order System \\___________");

            ProductClass p1 = new ProductClass("Smart Phone", 300, 56);
            ProductClass p2 = new ProductClass("Watchs", 120, 25);

            OrderClass order1 = new OrderClass("00-001");

            order1.addProduct(p1);
            order1.addProduct(p2);

            order1.pdDisplayInfo();


            //------------------------------------------------------------------------------------------------- E N D
            //                        𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙀-𝘾𝙤𝙢𝙢𝙚𝙧𝙘𝙚 𝙊𝙧𝙙𝙚𝙧 𝙎𝙮𝙨𝙩𝙚𝙢  
            ///////////////////////////////////////////////////////////////////////////////////////////////////










            //////////////////////////////////////////////////////////////////
            ////            𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝘼𝙣𝙞𝙢𝙖𝙡 𝙎𝙤𝙪𝙣𝙙 𝙎𝙞𝙢𝙪𝙡𝙖𝙩𝙞𝙤𝙣
            //_______________________________________________________________ S T A R T
            //                                                              Models / AnimalClass2.cs
            //                                                              Models / CatClass2.cs
            //                                                              Models / DogClass2.cs
            //                                                              Models / CowClass2.cs

            Console.WriteLine("___________  Animal Sound ___________");

            AnimalClass2 catT = new CatClass2("This is Cat");
            AnimalClass2 dogG = new DogClass2("This is Dog");
            AnimalClass2 cowW = new CowClass2("This is Cow");

            //sound
            Console.WriteLine("Make sound method override");
            catT.MakeSound();
            dogG.MakeSound();
            cowW.MakeSound();

            //polymorphism with a array  >---------------------------------------//\
            Console.WriteLine("polymorphism array");                              //|
            AnimalClass2[] animals2 = new AnimalClass2[3];                        //|
            int anmlIndeX = 0;                                                    //|
                                                                                  //|
            //add animals                                                         //|
            animals2[anmlIndeX++] = new CatClass2("This is Cat 2");               //|
            animals2[anmlIndeX++] = new DogClass2("This is Dog 2");               //|
            animals2[anmlIndeX++] = new CowClass2("This is Cow 2");               //|
                                                                                  //
            //  v----------------------------------------------------------------//
            Console.WriteLine("Loop sound");
            for (int i = 0; i < anmlIndeX; i++)
            {
                animals2[i].MakeSound();
            }



            //------------------------------------------------------------------------------------------------- E N D
            //                        𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝘼𝙣𝙞𝙢𝙖𝙡 𝙎𝙤𝙪𝙣𝙙 𝙎𝙞𝙢𝙪𝙡𝙖𝙩𝙞𝙤𝙣 
            ///////////////////////////////////////////////////////////////////////////////////////////////////












            //////////////////////////////////////////////////////////////////
            ////          OOP Assignment 6: Bank Account Management System
            //_______________________________________________________________ S T A R T
            //                                                              Models / BankAccountMangment.cs

            Console.WriteLine("_______________ Bank account managment system ___________________");

            BankAccountMangment act1 = new BankAccountMangment("AC001","Name1",1000);
            BankAccountMangment act2 = new BankAccountMangment("AC002", "Name2", 100);

            Console.WriteLine("-- account created --");
            act1.displayAccountInfo();
            act2.displayAccountInfo();

            Console.WriteLine("-- Transaction --"); //transactions
            act1.Deposit(50);
            act2.Deposit(230);


            //accounts display
            BankAccountMangment.showTotalAccount();


            Console.WriteLine("Error handling Test!");
            act1.withDraw(1090);
            BankAccountMangment act3Test = new BankAccountMangment("", "invalid", -1);


            //________________________________________Note____________________________________________
            // it can be implemnt with try catch in both side (Main Class/ Subclass ) OR IF ELSE,     |
            // just leaving this for refrence                                                         |
            //try                                                                                     |
            //{                                                                                       |
            //    act1.withDraw(1090);                                                                |
            //}                                                                                       |
            //catch (Exception ex)                                                                    |
            //{                                                                                       |
            //    Console.WriteLine($"error withdraw more than balance {ex.Message}");                |
            //}                                                                                       |
            //                                                                                        |
            //                                                                                        |
            //try                                                                                     |
            //{                                                                                       |
            //    BankAccountMangment act3Test = new BankAccountMangment("", "invalid", -1);          |
            //}                                                                                       |
            //catch (Exception ex)                                                                    |
            //{                                                                                       |
            //                                                                                        |
            //    Console.WriteLine($"error empty name {ex.Message}");                                |
            //}                                                                                       |
            //----------------------------------------------------------------------------------------/

            //------------------------------------------------------------------------------------------------- E N D
            //                       OOP Assignment 6: Bank Account Management System 
            ///////////////////////////////////////////////////////////////////////////////////////////////////










            //////////////////////////////////////////////////////////////////
            ////         𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙎𝙢𝙖𝙧𝙩 𝙃𝙤𝙢𝙚 𝘿𝙚𝙫𝙞𝙘𝙚 𝘾𝙤𝙣𝙩𝙧𝙤𝙡
            //_______________________________________________________________ S T A R T
            //                                                              Models / oop_Q7 /...

            Console.WriteLine("_____________ Home Device control system ____________");
            LightClass light1 = new LightClass("light 1");
            ThermostatClass thermo1 = new ThermostatClass("Thermo 1");

            //controller
            ControllereClass cntrol = new ControllereClass(4);

            cntrol.addDevice(light1);
            cntrol.addDevice(thermo1);

            //controller status
            Console.WriteLine($"Controller has {cntrol.getDeviceCount()}");

            Console.WriteLine("Opration");
            cntrol.showDeviceStatus();
            cntrol.onAllDevice();
            cntrol.showDeviceStatus();


            //device opration
            light1.setBrightLevel(4);
            light1.inrecsBrightLevel(); // by 1
            thermo1.setThermoLevel(30);
            thermo1.inrecsTemp();   // by 1


            //control each device by index
            Console.WriteLine("Control device by index");
            cntrol.controlDeviceIndex(0);

            cntrol.offAllDevice();
            cntrol.showDeviceStatus();

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙎𝙢𝙖𝙧𝙩 𝙃𝙤𝙢𝙚 𝘿𝙚𝙫𝙞𝙘𝙚 𝘾𝙤𝙣𝙩𝙧𝙤𝙡 
            ///////////////////////////////////////////////////////////////////////////////////////////////////











            //////////////////////////////////////////////////////////////////
            ////         𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙀𝙢𝙥𝙡𝙤𝙮𝙚𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 𝙬𝙞𝙩𝙝 𝙋𝙤𝙡𝙮𝙢𝙤𝙧𝙥𝙝𝙞𝙨𝙢 
            //_______________________________________________________________________________ S T A R T
            //                                                              Models / oop_Q8 /...
            Console.WriteLine("_______ Employee Managment System _________");

            //adding employee
            EmloyeeClass empOOP1 = new EmloyeeClass("EMP 1", 450);

            //manger
            ManagerClass mngr2 = new ManagerClass("MNGR 2", 900, "HR");

            //dev
            DeveloperClass dev1 = new DeveloperClass("DEV 1", 600, "python");


            //adding emp to HR 
            HRClass hrC = new HRClass();

            hrC.addEmplHR(empOOP1);
            hrC.addEmplHR(mngr2);
            hrC.addEmplHR(dev1);


            //polymorphism
            hrC.displayAllEmpl();

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝙊𝙊𝙋 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙀𝙢𝙥𝙡𝙤𝙮𝙚𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 𝙬𝙞𝙩𝙝 𝙋𝙤𝙡𝙮𝙢𝙤𝙧𝙥𝙝𝙞𝙨𝙢  
            ///////////////////////////////////////////////////////////////////////////////////////////////////




















            //Class Draw
            // +-----------------------------+ 
            // |        AnimalClass          |  ← Base Class
            // +-----------------------------+ 
            // | - nameAnimal : string       |  ← private field or property
            // | - typeAnimal : string       | 
            // | - genderAnimal : string     | 
            // +-----------------------------+ 
            // | + animalInfo()              |  ← method
            // +-----------------------------+
            //             ▲
            //             |
            //  +-------------------------+        +---------------------------+
            //  |        DogClass         |        |        CatClass           | 
            //  +-------------------------+        +---------------------------+
            //  | + ThisIsDog()           |        | + ThisIsCat()             | 
            //  +-------------------------+        +---------------------------+
            //       ↑
            //       |
            //  (sealed class)

            // ✳ Abstract class: can't be directly instantiated
            // ✳ Sealed class: can't be inherited further
            // ✳ Properties: control access to private data using get/set



        }
    }

}
