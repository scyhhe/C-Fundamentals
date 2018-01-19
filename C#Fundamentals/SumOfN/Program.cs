using System;

namespace SumOfN
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
            
        }
    }
}
