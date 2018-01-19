using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perim = 2 * Math.PI * r;
            if (r > 0)
            {
                Console.WriteLine("{0:0.00} {1:0.00}", perim, area);
            }
        }
    }
}
