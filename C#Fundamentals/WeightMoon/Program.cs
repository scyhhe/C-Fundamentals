using System;

namespace WeightMoon
{
    class Program
    {
        static void Main()
        {
            string weight = Console.ReadLine();
            double toDouble = Convert.ToDouble(weight);
            if (toDouble >= 0 && toDouble <= 1000 )
            {
                var test = Math.Round(toDouble * 0.17, 3);
                Console.WriteLine("{0:0.000}", test);
            }
        }
    }
}
