using System;

namespace MMSA
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double min, max, avg;
            double sum = 0;       

            if (N > 1 && N < 1000)
            {
                for (int i = 0; i <= N; i++)
                {
                    int nN = int.Parse(Console.ReadLine());
                    sum += nN;

                }

                
            }
        }
    }
 }