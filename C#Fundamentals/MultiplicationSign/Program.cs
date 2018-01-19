using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double result = A * B * C;
            if (result > 0)
            {
                Console.WriteLine("+");
            }
            else if(result == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
