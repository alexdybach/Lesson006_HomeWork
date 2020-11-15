using System;
using System.Text;

namespace Lesson006_HW5
{
    class Program
    {
        static void Check(int number)
        {
            if(number>0)
                Console.WriteLine("Число додатнє");
            else if(number<0)
                Console.WriteLine("Число від'ємне");
            else
                Console.WriteLine("Число = 0");
            int count = 0;
            for(int i=1;i<=number;i++)
            {
                if (number % i == 0)
                    count++;
            }
            if(count<=2)
                Console.WriteLine("Просте число");
            else
                Console.WriteLine("Число не просте");

            if (number % 2 == 0)
                Console.WriteLine("Число ділиться націло на 2");
            if (number % 3 == 0)
                Console.WriteLine("Число ділиться націло на 3");
            if (number % 5 == 0)
                Console.WriteLine("Число ділиться націло на 5");
            if (number % 6 == 0)
                Console.WriteLine("Число ділиться націло на 6");
            if (number % 9 == 0)
                Console.WriteLine("Число ділиться націло на 9");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число:");
            int numb = int.Parse(Console.ReadLine());
            Check(numb);
        }
    }
}
