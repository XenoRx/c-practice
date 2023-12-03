using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6
{
    internal class CalcException : Exception
    {
        public CalcException() { }
        public CalcException(string error) : base(error)
        {

        }
    }

}
