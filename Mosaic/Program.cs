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
            CultureInfo en = new CultureInfo("en-US");
            CultureInfo.CurrentCulture = en;
            DisplayCurrentCulture();

            Console.ReadLine();
        }

        static void DisplayCurrentCulture()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.WriteLine(CultureInfo.CurrentCulture.DisplayName);
            Console.WriteLine("=======================================");
        }
    }
}
