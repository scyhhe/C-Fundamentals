using System;

namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int div = input / 100;
            int per = div % 10;
            if (per == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", per);
            }
         }         
    }
}   
