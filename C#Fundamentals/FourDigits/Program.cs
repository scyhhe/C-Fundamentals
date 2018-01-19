using System;
namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {           
            string input = Console.ReadLine();
            int a = int.Parse(input[0].ToString());
            int b = int.Parse(input[1].ToString());
            int c = int.Parse(input[2].ToString());
            int d = int.Parse(input[3].ToString());
            
            int sum = a + b + c + d;

            string aa = a.ToString();
            string bb = b.ToString();
            string cc = c.ToString();
            string dd = d.ToString();

            Console.WriteLine(sum);
            Console.WriteLine(dd + cc + bb + aa);
            Console.WriteLine(dd + aa + bb + cc);
            Console.WriteLine(aa + cc + bb + dd);
        }
    }
}
