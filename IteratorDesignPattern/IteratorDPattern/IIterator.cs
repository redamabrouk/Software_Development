using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDPattern
{
    interface IIterator<T>
    {
        T FirstItem();
        T NextItem();
        T CurrentItem();
        bool IsDone();
    }
}
