using System;

namespace DigitAsWord
{
    class Program
    {
        static void Main()
        {
            string X = (Console.ReadLine());
            string asNum = "";
            switch(X)
            {
                case "1":
                    asNum = "one";
                    break;
                case "2":
                    asNum = "two";
                    break;
                case "3":
                    asNum = "three";
                    break;
                case "4":
                    asNum = "four";
                    break;
                case "5":
                    asNum = "five";
                    break;
                case "6":
                    asNum = "six";
                    break;
                case "7":
                    asNum = "seven";
                    break;
                case "8":
                    asNum = "eight";
                    break;
                case "9":
                    asNum = "nine";
                    break;
                default:
                    asNum = "not a digit";
                    break;
            }
            Console.WriteLine(asNum);
        }
    }
}
