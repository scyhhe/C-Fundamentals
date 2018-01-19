using System;

namespace BiggestOf3
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            double E = double.Parse(Console.ReadLine());
            double X = 1;

            if (A >= B && A >= C && A >= D && A >= D)
            {
                X = A;
            }
            else if (B >= A && B >= C && B>= D & B >= E)
            {
                X = B;
            }
            else if (C >= A && C >= B && C >= D && C >= E)
            {
                X = C;
            }
            else if (D >= A && D >= B && D >= C && D >= E)
            {
                X = D;
            }
            else
            {
                X = E;
            }
            Console.WriteLine(X);
        }
    }
}