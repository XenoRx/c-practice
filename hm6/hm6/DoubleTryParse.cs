using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm6
{

    public class DoubleTryParse
    {
        public double TryParse(string input)
        {
            double result;

            try
            {
                result = Convert.ToDouble(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение, ожидалось число.");
                return 0;
            }
            catch (CalcDivideByZeroException)
            {
                Console.WriteLine("Попытка деления на ноль!");
                return 0;
            }

            return result;
        }
    }
    /*public class DoubleTryParse
    {
        public bool DoubleTryParseFunc(string s, out double result)
        {
            if (double.TryParse(s, out result))
            {
                if (result < 0)
                {
                    throw new ArgumentException("Число не может быть отрицательным");
                }
                return true;
            }
            return false;
        }
    }*/
}
