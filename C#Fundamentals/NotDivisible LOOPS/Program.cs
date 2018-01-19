using System;

namespace NotDivisible_LOOPS
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (1 < n && n < 1500)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 || i % 7 == 0)
                    {
                        continue;
                    }
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}
