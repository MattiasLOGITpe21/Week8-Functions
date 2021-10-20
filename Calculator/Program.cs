using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage esimene number:");
            int numberx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisestage teine number:");
            int numbery = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '/', '-', '*'):");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch(userOperator)
            {
                case '+':
                    AddTwoNumbers(numberx, numbery);
                    break;
                case '/':
                    DivideTwoNumbers(numberx, numbery);
                    break;
                case '-':
                    SubtractTwoNumbers(numberx, numbery);
                    break;
                case '*':
                    MultiplyTwoNumbers(numberx, numbery);
                    break;
            }
        }

        private static void AddTwoNumbers(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} : {y} = {result}");
        }

        private static void SubtractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

        private static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
    }
}
