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

We can test that the `CultureInfo.CurrentCulture` has changed as shown below:

```csharp
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

```

This outputs:

```
=======================================
bs-Latn-BA
Bosnian (Latin, Bosnia and Herzegovina)
=======================================
=======================================
en-US
English (United States)
=======================================
```

Display format of DateTime is affected by the currently set Culture.

```csharp
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

```

This outputs:

```csharp
=======================================
bs-Latn-BA
Bosnian (Latin, Bosnia and Herzegovina)
=======================================
7.10.2017 23:49:09
=======================================
en-US
English (United States)
=======================================
10/7/2017 11:49:09 PM
```