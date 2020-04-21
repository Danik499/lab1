using System;

public class Program
{
    static void Main(string[] args)
    {
        int a, b;
        double u;

        Console.WriteLine("a = ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("b = ");
        b = int.Parse(Console.ReadLine());

        u = f(a, b) + f(2, a) + 2;
        Console.WriteLine(u);
    }
    static double f(int x, int y)
    {
        if (x > y)
        {
            return Math.Pow(x, 3) + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 4));
        }
        else
        {
            return (Math.Pow(x, 2) - 2 * x + Math.Sqrt(x)) / Math.Sqrt(Math.Pow(x, 3));
        }
    }
}