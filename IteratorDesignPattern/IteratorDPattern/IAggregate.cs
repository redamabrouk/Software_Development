using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDPattern
{
    interface IAggregate<T>
    {
        IIterator<T> GetIterator();
    }
}
