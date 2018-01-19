using System;

namespace PrimeCheck
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input <= 100 && input > 0 && input > 1)
            {
                for (var i = 2; i < Math.Sqrt(input); i++)
                {
                    if (input % i == 0)
                    {
                        Console.WriteLine("false");
                    }
                }
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
