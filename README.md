# Country Codes Library

The Country Codes Library provides a collection of two-letter and three-letter country codes according to the ISO 3166-1 standard.

## Installation

To install the Country Codes Library, use the NuGet package manager in Visual Studio or run the following command in the Package Manager Console:

```bash
Install-Package CountryCodesLib
```

## Usage

After installing the Country Codes Library, you can use it in your project to retrieve two letter and three letter country codes. Here are some examples:

```cs
using CountryCodes;

Console.WriteLine($"USA's Two Letter Country Code is {TwoLetterISORegionCode.UnitedStates}");
Console.WriteLine($"India's Three letter Country Code is {ThreeLetterISORegionCode.India}");
```

## Output
```console
USA's Two Letter Country Code is US
India's Three letter Country Code is IND
```