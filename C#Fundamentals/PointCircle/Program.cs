using System;

namespace PointCircle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int r = 2,
                centX = 0,
                centY = 0;
            double distance = Math.Sqrt((x - centX) * (x - centX) + (y - centY) * (y - centY));
            if (Math.Pow((x - centX),2) + Math.Pow((y - centY),2) <= r * r) {

                Console.WriteLine("yes {0:0.00}", distance );
            }
            else
            {
                Console.WriteLine("no {0:0.00}", distance);
            }
        }
    }
}
