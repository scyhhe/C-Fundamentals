using System;

namespace Odd_or_even
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();

            int check = Convert.ToInt32(input),
                min = 30*(-1),
                max = 30;
     

            if (check <= max && check >= min)
            {
                if (check % 2 == 0)
                {
                    Console.WriteLine("even " + check);
                }

                else
                {
                    Console.WriteLine("odd " + check);
                }
            }

            else
                {
                    Console.WriteLine("Enter an integer between 30 and -30");
                }

            
        }
    }
}

