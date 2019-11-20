using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDPattern
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class JellyBeanIterator : IIterator<JellyBean>
    {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public JellyBeanIterator(JellyBeanCollection beans)
        {
            this._jellyBeans = beans;
        }


        // Gets whether iteration is complete
        public bool IsDone()
        {
            return _current >= _jellyBeans.Count;
        }

        public JellyBean FirstItem()
        {
            _current = 0;
            return _jellyBeans[_current];
        }

       

        public JellyBean CurrentItem()
        {
            return _jellyBeans[_current] ;
        }


        public JellyBean NextItem()
        {
            _current += _step;
            if (!IsDone())
                return _jellyBeans[_current];
            else
                return null;
        }

       
    }
}
