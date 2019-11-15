using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            c.Run();
            Console.ReadKey();
        }
    }
}
