using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public class UnorderedNumberedTaskList : ToDoListAbstraction
    {
        public override void SortingList()
        {
            this.Implementor = new UnorderedTaskList();
            this.TaskList = this.Implementor.Sort(this.TaskList);
        }

        public override void PrintFormatedtoDoList()
        {
            foreach (var item in this.TaskList)
            {
                Console.WriteLine("{0}.{1,-25}\t{2,-25}\t{3,-25}", this.TaskList.ToList().IndexOf(item)+1, item.Description, item.DueDate, item.Priority);
            }
        }
    }
}
