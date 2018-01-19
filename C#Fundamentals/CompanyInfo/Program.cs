using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string cN = Console.ReadLine();
            string cA = "Address: " + Console.ReadLine();
            string pN = "Tel. " + Console.ReadLine();
            string fax = "Fax:" + Console.ReadLine();
            string web = "Web site: " + Console.ReadLine();
            string fN = Console.ReadLine();
            string lN = Console.ReadLine();
            string age = "(age: " + Console.ReadLine() + ",";
            string mP = " tel. " + Console.ReadLine() + ")";
            string manager = "Manager: " + fN + " " + lN + " " + age + mP;
            string nofax = "Fax: (no fax)";
            string n = "\r\n";

            if (fax.Length < 5)
            {
                fax = nofax;
            }

            Console.WriteLine(cN + n + cA + n + pN + n + fax + n + web + n + manager);

        }
    }
}
