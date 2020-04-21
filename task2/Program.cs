using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            Console.WriteLine("a=");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b=double.Parse(Console.ReadLine());
            if(a>=1 && a<=2 && a>3 && a<7 && b>=1 && b<=2 && b>3 && b<7)
              Console.WriteLine("належить");
            else
              Console.WriteLine("не належить");

        }
    }
}