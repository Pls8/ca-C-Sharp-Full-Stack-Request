using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q5
{
    public class TaskClass
    {
        public TaskClass(string title, string description, TaskPriority priority)
        {
            this.title = title;
            this.description = description;
            this.priority = priority;
            this.isCompleted = false;
        }

        public string title { get; set; }
        public string description { get; set; }
        public TaskPriority priority { get; set; }
        public bool isCompleted { get; set; }
    }
}
