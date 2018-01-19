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
            double X = 1;

            if (A >= B && A >= C) {
                X = A;
            }
            else if(B >= A && B >= C)
            {
                X = B;
            }
            else
            {
                X = C;          
            }
            Console.WriteLine(X);
        }
    }
}
