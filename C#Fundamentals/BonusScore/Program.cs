using System;

namespace BonusScore
{
    class Program
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            switch(X)
            {
                case 1:
                case 2:
                case 3:
                    X *= 10;
                    Console.WriteLine(X);
                    break;
                case 4:
                case 5:
                case 6:
                    X *= 100;
                    Console.WriteLine(X);
                    break;
                case 7:
                case 8:
                case 9:
                    X *= 1000;
                    Console.WriteLine(X);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }   
        }
    }
}
