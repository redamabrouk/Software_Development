using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    //'ConcreteCommand1' class
    public class AddCommand : ICommand
    {
        private CalculatorReciever _calculator;

        public AddCommand(CalculatorReciever calculator)
        {
            _calculator = calculator;
        }

        public int Execute()
        {
            return _calculator.Add();
        }
    }
}
