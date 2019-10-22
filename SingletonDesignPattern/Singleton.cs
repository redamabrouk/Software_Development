using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    /// <summary>

    /// The 'Singleton' class

    /// </summary>

    class Singleton
    {
        private static Singleton _instance;

        // Constructor is 'protected' can be inherited

        protected Singleton()
        {
        }

        public static Singleton GetInstance()
        {


            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
