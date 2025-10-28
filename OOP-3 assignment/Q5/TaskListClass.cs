using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q5
{
    public class TaskListClass
    {
        List<TaskClass> tasks;

        public TaskListClass()
        {
            this.tasks = new List<TaskClass>();
        }


        //indexer for task priority
        //*Usage:* List<TaskClass> highPriority = taskList[TaskPriority.high];
        public List<TaskClass> this[TaskPriority tskPriority]
        {   
            get { //Returns all tasks of specified priority
                List<TaskClass> result = new List<TaskClass>();
                foreach (TaskClass tsk in tasks)
                {
                    if (tsk.priority == tskPriority)
                    {
                        result.Add(tsk);
                    }
                }
                return result;
            }
        }


        //add task
        public void addTask(TaskClass task) { 
            tasks.Add(task);
        }


        //mark complete
        public void markComplete(string taskTitle) {
            foreach (TaskClass task in tasks) {
                if (task.title.ToLower() == taskTitle.ToLower())
                {
                    task.isCompleted = true;
                }
            }
        }


        //show all task
        public void showAllTask() {            
            if (tasks.Count == 0)
            {
                Console.WriteLine("No task yes!");
                return;
            }
            Console.WriteLine("______ All Tasks _____");
            foreach (TaskClass task in tasks)
            {
                string status = task.isCompleted ? "Completed" : "Pending"; 

                Console.WriteLine($"Title [{task.title}] | " +
                    $"description [{task.description}] | " +
                    $"priority [{task.priority}] | " +
                    $"status: [{status}]");
            }
        }







    }
}
