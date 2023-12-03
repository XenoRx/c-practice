using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите выражение: ('выход' для остановки программы): ");
            string input = Console.ReadLine();

            if (input == "выход")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length != 3)
            {
                Console.WriteLine("Неверный ввод, введите что то вроде -> '2 + 3'.");
                continue;
            }

            double a, b;
            if (!double.TryParse(parts[0], out a))
            {
                Console.WriteLine("Неверное число: " + parts[0]);
                continue;
            }

            if (!double.TryParse(parts[2], out b))
            {
                Console.WriteLine("Неверное число: " + parts[2]);
                continue;
            }

            switch (parts[1])
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Нельзя делить на ноль");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
                default:
                    Console.WriteLine("Неверный арифметический знак: " + parts[1]);
                    break;
            }
        }

        Console.WriteLine("Досвидания!");
    }
}