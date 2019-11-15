using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public class TaskItem
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private DateTime dueDate;

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        private PriorityEnum priority;

        public PriorityEnum Priority
        {
            get { return priority; }
            set { priority = value; }
        }
    }
}
