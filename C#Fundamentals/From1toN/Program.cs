using System;

namespace From1toN
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 1 && N < 1000)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
