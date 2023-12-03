using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6
{
    public interface InterfaceCalc
    {
        double Result { get; set; }
        public void Sum(double x, double y);
        public void Sub(double x, double y);
        public void Multy(double x, double y);
        public void Divide(double x, double y);

    }
}
