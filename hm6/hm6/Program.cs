using hm6;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        DoubleTryParse doubleTryParse = new DoubleTryParse();
        bool isExit = true;

        while (isExit)
        {
            InterfaceCalc calc = new Calc();
            
            Console.WriteLine("Введите первое число: ");
            double number1 = doubleTryParse.TryParse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double number2 = doubleTryParse.TryParse(Console.ReadLine());
            Console.WriteLine("Select an action \n1. + \n2. - \n3. / \n4. *");
            int mathSymbol = Convert.ToInt32(Console.ReadLine());

            switch (mathSymbol)
            {
                case 1: calc.Sum(number1, number2); break;
                case 2: calc.Sub(number1, number2); break;
                case 3:
                    try
                    {
                        calc.Divide(number1, number2); break;
                    }
                    catch (CalcDivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (CalcException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                case 4: calc.Multy(number1, number2); break;
            }
            Console.WriteLine("Нажмите 'ESC' чтобы выйти из программы");
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                isExit = false;
            }
            Console.Clear();

        }

    }
}