using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double diff;
            double eps = 0.000001;
            bool Equal;

            if (a < b)
            {
                diff = b - a;
                Equal = diff < eps;
                if (Equal == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                diff = a - b;
                Equal = diff < eps;
                if (Equal == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
