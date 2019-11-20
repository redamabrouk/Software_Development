using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDPattern
{
    /// <summary>
    /// Our collection item.  
    /// </summary>
    class JellyBean
    {
        private string _flavor;

        // Constructor
        public JellyBean(string flavor)
        {
            this._flavor = flavor;
        }


        public string Flavor
        {
            get { return _flavor; }
        }
    }
}
