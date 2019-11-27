using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    public class Invoker
    {
        public int ExecuteCommand(ICommand command)
        {
            return command.Execute();
        }
    }
}
