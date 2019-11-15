using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public class Client
    {
        public ToDoListAbstraction ToDoListAbstraction { get;set; }
        
        public  void Run()
        {
            List<TaskItem> todolist = new List<TaskItem>();
            todolist.Add(new TaskItem { Description = "Buy groceries", DueDate = new DateTime(2012, 11, 20), Priority = PriorityEnum.high });
            todolist.Add(new TaskItem { Description = "Take the TDDB84 exam", DueDate = new DateTime(2012,11,14), Priority = PriorityEnum.medium });
            todolist.Add(new TaskItem { Description = "Submit the labs", DueDate = new DateTime(2012,11,22), Priority = PriorityEnum.medium });
            todolist.Add(new TaskItem { Description = "Buy movie tickets", DueDate = new DateTime(2012,11,15), Priority = PriorityEnum.low });

            Console.WriteLine("A prioritized numbered task list:");
            Console.WriteLine();
            ToDoListAbstraction = new PrioritizedNumberedTaskList();
            ToDoListAbstraction.TaskList = todolist;
            ToDoListAbstraction.SortingList();
            ToDoListAbstraction.PrintFormatedtoDoList();

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("An unordered numbered task list:");
            Console.WriteLine();
            ToDoListAbstraction = new UnorderedNumberedTaskList();
            ToDoListAbstraction.TaskList = todolist;
            ToDoListAbstraction.SortingList();
            ToDoListAbstraction.PrintFormatedtoDoList();

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("A due date ordered bulleted task list:");
            Console.WriteLine();
            ToDoListAbstraction = new DueDateOrderedBulletedTaskList();
            ToDoListAbstraction.TaskList = todolist;
            ToDoListAbstraction.SortingList();
            ToDoListAbstraction.PrintFormatedtoDoList();
        }
    }
}
