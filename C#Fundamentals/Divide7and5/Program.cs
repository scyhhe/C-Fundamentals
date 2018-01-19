using System;

namespace Divide7and5
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 7 == 0 && input % 5 == 0)
            {
                Console.WriteLine("{0} {1}", "true", input);
            }
            else
            {
                Console.WriteLine("{0} {1}", "false", input);
            }
        }
    }
}
