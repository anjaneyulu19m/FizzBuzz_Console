using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Console
{
    internal class DivideBy5: IDivide
    {
        DivideResult result = new DivideResult();
        public DivideResult Validate(int value)
        {
            result.isDivisible = false;
            result.index = 1;
            result.OperationMessage = $"Divided {value} by 5";

            if (value % 5 == 0)
            {
                result.isDivisible = true;
                result.Message = "Buzz";
            }
            return result;
        }
    }
}
