# mosaic
DotNet Core Sample App Using i18n

## Notes

Culture info in a console app is influenced by host os, in Windows this is specified in the Regional Settings.

CultureInfo for the app can be modified by creating a new CultureInfo object and setting it as the CurrentCulture:

```csharp
using System;
using System.Globalization;

namespace Mosaic
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo en = new CultureInfo("en-US");
            CultureInfo.CurrentCulture = en;
            Console.WriteLine(CultureInfo.CurrentCulture);
            Console.ReadLine();
        }
    }
}
```