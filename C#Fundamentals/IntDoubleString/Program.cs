using System;

namespace IntDoubleString
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            switch(type)
            {
                case "integer":
                    int integer = int.Parse(Console.ReadLine());
                    integer++;
                    Console.WriteLine(integer);
                    break;

                case "real":
                    double real = double.Parse(Console.ReadLine());
                    real++;
                    Console.WriteLine("{0:0.00}", real);
                    break;

                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine("{0}*", text);
                    break;
            }
        }
    }
}
