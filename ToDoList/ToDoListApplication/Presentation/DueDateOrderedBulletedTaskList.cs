using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public class DueDateOrderedBulletedTaskList : ToDoListAbstraction
    {
        public override void SortingList()
        {
            this.Implementor = new  DueDateOrderedTaskList();
            this.TaskList = this.Implementor.Sort(this.TaskList);
        }

        public override void PrintFormatedtoDoList()
        {
            foreach (var item in this.TaskList)
            {
                Console.WriteLine("* {0,-25}\t{1,-25}\t{2,-25}", item.Description, item.DueDate, item.Priority);
            }
        }
    }
}
