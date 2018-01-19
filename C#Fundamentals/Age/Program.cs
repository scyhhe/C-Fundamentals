using System;

namespace Age
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Today;
            Console.WriteLine("Enter your birthday:");
            var input = Console.ReadLine();
            DateTime bday = DateTime.ParseExact(input, "d.m.yyyy", null);
            int age = now.Year - bday.Year;
            if (bday.Year >= 2017)
            {
                Console.WriteLine("Not a valid entry");
            }
            else
            {
                Console.WriteLine(age);
                Console.WriteLine(age + 10);
            }
        }
    }
}
