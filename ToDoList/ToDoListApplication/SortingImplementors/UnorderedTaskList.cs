﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoListApplication
{
    public class UnorderedTaskList : Implementor
    {

        public IEnumerable<TaskItem> Sort(IEnumerable<TaskItem> p_list)
        {
            var SortedList = p_list.OrderByDescending(c => c.Description);
            return SortedList;
        }
    }
}
