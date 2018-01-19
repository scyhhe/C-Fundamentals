using System;

namespace Quadratic
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;


            string noroot = "no real roots";
            string newL = "\r\n";

            double x1 = (((-1) * b) + Math.Sqrt(D)) / (2 * a);
            double x2 = (((-1) * b) - Math.Sqrt(D)) / (2 * a);

            if (D > 0)
            {
                if (x1 > x2)
                {
                    Console.WriteLine("{0:0.00}{1}{2:0.00}", x2, newL, x1);
                }
                else
                {
                    Console.WriteLine("{0:0.00}{1}{2:0.00}", x1, newL, x2);
                }

            }
            else if (D == 0 && x1 == x2)
            {
                Console.WriteLine("{0:0.00}", x1);
            }
            else
            {
                Console.WriteLine(noroot);
            }
        }
    }
}
