using System;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool isG = a > b;
            switch(isG)
            {
                case false:
                    Console.WriteLine(b);
                    break;
                case true:
                    Console.WriteLine(a);
                    break;
            }
        }
    }
}
