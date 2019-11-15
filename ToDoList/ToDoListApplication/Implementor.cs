using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public interface Implementor
    {
        IEnumerable<TaskItem> Sort(IEnumerable<TaskItem> p_list);
    }
}
