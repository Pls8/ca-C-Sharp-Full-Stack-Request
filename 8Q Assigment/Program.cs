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
            ////_________________Note about may be null string________________
            //// this the only working way i found to FiX NULL ERROR          |
            //// if ( string.IsNullOrEmpty(stringInput) ){                    |
            //// Console.WriteLine("Invalid input!");                         |
            //// return; }                                                    |
            ////--------------------------------------------------------------



            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙈𝙤𝙫𝙞𝙚 𝙏𝙝𝙚𝙖𝙩𝙧𝙚 𝙎𝙚𝙖𝙩 𝘽𝙤𝙤𝙠𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ///         𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙈𝙤𝙫𝙞𝙚 𝙏𝙝𝙚𝙖𝙩𝙧𝙚 𝙎𝙚𝙖𝙩 𝘽𝙤𝙤𝙠𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T          
            //char[,] seats = new char[5, 5];
            //for (int row = 0; row < 5; row++) {
            //    for (int col = 0; col < 5; col++) {
            //        seats[row, col] = 'A';
            //    }
            //}
            //Console.WriteLine("1.Seat Avaliable | 2.Book a Seats | 3.Cancel Booking | 4.show seats count");
            //int menuOpt = int.Parse(Console.ReadLine());

            //switch (menuOpt)
            //{
            //    case 1:
            //        Console.WriteLine("   0 1 2 3 4");
            //        Console.WriteLine("____________");
            //        for (int row = 0; row < 5; row++)
            //        {
            //            Console.Write(row + "| "); //WriteLine will make new line "Enter"
            //            for (int col = 0; col < 5; col++)
            //            {
            //                Console.Write($"{seats[row, col]} ");
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    default:
            //        break;
            //}

            //do {


            //    Console.WriteLine("Enter Row Number: ");
            //    int rowIn = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Column Number: ");
            //    int colIn = int.Parse(Console.ReadLine());

            //    if (seats[rowIn, colIn] == 'X') {
            //        Console.WriteLine("Seat Alrady taking!");
            //    } else {
            //        seats[rowIn, colIn] = 'X';
            //    }


            //} while (true);



            //    char[,] seats = new char[5, 5];

            //    // Initialize all seats to 'A' (Available)
            //    for (int row = 0; row < 5; row++)
            //    {
            //        for (int col = 0; col < 5; col++)
            //        {
            //            seats[row, col] = 'A';
            //        }
            //    }

            //    while (true)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("=== Movie Theater Seat Booking ===");
            //        DisplaySeats(seats);

            //        Console.Write("Enter row (0 to 4): ");
            //        int row = int.Parse(Console.ReadLine());

            //        Console.Write("Enter column (0 to 4): ");
            //        int col = int.Parse(Console.ReadLine());

            //        // Check if seat is already booked
            //        if (seats[row, col] == 'X')
            //        {
            //            Console.WriteLine(" Seat already booked. Try another one.");
            //        }
            //        else
            //        {
            //            seats[row, col] = 'X';
            //            Console.WriteLine("Seat booked successfully!");
            //        }

            //        Console.Write("Book another seat? (y/n): ");
            //        string again = Console.ReadLine().ToLower();
            //        if (again != "y") break;
            //    }

            //    Console.WriteLine("Final seat layout:");
            //    DisplaySeats(seats);

            //    static void DisplaySeats(char[,] seats)
            //    {
            //        Console.WriteLine("   0 1 2 3 4");
            //        for (int row = 0; row < 5; row++)
            //        {
            //            Console.Write(row + ": ");
            //            for (int col = 0; col < 5; col++)
            //            {
            //                Console.Write(seats[row, col] + " ");
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //    }
            //------------------------------------------------------------------------------------------------- E N D
            //                  𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 8: 𝙈𝙤𝙫𝙞𝙚 𝙏𝙝𝙚𝙖𝙩𝙧𝙚 𝙎𝙚𝙖𝙩 𝘽𝙤𝙤𝙠𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙞𝙢𝙥𝙡𝙚 𝙌𝙪𝙞𝙯 𝘼𝙥𝙥
            //////////////////////////////////////////////////////////////////
            ////                𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙞𝙢𝙥𝙡𝙚 𝙌𝙪𝙞𝙯 𝘼𝙥𝙥
            //_______________________________________________________________ S T A R T

            //Console.WriteLine("Answer 3 questions");
            //string[] questions = ["is the main type of all value",
            //"is any thing that get value/result", "is array of arrays"];
            //string[,] option = { 
            //    { "A) object", "B) jagged", "C) dynamic" }, 
            //    { "A) object", "B) refrence", "C) expression" },
            //    { "A) object", "B) dynamic", "C) jagged" }};

            ////correct answers will be equlaize with user input
            ////so the answers will be in order A C B like password!
            //char[] answers = { 'A', 'C', 'B'}; 
            //int score = 0;

            ////questions loop
            //for (int i = 0; i < 3; i++) {
            //    //show question
            //    Console.WriteLine($"questions { i + 1 } : {questions[i]}");

            //    //option loop
            //    for (int j = 0; j < 3; j++){
            //        //show option at index of question[i] and index of option[j]
            //        Console.WriteLine(option[i,j]);
            //    }
            //    Console.WriteLine("Your option: ");
            //    char userAnswers = Char.ToUpper(Char.Parse(Console.ReadLine()));

            //    //answers check
            //    if (userAnswers == answers[i])
            //    {
            //        score++;
            //    }            
            //}
            //Console.WriteLine($"Score: {score} out of 3");
            ////scoring case
            //switch (score)
            //{
            //    case 0:
            //        Console.WriteLine("Try Again");
            //        break;
            //    case 1:
            //        Console.WriteLine("Fair");
            //        break;
            //    case 2:
            //        Console.WriteLine("Good");
            //        break;
            //    default:
            //        Console.WriteLine("Excellent");
            //        break;
            //}


            //------------------------------------------------------------------------------------------------- E N D
            //                      𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙞𝙢𝙥𝙡𝙚 𝙌𝙪𝙞𝙯 𝘼𝙥𝙥
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙄𝙣𝙫𝙚𝙣𝙩𝙤𝙧𝙮 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙄𝙣𝙫𝙚𝙣𝙩𝙤𝙧𝙮 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 
            //_______________________________________________________________ S T A R T

            //string[] products = { "apple", "orange", "milk", "bread", "eggs" };
            //int[] quantities = { 5, 7, 2, 3, 10 };
            //dynamic choice;
            //do { 
            //    Console.WriteLine("1.View all product | 2.add stock | 3.sell product | 4.check product | 5.exit"); // M e n u
            //    choice = int.TryParse(Console.ReadLine(), out int convertChoise) ? convertChoise : "Error, input from 1 ~ 5";

            //    //user input process switch/case
            //    switch (choice)
            //    {
            //        case 1: // view
            //            viewProductQuantits(products, quantities);
            //            break;
            //        case 2: // add
            //            addStock(products, quantities);
            //            break;
            //        case 3: // sell
            //            sellProduct(products, quantities);
            //            break;
            //        case 4: // check
            //            checkQ(products, quantities);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid!, Must be 1 ~ 5");
            //            break;
            //    }
            //} while (choice != 5);
            ////\\\\\\\\\\\
            ////𝙫𝙞𝙚𝙬 𝙢𝙚𝙩𝙝𝙤𝙙
            //static void viewProductQuantits(string[] array1, int[] array2) {
            //    Console.WriteLine("Product\t\tQuantity");
            //    Console.WriteLine("___________________");
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        Console.WriteLine($"{array1[i]} \t\t {array2[i]}");
            //    }
            //}
            ////\\\\\\\\\\\
            ////𝙖𝙙𝙙 𝙢𝙚𝙩𝙝𝙤𝙙
            //static void addStock(string[] array1, int[] array2) {
            //    Console.WriteLine("Enter product name: ");
            //    string pdName = Console.ReadLine().ToLower(); // .ToLower() to make sure input lower case
            //    int foundPdIndex = -1;                          //serach product
            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        if (string.Equals(pdName, array1[i]))
            //        { //array1[i].ToLower() == pdName.ToLower()
            //            foundPdIndex = i;                       // index in variable by name of porduct, use it to find index of quantities
            //            break;
            //        }
            //    }
            //    if (foundPdIndex != -1) // -1 cuz if it was  index = 0  it will think for first index
            //    {
            //        Console.WriteLine($"Enter quantity to added for {array1[foundPdIndex]}");
            //        int qToAdd = int.Parse(Console.ReadLine());
            //        if (qToAdd > 0)
            //        {
            //            array2[foundPdIndex] += qToAdd;
            //            Console.WriteLine($"Srock added! {array2[foundPdIndex]} for {array1[foundPdIndex]}");
            //        }
            //        else { Console.WriteLine("Invalid qunatity, must be +"); }
            //    }
            //    else { Console.WriteLine("Product not found!"); }
            //}
            ////\\\\\\\\\\
            ////𝙨𝙚𝙡𝙡 𝙢𝙚𝙩𝙝𝙤𝙙
            //static void sellProduct(string[] array1, int[] array2) {
            //    Console.WriteLine("Enter product name to sell: ");
            //    string pdName = Console.ReadLine().ToLower();

            //    //-----------------------Note: search by string then assign index correspond to it---------------------------//
            //    // search funcation by name from input user that will match first name product then it will assign index to variable
            //    // again -1 to make sure index accurate 0 or Null may get some error, i guess
            //    //serach product__________________________________________________________________________________________//
            //    int foundPdIndex = -1;                                                                                   
            //    for (int i = 0; i < array1.Length; i++)                                                                  
            //    {                                                                                                        
            //        if (string.Equals(pdName, array1[i]))                                                                
            //        {      //  ^ other way to write .Equals array1[i].ToLower() == pdName.ToLower()                      
            //            foundPdIndex = i;                       // index in variable by name of porduct_Array,           
            //            break;                                 //  use it to find index of quantities_Array              
            //        }                                                                                                    
            //    }                                                                                                        
            //    
            //    if (foundPdIndex != -1) {
            //        Console.WriteLine($"Enter quantity to be sell of {array1[foundPdIndex]} :");
            //        int qSellAmount = int.Parse(Console.ReadLine());
            //        if (qSellAmount > 0) {
            //            if (qSellAmount <= array2[foundPdIndex])
            //            {
            //                array2[foundPdIndex] -= qSellAmount;
            //                Console.WriteLine($"{array1[foundPdIndex]} been sold, remaining: {array2[foundPdIndex]}");
            //            }
            //            else { Console.WriteLine("Unavilable stock!"); }
            //        } else { Console.WriteLine("Invalid qunatity, must be +"); }
            //    }
            //    else { Console.WriteLine("Product not found!"); }
            //}
            ////\\\\\\\\\\\\\
            ////𝘾𝙝𝙚𝙘𝙠 𝙈𝙚𝙩𝙝𝙤𝙙
            //static void checkQ(string[] array1, int[] array2) {
            //    Console.WriteLine("Enter product name to check it's quantities");
            //    string pdName = Console.ReadLine().ToLower(); // .ToLower() to make sure input lower case
            //    int foundPdIndex = -1;                          
            //    //serach product
            //    for (int i = 0; i < array1.Length; i++)
            //    {       //array1[i].ToLower() == pdName.ToLower()
            //        if (string.Equals(pdName, array1[i]))
            //        { 
            //            // index in variable by name of porduct, use it to find index of quantities
            //            foundPdIndex = i;                                               
            //            break;
            //        }
            //    }
            //    if (foundPdIndex != -1) // -1 cuz if it was  index = 0  it will think for first index
            //    {
            //        Console.WriteLine($"product: {array1[foundPdIndex]} | {array2[foundPdIndex]} ");
            //    }
            //    else { Console.WriteLine("Product not found!"); }
            //}

            //------------------------------------------------------------------------------------------------- E N D
            //                  𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 3: 𝙄𝙣𝙫𝙚𝙣𝙩𝙤𝙧𝙮 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝘽𝙖𝙣𝙠 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝙎𝙞𝙢𝙥𝙡𝙚 𝘽𝙖𝙣𝙠 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T

            ////transaction will be by INDEX of array name
            //string[] bkUserName = { "user1", "user2", "user3" };
            //string[] bkPassword = { "123", "123", "123" };
            //decimal[] bkBalance = { 100, 200, 300 };
            //bool isAuth = false;
            //int userIndex = -1;
            ////login
            //do {
            //    Console.Write("Username: ");
            //    string userUserName = Console.ReadLine();
            //    Console.Write("Password: ");
            //    string userPassword = Console.ReadLine();

            //    for (int i = 0; i < bkUserName.Length; i++) {
            //        if (!(userUserName == bkUserName[i] && userPassword == bkPassword[i]))
            //        {
            //            if(bkUserName.Length == i) {
            //                Console.WriteLine("Invalid user or password!");
            //            }
            //        }
            //        else if (userUserName == bkUserName[i] && userPassword == bkPassword[i]) {
            //            isAuth = true;
            //            userIndex = i;
            //            break;
            //        }
            //    }
            //} while (!isAuth);

            //Console.WriteLine($"Welecome {bkUserName[userIndex]}, Balance {bkBalance[userIndex]}");
            //Console.Write("Enter Number \n1.Deposite | 2.Withdraw | 3.Balance | 4.Transfer: ");
            //int bkValOption =  int.Parse(Console.ReadLine());
            //switch (bkValOption)
            //{
            //    case 1:
            //        Console.WriteLine("_________Deposite_________");
            //        Console.WriteLine($"Bank amount {bkBalance[userIndex]}");
            //        Console.Write("Enter amount to deposite: ");
            //        int userInAmount = int.Parse(Console.ReadLine());
            //        if (userInAmount <= 0)
            //        {
            //            Console.WriteLine("Invalid amount!");
            //        }
            //        else {
            //            bkBalance[userIndex] += userInAmount;
            //            Console.WriteLine($"User Balalnce: {bkBalance[userIndex]}");
            //        }
            //            break;
            //    case 2:
            //        Console.WriteLine("_________Withdraw_________");
            //        Console.WriteLine($"Bank amount {bkBalance[userIndex]}");
            //        Console.Write("Enter amount to withdraw: ");
            //        userInAmount = int.Parse(Console.ReadLine());
            //        if (userInAmount <= 0)
            //        {
            //            Console.WriteLine("Invalid amount!");
            //        }
            //        else
            //        {
            //            bkBalance[userIndex] -= userInAmount;
            //            Console.WriteLine($"User Balalnce: {bkBalance[userIndex]}");
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine($"Current Balance {bkBalance[userIndex]}");
            //        break;
            //    case 4:
            //        Console.WriteLine("_________Transfer_________");
            //        int tempReciveIndex = -1;

            //        //show other user
            //        Console.WriteLine("\t User ");
            //        for (int i = 0; i < bkUserName.Length; i++)
            //        { 
            //            if (i != userIndex) {
            //                Console.Write($" {bkUserName[i]} ");
            //            }
            //        }
            //        Console.WriteLine("\nEnter the username you want to send money to: ");                    
            //        string receiverUsername = Console.ReadLine().ToLower();

            //        //find receiver name index
            //        for (int i = 0; i < bkUserName.Length; i++)
            //        {
            //            if (bkUserName[i] == receiverUsername && i != userIndex)
            //            {
            //                // if user at index [i] match input Receiver _AND_ [i] not equal to current user index
            //                tempReciveIndex = i;
            //                break;
            //            }
            //            else if (tempReciveIndex == -1)
            //            {
            //                Console.WriteLine("Invalid receiver username!");
            //                return;
            //            }
            //        }


            //        //Amount to be transfer
            //        Console.Write("Enter Amount transfer: ");
            //        decimal transAmount;
            //        transAmount = decimal.Parse(Console.ReadLine());
            //        if (transAmount <= 0)
            //        {
            //            Console.WriteLine("Inalide!");                        
            //        }
            //        else if (transAmount > bkBalance[userIndex])
            //        {
            //            Console.WriteLine($"Insufficient amount, your balance {bkBalance[userIndex]}");
            //            return;
            //        }
            //        else { 
            //            bkBalance[userIndex] -= transAmount;
            //            bkBalance[tempReciveIndex] += transAmount;
            //            Console.WriteLine($"Transaction successful! | new balance {bkBalance[userIndex]}");
            //            Console.WriteLine($"^ONLY FOR CHECK IF IT WORK^ user:{bkUserName[tempReciveIndex]} | {bkBalance[tempReciveIndex]}");
            //        }
            //        break;
            //    default:
            //        break;
            //}

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 1: 𝙎𝙞𝙢𝙥𝙡𝙚 𝘽𝙖𝙣𝙠 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T
            //Console.WriteLine("\t\t\t_______Student Grade System_________");
            //string[] stdName = new string[3];
            //int[] stdGrade = new int[3];
            //int tempStdNumber = 0, choiseStd = 0;
            //do {
            //    Console.WriteLine("\t\t\t\t_____Option____");                
            //    Console.WriteLine("1.add student | 2.update grade | 3.view all student & grade | 4.statistics | 5.Exit");
            //    choiseStd = int.Parse(Console.ReadLine());

            //    switch (choiseStd)
            //    {
            //        case 1: //add
            //            if(tempStdNumber >= stdName.Length) {                   //check array size
            //                Console.WriteLine("System is full!");
            //                return;
            //            }

            //            Console.WriteLine("Enter sutdent Name: ");                  //Name  
            //            string stdNameInput = Console.ReadLine().ToLower();     
            //            if (string.IsNullOrEmpty(stdNameInput)){
            //                //Name check
            //                Console.WriteLine("Invalid input!");
            //                return;
            //            }

            //            Console.WriteLine($"Enter [{stdNameInput}]  Grade: ");      //Grade    
            //            int gradeInput = int.Parse(Console.ReadLine());                         
            //            if (gradeInput <= 0 || gradeInput >= 100)
            //            {   //Grade value range validation
            //                Console.WriteLine("Invalide Grade!");
            //                return;
            //            }

            //            stdName[tempStdNumber] = stdNameInput;
            //            stdGrade[tempStdNumber] = gradeInput;
            //            tempStdNumber++;
            //            Console.WriteLine($"student _{stdName}_ added with grade _{gradeInput}_");
            //        break;
            //            //End Case 1


            //        case 2: //update
            //            if (tempStdNumber == 0)
            //            {
            //                Console.WriteLine("No students yet!");
            //                return;
            //            }

            //            Console.WriteLine("Enter student name to update: ");
            //            stdNameInput = Console.ReadLine().ToLower();

            //            //student search 
            //            int foundIndex = -1; // like before, start from -1 not 0  > 0 will point at index!
            //            for (int i = 0; i < tempStdNumber; i++) {
            //                if (stdName[i] == stdNameInput)
            //                {
            //                    foundIndex = i;
            //                    break;
            //                }
            //            }

            //            if (foundIndex != -1)
            //            {
            //                Console.WriteLine($"Grade of student {stdName[foundIndex]} is {stdGrade[foundIndex]} ");
            //                Console.WriteLine("Enter Grade to update:");
            //                int newGrade = int.Parse(Console.ReadLine());

            //                if (newGrade < 0 || newGrade >= 100)
            //                {
            //                    Console.WriteLine("Invalid grade");
            //                    return;
            //                }

            //                stdGrade[foundIndex] = newGrade;
            //                Console.WriteLine($"student {stdName[foundIndex]} grade been update to: {stdGrade[foundIndex]}");
            //            }
            //            else { 
            //                Console.WriteLine("Student not Found!");
            //            }
            //        break;
            //        //End case 2


            //        case 3: //view
            //            if (tempStdNumber == 0)
            //            {
            //                Console.WriteLine("No students yet!");
            //                return;
            //            }
            //            Console.WriteLine("Student Name \t Grade");
            //            Console.WriteLine("---------------------");
            //            for (int i = 0; i < tempStdNumber; i++)
            //            {
            //                Console.WriteLine($"{stdName[i]} \t\t {stdGrade[i]}");
            //            }
            //            break;
            //            //END case 3

            //        case 4: //statistics
            //            if (tempStdNumber == 0)
            //            {
            //                Console.WriteLine("No students yet!");
            //                return;
            //            }
            //            // Array method will count all elemnt, it will not work corcatly
            //            //Console.WriteLine($"Avrage Grade {stdGrade.Average()}");
            //            //Console.WriteLine($"Hights Grade {stdGrade.Max()}");
            //            //Console.WriteLine($"Lowest Grade {stdGrade.Min()}");

            //            int totalGrade = 0;

            //            //for Min/Max to work we need to assign this value with first index value of array stdGrade
            //            //the comparison will be from first index value until it's find value high/low than assign one
            //            int highGrade = stdGrade[0], loweGrade = stdGrade[0];
            //            string lowStd = stdName[0], highStd = stdName[0];

            //            for (int i = 0; i < tempStdNumber; i++)
            //            {                            
            //                totalGrade += stdGrade[i];

            //                if (stdGrade[i] > highGrade)
            //                {
            //                    highGrade = stdGrade[i];
            //                    highStd = stdName[i];
            //                }

            //                if (stdGrade[i] < loweGrade)
            //                {
            //                    loweGrade = stdGrade[i];
            //                    lowStd = stdName[i];
            //                }
            //            }
            //            double avgGrade = (double)totalGrade / tempStdNumber;

            //            Console.WriteLine("______Statistics______");
            //            Console.WriteLine($"Average Grade: {avgGrade}");
            //            Console.WriteLine($"Highest Grade: {highGrade} | {highStd}");
            //            Console.WriteLine($"Lowest Grade:  {loweGrade} | {lowStd}");

            //            //double avg = stdGrade.Sum() / stdGrade.Length;
            //            break;

            //        case 5:
            //            Console.WriteLine("Exit");
            //            break;

            //        default:
            //            Console.WriteLine("Enter from 1 ~ 5");
            //            break;
            //    }
            //}while (choiseStd != 5);


            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 4: 𝙎𝙩𝙪𝙙𝙚𝙣𝙩 𝙂𝙧𝙖𝙙𝙚 𝙈𝙖𝙣𝙖𝙜𝙚𝙢𝙚𝙣𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝙋𝙖𝙧𝙠𝙞𝙣𝙜 𝙇𝙤𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝙋𝙖𝙧𝙠𝙞𝙣𝙜 𝙇𝙤𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T
            //Console.WriteLine("Parking Lot");
            //string[] slot = new string[10];
            //int choicePkSwitch;
            //do {
            //    Console.WriteLine("Option");
            //    Console.WriteLine("1.Park a car | 2.Remove Car | 3.View Slot | 4.Find a Car | 5.Exit");
            //    choicePkSwitch = int.Parse(Console.ReadLine());

            //    switch (choicePkSwitch)
            //    {
            //        case 1://park(add)
            //            Console.WriteLine("Enter car license number of car");

            //            string licenseInput = Console.ReadLine().ToUpper();
            //            int tempSlot = -1; // -1, zero 0 will point to index !

            //            //check car in slot?
            //            for (int i = 0; i < slot.Length; i++)
            //            {
            //                if (slot[i] == licenseInput){
            //                    Console.WriteLine("Car already parked");
            //                    return;
            //                }
            //            }

            //            //assign car slot
            //            for (int i = 0; i < slot.Length; i++)
            //            {
            //                // slots[i] == null || slots[i] == "" < diffrent way of writing
            //                if (string.IsNullOrEmpty(slot[i]))
            //                {
            //                    tempSlot = i;
            //                    break;
            //                }
            //            }
            //            if (tempSlot != -1)
            //            {
            //                slot[tempSlot] = licenseInput;
            //                Console.WriteLine($"car parked {tempSlot} + 1");
            //            }
            //            else { Console.WriteLine("Parking is full"); }
            //            break;


            //        case 2://remove car
            //            Console.WriteLine("Enter car license to remove: ");

            //            tempSlot = -1;
            //            licenseInput = Console.ReadLine().ToUpper();

            //            for (int i = 0; i < slot.Length; i++)
            //            {
            //                if (slot[i] == licenseInput)
            //                {
            //                    tempSlot = i;
            //                    break;
            //                }
            //            }
            //            if (tempSlot != 1)
            //            {
            //                slot[tempSlot] = ""; // empty?
            //                Console.WriteLine($"Car {licenseInput} remove from {tempSlot} + 1"); //Point to index
            //            }
            //            else {
            //                Console.WriteLine("Car not found!");
            //            }
            //             break;


            //        case 3://view
            //            Console.WriteLine("Slot | Linence");
            //            for (int i = 0; i < slot.Length; i++) {
            //                Console.WriteLine($"{i} | {slot[i]}");
            //            }                       
            //        break;


            //        case 4://search
            //            Console.WriteLine("Enter car license to serach");

            //            tempSlot = -1;
            //            licenseInput = Console.ReadLine().ToUpper();
            //            for (int i = 0; i < slot.Length; i++)
            //            {
            //                if (slot[i] == licenseInput)
            //                {
            //                    tempSlot = i;
            //                    break ;
            //                }
            //            }
            //            if (tempSlot != -1 )
            //            {
            //                Console.WriteLine($"Car {licenseInput} found in slot {tempSlot} + 1");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Car not found!");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice! Please select 1-5.");
            //            break;
            //    }
            //} while (choicePkSwitch != 5);

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝙋𝙖𝙧𝙠𝙞𝙣𝙜 𝙇𝙤𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 6: 𝙏𝙤-𝘿𝙤 𝙇𝙞𝙨𝙩 𝘼𝙥𝙥𝙡𝙞𝙘𝙖𝙩𝙞𝙤𝙣
            //////////////////////////////////////////////////////////////////
            ////                𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 6: 𝙏𝙤-𝘿𝙤 𝙇𝙞𝙨𝙩 𝘼𝙥𝙥𝙡𝙞𝙘𝙖𝙩𝙞𝙤𝙣
            //_______________________________________________________________ S T A R T

            //Console.WriteLine("To-do list");

            //string[] tasks = new string[10];
            //string[] isTaskComplate = new string[10];
            //int taskNum = 0;

            //int choiceToDo = 0;

            //do
            //{
            //    Console.WriteLine("_____OPTION____");
            //    Console.Write("1.add task | 2.view task | 3.mark task complete | 4.delete task | 5.clear task | 6.Exit \n");
            //    choiceToDo = int.Parse(Console.ReadLine());
            //    switch (choiceToDo)                    
            //    {
            //        case 1://add
            //            //check array tasks is there any
            //            if (taskNum >= tasks.Length)
            //            {
            //                Console.WriteLine("Connot add task!");
            //                return;
            //            }
            //            Console.WriteLine("Enter task name:");
            //            string task = Console.ReadLine();

            //            if (string.IsNullOrEmpty(task))
            //            {
            //                Console.WriteLine("task cannot be empty!");
            //                return;
            //            }

            //            tasks[taskNum] = task;
            //            isTaskComplate[taskNum] = "Pend!"; //mark task at taskNum(index) not complated

            //            //taskNum (task counter must be increase here) cuze it has use in DELETE case 
            //            taskNum++;

            //            break;
            //        case 2://view
            //            #region taskView
            //            //if (taskNum == 0)
            //            //{
            //            //    Console.WriteLine("No task");
            //            //    return;
            //            //}
            //            //Console.WriteLine("_____TASK_____");

            //            ////create temp value to hold not complated and complated task
            //            //int tempNotComlete = 0, tempComplete = 0;

            //            //for (int i = 0; i < taskNum; i++)
            //            //{
            //            //    bool doseTaskCompleted = isTaskComplate[i] == "Complete!";
            //            //    string taskStausIndex = doseTaskCompleted ? "Complete!" : "Pend!";

            //            //    Console.WriteLine($"{i + 1}_{taskStausIndex} | {tasks[i]}");

            //            //    //counter for temp value
            //            //    if (isTaskComplate[i] == "Complete!")
            //            //    {
            //            //        tempComplete++;
            //            //    }
            //            //    else
            //            //    {
            //            //        tempNotComlete++;
            //            //    }
            //            //}

            //            //Console.WriteLine();
            //            //Console.Write($"{tempComplete} | {tempNotComlete} ,Total task: {taskNum}");
            //            #endregion
            //            //     task Counter | Array task mark | Array Task
            //            displayTask(taskNum, isTaskComplate, tasks);
            //            break;

            //        case 3://mark task
            //            Console.WriteLine("--------Mark Tasks-------");
            //            displayTask(taskNum, isTaskComplate, tasks);
            //            Console.WriteLine("Enter task number to mark complete:");
            //            int taskNumMark = int.Parse(Console.ReadLine());

            //            //validate task to make sure it not ZERO or more than task counter
            //            if (taskNumMark < 1 || taskNumMark > taskNum)
            //            {
            //                Console.WriteLine("Invalid task number!");
            //                return;
            //            }

            //            //the delete by index number of isTaskComplate_List 
            //            int indexTask = taskNumMark - 1;
            //            if (isTaskComplate[indexTask] == "Complete!")
            //            {
            //                Console.WriteLine("Task already completed");
            //            }
            //            else
            //            {
            //                isTaskComplate[indexTask] = "Complete!";
            //                Console.WriteLine($"task [{tasks[indexTask]}] mark as complete!");
            //            }


            //            break;
            //        case 4://delete
            //            //From what i understand, if must be left shift
            //            Console.WriteLine("--------Delete Tasks-------");
            //            displayTask(taskNum, isTaskComplate, tasks);

            //            Console.WriteLine("Enter task to delete number: ");
            //            taskNumMark = int.Parse(Console.ReadLine());

            //            if (taskNumMark < 1 || taskNumMark > taskNum)
            //            {
            //                Console.WriteLine("Invalid task number!");
            //                return;
            //            }

            //            //assing taskNumMark user input to temp var, -1 cuz index start from 0
            //            // if user input 2 this mean index 1 in tasksArray and isCompleteArray
            //            //having index stored  v , now the string in array task and isComplete can be located
            //            int indexTaskDelete = taskNumMark - 1;



            //            //__________________________Note: shifing array element_________________________________]
            //            // [i] will be for index that user input need to be deleted,                            ]
            //            // it must be less than taskNum(task counter)                                           ]
            //            // **left_shift: secound element take first element in array                            ]
            //            // العنصر الثاني ياخذ مكان الأول، والثالث ياخذ مكان الثاني                               ]
            //            // start from e.g.index 1 userInput, the 1 must less taskNum(task done in added case)   ]
            //            // tasks[1] will be register to tasks[2]                                                ]
            //            //   كل عنصر ياخذ قيمة العنصر اللي بعده < (reassign)                                    ]
            //            //--------------------------------------------------------------------------------------]
            //                                                                                                //  |
            //            for (int i = indexTaskDelete; i < taskNum; i++)                                     //  |
            //            {                                                                                   //  |
            //                tasks[i] = tasks[i + 1];                                                        //  |
            //                isTaskComplate[i] = isTaskComplate[ i + 1];                                     //  |
            //            }                                                                                   //  |
            //                                                                                                //  |
            //                                                                                                //  |
            //            //this two line code are for clearing last element, but the code run without them   //< |
            //            //i leave it like this in case any error!                                           //< |
            //            //tasks[taskNum - 1] = "";                                                                    
            //            //isTaskComplate[taskNum - 1] = "";                                                 


            //            //decrease taskNum is MUST
            //            //since all this code run at this single variable which trake user input, i gusse?
            //            Console.WriteLine($"Task [{taskNumMark}] is deleted!");
            //            taskNum--;

            //            break;

            //        case 5: //Clear completed task
            //            Console.WriteLine("--------Clear completed task-------");
            //            displayTask(taskNum, isTaskComplate, tasks);

            //            int competedCounter = 0;
            //            for (int i = 0; i < taskNum; i++) {
            //                if (isTaskComplate[i] == "Complete!")
            //                {
            //                    competedCounter++;
            //                }
            //            }
            //            if (competedCounter == 0)
            //            {
            //                Console.WriteLine("No task to be cleared!");
            //                return ;
            //            }

            //            Console.WriteLine("Are you sure you want to clear all completed task? y | n ");
            //            char askIfClear = char.Parse(Console.ReadLine().ToLower());

            //            //int tempIndexClear = 0;
            //            if (askIfClear == 'y') {
            //                for (int i = 0; i < taskNum; i++)
            //                {
            //                    if (isTaskComplate[i] == "Complete!")
            //                    {
            //                        for (int j = i; j < taskNum; j++)
            //                        {
            //                            tasks[j] = tasks[j + 1];
            //                            isTaskComplate[j] = isTaskComplate[j + 1];
            //                        }

            //                        taskNum--; // reduce task counter since it work like Delete case 4
            //                        i--;    // reduce one to recheck first index agien

            //                        // i + 1 cuz i--; in previos line
            //                        Console.WriteLine($"Task {i + 2} cleared");
            //                    }  
            //                }

            //            }
            //            else
            //            {
            //                Console.WriteLine("Clear cancelled!");
            //            }
            //                break;
            //        default:
            //            Console.WriteLine("Input from 1 to 6");
            //            break;
            //    }
            //} while (choiceToDo != 6);



            //__________________________________________________________________V I E W  Methode
            static void displayTask(int tkNum, string[] isTKcomp, string[] tk)
            {
                //task check
                if (tkNum == 0)
                {
                    Console.WriteLine("No task yet");
                    return;
                }

                Console.WriteLine("_____TASK_____");

                for (int i = 0; i < tkNum; i++)
                {
                    //while task not complete this will assign FALSE to doseTaskCompleted at index I
                    bool doseTaskCompleted = isTKcomp[i] == "Complete!";
                    string taskStausIndex = doseTaskCompleted ? "Complete!" : "Pend!";

                    Console.WriteLine($"{i + 1}_{taskStausIndex} | {tk[i]}");
                }

                Console.WriteLine();
            }

            //------------------------------------------------------------------------------------------------- E N D
            //                      𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 6: 𝙏𝙤-𝘿𝙤 𝙇𝙞𝙨𝙩 𝘼𝙥𝙥𝙡𝙞𝙘𝙖𝙩𝙞𝙤𝙣
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion












            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙇𝙞𝙗𝙧𝙖𝙧𝙮 𝘽𝙤𝙤𝙠 𝘽𝙤𝙧𝙧𝙤𝙬𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////           𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙇𝙞𝙗𝙧𝙖𝙧𝙮 𝘽𝙤𝙤𝙠 𝘽𝙤𝙧𝙧𝙤𝙬𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T



            //plane to use two sperate array but, this is  2D array test


            Console.WriteLine("-------------- Library Book borrwing ------------------");

            string[] books = [ "book1",   "book2",   "book3",   "book4"];
            string[] isBookBorrowed = new string[books.Length];

            // mark all books Yes(available) at first
            for (int i = 0; i < books.Length; i++)
            {
                isBookBorrowed[i] = "Yes";
            }

            int choiceBookLib = 0;
            do {

                Console.WriteLine("\n\t____________Menu____________");
                Console.WriteLine("1.view books | 2.borrow book | 3.return book | 4.check book available | 5.exit");
                choiceBookLib = int.Parse(Console.ReadLine());

                switch (choiceBookLib)
                {
                    case 1: //view
                        displayBook(books, isBookBorrowed);
                        break;

                    case 2: //borrow
                        displayBook(books, isBookBorrowed);
                        Console.Write("\nEnter Book Number to borrow: ");
                        int bookNumBorrow = int.Parse(Console.ReadLine());
                        if (bookNumBorrow < 1 || bookNumBorrow > books.Length)
                        {
                            Console.WriteLine("Invalid book number!");
                            return;
                        }

                        int indexBook = bookNumBorrow - 1; // store index in temp value
                        if (isBookBorrowed[indexBook] != "Yes")
                        {
                            Console.WriteLine($"Book: [{books[indexBook]}], already borrwed" +
                                $" | Available: [{isBookBorrowed[indexBook]}]");
                        }
                        else
                        {                            
                            isBookBorrowed[indexBook] = "No";
                            Console.WriteLine($"You have borrowed book: [{books[indexBook]}]");
                        }                        
                            break;

                    case 3: //return
                        int bookBrrowCounter = 0;
                        for (int i = 0; i < books.Length; i++) {
                            if (isBookBorrowed[i] == "No") //Show only No book mark
                            {
                                Console.WriteLine($"{i + 1} | {books[i]} | {isBookBorrowed[i]}");
                                bookBrrowCounter++;
                            }
                        }
                        if (bookBrrowCounter == 0)
                        {
                            Console.WriteLine("No book borrowed");
                            return ;
                        }

                        Console.WriteLine("Enter borrowed book number to return: ");
                        bookNumBorrow = int.Parse (Console.ReadLine());
                        if (bookNumBorrow < 1 || bookNumBorrow > books.Length)
                        {
                            Console.WriteLine("Invalid book number!");
                            return;
                        }

                        indexBook = bookNumBorrow - 1;
                        if (isBookBorrowed[indexBook] == "Yes")
                        {
                            Console.WriteLine($"{books[indexBook]} not a borrwoed book!");
                        }
                        else
                        {
                            isBookBorrowed[indexBook] = "Yes";
                            Console.WriteLine($"Book [{books[indexBook]}] was returning");
                        }

                        break;


                    case 4:  // check book availability
                        for (int i = 0; i < books.Length; i++) {
                            if (isBookBorrowed[i] != "No")
                            {
                                Console.WriteLine($"{isBookBorrowed[i]} | {books[i]}");
                            }
                        }

                        //serach by name of book?
                        Console.WriteLine("Enter Book name: ");
                        string bookNameAvl = Console.ReadLine().ToLower();
                        int indexSerachBook = -1; // -1 cuz we don't need to start from index 0
                        for (int i = 0; i < books.Length; i++) {
                            if (books[i].Contains(bookNameAvl))
                            {
                                indexSerachBook = i;
                                break;
                            }
                        }

                        if (indexSerachBook != -1)
                        {
                            if (isBookBorrowed[indexSerachBook] == "Yes")
                            {
                                Console.WriteLine($"[{books[indexSerachBook]}] is available");
                            }
                            else
                            {
                                Console.WriteLine($"{books[indexSerachBook]} is currently borroed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book not found in lib");
                        }
                        break;
                    default:
                        break;
                }

            } while (choiceBookLib != 5);

            static void displayBook(string[] bk, string[] isBr) {
                Console.WriteLine("\nNO. \tAvailable \tBooks");
                Console.WriteLine("----------------------------");
                int yesCount = 0, noCount = 0; //indicate if there book or not
                for (int i = 0; i < bk.Length; i++) {
                    string statusBorrow = isBr[i] == "Yes" ? "Yes" : "No";     //Ternary Operator: (condition) ? valueIfTrue : valueIfFalse;
                    Console.WriteLine($"{i + 1} \t|{statusBorrow}  \t\t|{bk[i]}");

                    if (isBr[i] == "Yes"){ yesCount++; }
                    else { noCount++; }
                }
                Console.WriteLine($"Available books: {yesCount} | Borrwed books: {noCount}");
            }


            

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙇𝙞𝙗𝙧𝙖𝙧𝙮 𝘽𝙤𝙤𝙠 𝘽𝙤𝙧𝙧𝙤𝙬𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion








        }
    }

}
