using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int GCD;
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int remainder = 0;

    

            if (A == 0)
            {
                GCD = B;
            }
            else if(B == 0)
            {
                GCD = B;
            }
            
            if (A > B)
            {
                remainder = A % B;
                A = B;
                B = remainder;
            }
            else
            {
                remainder = B % A;
                B = A;
                A = remainder;
            }
            
        
        }
    }
}
