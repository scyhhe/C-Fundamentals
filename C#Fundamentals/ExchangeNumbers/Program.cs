using System;

namespace ExchangeNumbers
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double ex = 0;
            if (A > B)
            {
                ex = A;
                A = B;
                B = ex;
                
            }
            Console.WriteLine("{0} {1}", A, B);
        }
    }
}
