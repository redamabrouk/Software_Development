using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDPattern
{
    /// <summary>
    /// The ConcreteAggregate class
    /// </summary>
    class JellyBeanCollection : IAggregate<JellyBean>
    {
        private List<JellyBean> _items = new List<JellyBean>();

        public IIterator<JellyBean> GetIterator()
        {
            return new JellyBeanIterator(this);
        }


        public int Count { get { return _items.Count; } }

        // Indexer
        public JellyBean this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
