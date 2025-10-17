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
            
            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙞𝙢𝙥𝙡𝙚 𝙌𝙪𝙞𝙯 𝘼𝙥𝙥
            //////////////////////////////////////////////////////////////////
            ////                𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙞𝙢𝙥𝙡𝙚 𝙌𝙪𝙞𝙯 𝘼𝙥𝙥
            //_______________________________________________________________ S T A R T

            Console.WriteLine("Answer 3 questions");
            string[] questions = ["is the main type of all value",
            "is any thing that get value/result", "is array of arrays"];
            string[,] option = { 
               { "A) object", "B) jagged", "C) dynamic" }, 
               { "A) object", "B) refrence", "C) expression" },
               { "A) object", "B) dynamic", "C) jagged" }};

            //correct answers will be equlaize with user input
            //so the answers will be in order A C B like password!
            char[] answers = { 'A', 'C', 'B'}; 
            int score = 0;

            //questions loop
            for (int i = 0; i < 3; i++) {
               //show question
               Console.WriteLine($"questions { i + 1 } : {questions[i]}");

               //option loop
               for (int j = 0; j < 3; j++){
                   //show option at index of question[i] and index of option[j]
                   Console.WriteLine(option[i,j]);
               }
               Console.WriteLine("Your option: ");
               char userAnswers = Char.ToUpper(Char.Parse(Console.ReadLine()));

               //answers check
               if (userAnswers == answers[i])
               {
                   score++;
               }            
            }
            Console.WriteLine($"Score: {score} out of 3");
            //scoring case
            switch (score)
            {
               case 0:
                   Console.WriteLine("Try Again");
                   break;
               case 1:
                   Console.WriteLine("Fair");
                   break;
               case 2:
                   Console.WriteLine("Good");
                   break;
               default:
                   Console.WriteLine("Excellent");
                   break;
            }


            //------------------------------------------------------------------------------------------------- E N D
            //                      𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 2: 𝙎𝙞𝙢𝙥𝙡𝙚 𝙌𝙪𝙞𝙯 𝘼𝙥𝙥
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion



        }
    }

}
