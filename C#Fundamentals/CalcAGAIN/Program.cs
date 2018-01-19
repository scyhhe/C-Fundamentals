using System;

namespace CalcAGAIN
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            long sum = 1;
            long sum2 = 1;
            long sum3 = 1;

            if (N > K)
            {

                for (int i = 1; i <= N; i++)
                {
                    
                    sum *= i;
                    sum2 *= i;
                    if (i == K)
                    {
                        sum3 = sum2 * 1;
                    }
                }
            }

            Console.WriteLine(sum / sum3);
        }
    }
}
