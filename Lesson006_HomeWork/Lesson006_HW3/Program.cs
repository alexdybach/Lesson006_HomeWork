using System;
using System.Text;

namespace Lesson006_HW3
{
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error! Ділення на нуль!");
            }
            else
            {
                double div = (double)a / b;
                Console.WriteLine(div);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            Console.WriteLine("Введіть два числа:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть знак арифметичної операції:  (+ - * /)");
            string sign = Console.ReadLine();
            Console.Write($"{a} {sign} {b} = ");

            switch (sign)
            {
                case "+":
                    {
                        Add(a, b);
                        break;
                    }
                case "-":
                    {
                        Sub(a, b);
                        break;
                    }
                case "*":
                    {
                        Mul(a, b);
                        break;
                    }
                case "/":
                    {
                        Div(a, b);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong sign!");
                        break;
                    }
            }
        }
    }
}
