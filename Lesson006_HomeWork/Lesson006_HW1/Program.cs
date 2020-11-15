using System;
using System.Text;

namespace Lesson006_HW1
{
    class Program
    {
        static void Calculate(int a, int b, int c)
        {
            int count = 3;
            double average = (a + b + c) / count;
            Console.WriteLine($"Середнє арифметичне = {average}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть три числа для знаходження середнього арифметичного :");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Calculate(a, b, c);
        }
    }
}
