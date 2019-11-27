using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    //'Receiver' class
    public class CalculatorReciever
    {
        private int _a, _b;

        public CalculatorReciever(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public int Add()
        {
            return _a + _b;
        }

        public int Substract()
        {
            return _a - _b;
        }
    }
}
