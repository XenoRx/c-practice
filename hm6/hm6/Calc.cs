using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6
{
    public class Calc : InterfaceCalc
    {
        public double Result { get; set; } = 0D;
        

        /*public event EventHandler<EventArgs> MyEventHandler;
        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }*/

        public void Divide(double x, double y)
        {
            if (y != 0)
            {
                Result = x / y;
            }
            else
            {
                Console.WriteLine("Делить на ноль нельзя!");
                throw new CalcDivideByZeroException();
            }
        }

        public void Multy(double x, double y)
        {
            Result = x * y;
            
        }

        public void Sub(double x, double y)
        {
            Result = x - y;
            
        }

        public void Sum(double x, double y)
        {
            Result = x + y;
            
        }

        /*public void CancelLast()
        {
            if (LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено, результат равен: ");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Невозможно отменить последнее действие");
            }
        }*/
    }
}
