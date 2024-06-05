using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Console
{
    internal class DivideBy3: IDivide
    {
        DivideResult result = new DivideResult();
        public DivideResult Validate(int value)
        {
            result.isDivisible = false;
            result.index = 0;
            result.OperationMessage = $"Divided {value} by 3";

            if (value % 3 == 0)
            {
                result.isDivisible = true;
                result.Message = "Fizz";
            }
            return result;
        }
    }
}
