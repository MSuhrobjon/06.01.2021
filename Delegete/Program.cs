using System;

namespace Delegete
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculate <double> operation = new Calculate<double>();
            while (true)
            {
                Console.WriteLine("select a"); double a = double.Parse(Console.ReadLine());
                Console.WriteLine("select symbol"); char symbol = char.Parse(Console.ReadLine());
                
                Console.WriteLine("select b"); double b = double.Parse(Console.ReadLine());


                switch (symbol)
                {
                    case '+':
                        Console.Write(operation.DelSumma(a, b));
                        break;
                    case '-':
                        Console.Write(operation.DelMinus(a, b));
                        break;
                    case '*':
                        Console.Write(operation.DelMultimate(a, b));
                        break;
                    case '/':

                        Console.Write(operation.DelDivide(a,b));
                        if (b == 0)
                        {
                            Console.WriteLine("We connot devide to zero");
                        }
                        break;

                    case '!': return;
                }
                Console.ReadKey();
            }

        }
        class Calculate<T>
        {
            public delegate T Operation(T a, T b);
            public Operation DelSumma = Sum;
            public Operation DelMinus = Sub;
            public Operation DelMultimate = Mul;
            public Operation DelDivide = Div;
            public static T Sum(T a, T b)
            {
                return (dynamic)a + (dynamic)b;
            }
            public static T Sub(T a, T b)
            {
                return (dynamic)a - (dynamic)b;
            }
            public static T Mul(T a, T b)
            {
                return (dynamic)a * (dynamic)b;
            }
            public static T Div(T a, T b)
            {
                return (dynamic)a / (dynamic)b;
            }

        }
    }
}
