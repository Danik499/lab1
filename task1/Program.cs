using System;
namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, x3, y3;
            Console.WriteLine("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("y1 = ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x2 = ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("y2 = ");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("x3 = ");
            x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("y3 = ");
            y3 = double.Parse(Console.ReadLine());
            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("s={0}", s);

        }
    }
}