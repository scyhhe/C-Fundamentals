using System;

namespace Sort3
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if (A >= B && A >= C && B >= C)
            {
                Console.WriteLine("{0} {1} {2}", A, B, C);
            }
            else if (B >= A && B >= C && A >= C)
            {
                Console.WriteLine("{0} {1} {2}", B, A, C);
            }
            else if (C >= A && C >= B && A >= B)
            {
                Console.WriteLine("{0} {1} {2}", C, A, B);
            }
            else if (A >= B && A >= C && C >= B)
            {
                Console.WriteLine("{0} {1} {2}", A, C, B);
            }
            else if (B >= A && B >= C && C >= A)
            {
                Console.WriteLine("{0} {1} {2}", B, C, A);
            }
            else if(C >= A && C >=B && B >= A)
            {
                Console.WriteLine("{0} {1} {2}", C, B, A);
            }
        }
    }
}
