using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public abstract class ToDoListAbstraction
    {
        public IEnumerable<TaskItem> TaskList { get; set; }
        public Implementor Implementor { get; set; }
        public abstract void SortingList();
        public abstract void PrintFormatedtoDoList();
    }
}
