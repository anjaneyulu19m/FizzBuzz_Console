using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Console
{
    internal interface IDivide
    {
        public DivideResult Validate(int value);
    }
}
