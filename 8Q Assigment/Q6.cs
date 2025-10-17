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



            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 6: 𝙏𝙤-𝘿𝙤 𝙇𝙞𝙨𝙩 𝘼𝙥𝙥𝙡𝙞𝙘𝙖𝙩𝙞𝙤𝙣
            //////////////////////////////////////////////////////////////////
            ////                𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 6: 𝙏𝙤-𝘿𝙤 𝙇𝙞𝙨𝙩 𝘼𝙥𝙥𝙡𝙞𝙘𝙖𝙩𝙞𝙤𝙣
            //_______________________________________________________________ S T A R T

            Console.WriteLine("To-do list");

            string[] tasks = new string[10];
            string[] isTaskComplate = new string[10];
            int taskNum = 0;

            int choiceToDo = 0;

            do
            {
               Console.WriteLine("_____OPTION____");
               Console.Write("1.add task | 2.view task | 3.mark task complete | 4.delete task | 5.clear task | 6.Exit \n");
               choiceToDo = int.Parse(Console.ReadLine());
               switch (choiceToDo)                    
               {
                   case 1://add
                       //check array tasks is there any
                       if (taskNum >= tasks.Length)
                       {
                           Console.WriteLine("Connot add task!");
                           return;
                       }
                       Console.WriteLine("Enter task name:");
                       string task = Console.ReadLine();

                       if (string.IsNullOrEmpty(task))
                       {
                           Console.WriteLine("task cannot be empty!");
                           return;
                       }

                       tasks[taskNum] = task;
                       isTaskComplate[taskNum] = "Pend!"; //mark task at taskNum(index) not complated

                       //taskNum (task counter must be increase here) cuze it has use in DELETE case 
                       taskNum++;

                       break;
                   case 2://view
                       #region taskView
                       //if (taskNum == 0)
                       //{
                       //    Console.WriteLine("No task");
                       //    return;
                       //}
                       //Console.WriteLine("_____TASK_____");

                       ////create temp value to hold not complated and complated task
                       //int tempNotComlete = 0, tempComplete = 0;

                       //for (int i = 0; i < taskNum; i++)
                       //{
                       //    bool doseTaskCompleted = isTaskComplate[i] == "Complete!";
                       //    string taskStausIndex = doseTaskCompleted ? "Complete!" : "Pend!";

                       //    Console.WriteLine($"{i + 1}_{taskStausIndex} | {tasks[i]}");

                       //    //counter for temp value
                       //    if (isTaskComplate[i] == "Complete!")
                       //    {
                       //        tempComplete++;
                       //    }
                       //    else
                       //    {
                       //        tempNotComlete++;
                       //    }
                       //}

                       //Console.WriteLine();
                       //Console.Write($"{tempComplete} | {tempNotComlete} ,Total task: {taskNum}");
                       #endregion
                       //     task Counter | Array task mark | Array Task
                       displayTask(taskNum, isTaskComplate, tasks);
                       break;

                   case 3://mark task
                       Console.WriteLine("--------Mark Tasks-------");
                       displayTask(taskNum, isTaskComplate, tasks);
                       Console.WriteLine("Enter task number to mark complete:");
                       int taskNumMark = int.Parse(Console.ReadLine());

                       //validate task to make sure it not ZERO or more than task counter
                       if (taskNumMark < 1 || taskNumMark > taskNum)
                       {
                           Console.WriteLine("Invalid task number!");
                           return;
                       }

                       //the delete by index number of isTaskComplate_List 
                       int indexTask = taskNumMark - 1;
                       if (isTaskComplate[indexTask] == "Complete!")
                       {
                           Console.WriteLine("Task already completed");
                       }
                       else
                       {
                           isTaskComplate[indexTask] = "Complete!";
                           Console.WriteLine($"task [{tasks[indexTask]}] mark as complete!");
                       }


                       break;
                   case 4://delete
                       //From what i understand, if must be left shift
                       Console.WriteLine("--------Delete Tasks-------");
                       displayTask(taskNum, isTaskComplate, tasks);

                       Console.WriteLine("Enter task to delete number: ");
                       taskNumMark = int.Parse(Console.ReadLine());

                       if (taskNumMark < 1 || taskNumMark > taskNum)
                       {
                           Console.WriteLine("Invalid task number!");
                           return;
                       }

                       //assing taskNumMark user input to temp var, -1 cuz index start from 0
                       // if user input 2 this mean index 1 in tasksArray and isCompleteArray
                       //having index stored  v , now the string in array task and isComplete can be located
                       int indexTaskDelete = taskNumMark - 1;



                       //__________________________Note: shifing array element_________________________________]
                       // [i] will be for index that user input need to be deleted,                            ]
                       // it must be less than taskNum(task counter)                                           ]
                       // **left_shift: secound element take first element in array                            ]
                       // العنصر الثاني ياخذ مكان الأول، والثالث ياخذ مكان الثاني                               ]
                       // start from e.g.index 1 userInput, the 1 must less taskNum(task done in added case)   ]
                       // tasks[1] will be register to tasks[2]                                                ]
                       //   كل عنصر ياخذ قيمة العنصر اللي بعده < (reassign)                                    ]
                       //--------------------------------------------------------------------------------------]
                                                                                                           //  |
                       for (int i = indexTaskDelete; i < taskNum; i++)                                     //  |
                       {                                                                                   //  |
                           tasks[i] = tasks[i + 1];                                                        //  |
                           isTaskComplate[i] = isTaskComplate[ i + 1];                                     //  |
                       }                                                                                   //  |
                                                                                                           //  |
                                                                                                           //  |
                       //this two line code are for clearing last element, but the code run without them   //< |
                       //i leave it like this in case any error!                                           //< |
                       //tasks[taskNum - 1] = "";                                                                    
                       //isTaskComplate[taskNum - 1] = "";                                                 


                       //decrease taskNum is MUST
                       //since all this code run at this single variable which trake user input, i gusse?
                       Console.WriteLine($"Task [{taskNumMark}] is deleted!");
                       taskNum--;

                       break;

                   case 5: //Clear completed task
                       Console.WriteLine("--------Clear completed task-------");
                       displayTask(taskNum, isTaskComplate, tasks);

                       int competedCounter = 0;
                       for (int i = 0; i < taskNum; i++) {
                           if (isTaskComplate[i] == "Complete!")
                           {
                               competedCounter++;
                           }
                       }
                       if (competedCounter == 0)
                       {
                           Console.WriteLine("No task to be cleared!");
                           return ;
                       }

                       Console.WriteLine("Are you sure you want to clear all completed task? y | n ");
                       char askIfClear = char.Parse(Console.ReadLine().ToLower());

                       //int tempIndexClear = 0;
                       if (askIfClear == 'y') {
                           for (int i = 0; i < taskNum; i++)
                           {
                               if (isTaskComplate[i] == "Complete!")
                               {
                                   for (int j = i; j < taskNum; j++)
                                   {
                                       tasks[j] = tasks[j + 1];
                                       isTaskComplate[j] = isTaskComplate[j + 1];
                                   }

                                   taskNum--; // reduce task counter since it work like Delete case 4
                                   i--;    // reduce one to recheck first index agien

                                   // i + 1 cuz i--; in previos line
                                   Console.WriteLine($"Task {i + 2} cleared");
                               }  
                           }

                       }
                       else
                       {
                           Console.WriteLine("Clear cancelled!");
                       }
                           break;
                   default:
                       Console.WriteLine("Input from 1 to 6");
                       break;
               }
            } while (choiceToDo != 6);



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



        }
    }

}
