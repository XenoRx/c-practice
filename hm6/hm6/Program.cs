using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите выражение ('выход' для выхода): ");
            string input = Console.ReadLine();

            if (input == "выход")
                break;

            string[] parts = input.Split(' ');

            if (parts.Length != 3)
            {
                Console.WriteLine("Неверный ввод, введите что-то вроде '2.5 + 3'");
                continue;
            }

            double a, b;
            try
            {
                if (!DoubleTryParse(parts[0], out a))
                {
                    Console.WriteLine("Неверное число: " + parts[0]);
                    continue;
                }

                if (!DoubleTryParse(parts[2], out b))
                {
                    Console.WriteLine("Неверное число: " + parts[2]);
                    continue;
                }
            } catch (ArgumentException e){
               Console.WriteLine(e.Message);
                continue;
            }
            /*
              if (a < 0 || b < 0)
            {
                Console.WriteLine("Числа не могут быть отрицательными");
                continue;
            }
            */

            double result;

            switch (parts[1])
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    if (result < 0)
                    {
                        Console.WriteLine("Разность не может быть отрицательной");
                        continue;
                    }
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        continue;
                    }

                    result = a / b;
                    break;

                default:
                    Console.WriteLine("Неверный оператор: " + parts[1]);
                    continue;
            }

            Console.WriteLine(result);
        }

        Console.WriteLine("До свидания!");
    }

    static bool DoubleTryParse (string s, out double result)
    {
        if( double.TryParse(s, out result)){
            if (result < 0)
            {
                throw new ArgumentException("Число не может быть отрицательным");
            }
            return true;
        }
        return false;
    }
}