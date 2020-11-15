using System;
using System.Text;

namespace Lesson006_HW4
{
    class Program
    {
        static decimal Exchange(decimal a, double b)
        {
            return a * (decimal)b;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть суму та курс валюти");
            decimal money = decimal.Parse(Console.ReadLine());
            double curs = double.Parse(Console.ReadLine());

            Console.WriteLine($"Результат = {Exchange(money,curs)}");
        }
    }
}
