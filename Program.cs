using System;

namespace ConsoleCalcApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runCalculator = true;

            do
            {
                Console.WriteLine("\t[a] - addition");
                Console.WriteLine("\t[s] - subtraktion");
                Console.WriteLine("\t[m] - multiplikation");
                Console.WriteLine("\t[d] - division\r\n");
                Console.WriteLine("\t[q] - avsluta kalkylatorn\r\n");

                char operation = Console.ReadKey(true).KeyChar;
                double number1 = 0;
                double number2 = 0;

                switch (operation)
                {
                    case 'a':
                        number1 = InputNumber("första talet: ");
                        number2 = InputNumber("andra talet: ");
                        Console.WriteLine(Addition(number1, number2));
                        break;
                    case 's':
                        number1 = InputNumber("första talet: ");
                        number2 = InputNumber("andra talet: ");
                        Console.WriteLine(Subtraction(number1, number2));
                        break;
                    case 'm':
                        number1 = InputNumber("första talet: ");
                        number2 = InputNumber("andra talet: ");
                        Console.WriteLine(Multiplication(number1, number2));
                        break;
                    case 'd':
                        number1 = InputNumber("första talet: ");
                        number2 = InputNumber("andra talet: ");
                        Console.WriteLine(Division(number1, number2));
                        break;
                    case 'q':
                        runCalculator = false;
                        break;
                }

                if (runCalculator)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.ReadKey();
                }
            }
            while (runCalculator);
        }
        private static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        private static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        private static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        private static double Division(double number1, double number2)
        {
            if (number2 == 0)
            {
                Console.WriteLine("Mattematiskt fel)");
            }
            return number1 / number2;

        }

        static double InputNumber(string foo)
        {
            bool notNumber = true;
            double number = 0;

            while (notNumber)
            {
                if (double.TryParse(GetInputFromUser(foo), out number))
                {
                    notNumber = false;
                }
                else
                {
                    Console.WriteLine("Du angav inte ett tal");
                }
            }

            return number;
        }

        static string GetInputFromUser(string foo)
        {
            Console.Write($"Ange {foo} ");
            return Console.ReadLine();
        }
    }
}
