using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, N, C;
            Console.WriteLine("A=");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("N=");
            N = double.Parse(Console.ReadLine());
            Console.WriteLine("C=");
            C = double.Parse(Console.ReadLine());

            if (A == N && C == N)
            {
                Console.WriteLine(Math.Cos(A + C + N));
            }
            else if (A < C && C == N)
            {
                Console.WriteLine(Math.Cos(A * C * N));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}