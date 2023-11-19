using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6
{
    internal class CalcDivideByZeroException : CalcException
    {
        public CalcDivideByZeroException() { }

        public CalcDivideByZeroException(string error) : base(error)
        {
        }
    }
}
