using System;
using System.Globalization;

namespace Mosaic
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo bs = new CultureInfo("bs-Latn-BA");
            CultureInfo.CurrentCulture = bs;
            DisplayCurrentCulture();
            DisplayDateTime();

            CultureInfo en = new CultureInfo("en-US");
            CultureInfo.CurrentCulture = en;
            DisplayCurrentCulture();
            DisplayDateTime();

            Console.ReadLine();
        }

        static void DisplayCurrentCulture()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DisplayName);
            Console.WriteLine("=======================================");
        }

        static void DisplayDateTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
