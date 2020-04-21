using System;

public class Program
{
    public static void Main()
    {
        int n, a;
        Console.WriteLine("n=");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("a=");
        a = int.Parse(Console.ReadLine());
        double d;
        int c;
        double sum = 0;
        for (c = 2, d = a; c <= 2 * n; c++, d += (a + 1))
            sum += c / d;
        Console.WriteLine("sum={0:f3}", sum);
    }
}