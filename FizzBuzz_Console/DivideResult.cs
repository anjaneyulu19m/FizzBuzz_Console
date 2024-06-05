using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Console
{
    internal class DivideResult
    {
        public int index { get; set; }
        public bool isDivisible { get; set; }
        public string? Message { get; set; }
        public string OperationMessage { get; set; } = string.Empty;
    }

    internal class Result
    {
        public bool isDivisible { get; set; }
        public Dictionary<int, string>? Messages { get; set; }
        public Dictionary<int, string>? OperationMessages { get; set; }
    }
}
