using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    //'ConcreteCommand2' class
    public class SubtractCommand : ICommand
    {
        private CalculatorReciever _calculator;

        public SubtractCommand(CalculatorReciever calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Substract();
        }
    }
}
