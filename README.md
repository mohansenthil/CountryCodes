# Country Codes Library

The Country Code Library provides a collection of two-letter and three-letter country codes according to the ISO 3166-1 standard.
Additionaly it provides USA, China and Canada Province codes (State codes / adminstrative division codes).

This library can be accessed with ease through static fields by any .NET framework.

## Installation

To install the Country Codes Library, use the NuGet package manager in Visual Studio or run the following command in the Package Manager Console:

```bash
Install-Package CountryCodesLib
```

## Usage

After installing the Country Codes Library, you can use it in your project to retrieve two letter and three letter country codes. Here are some examples:

```cs
using CountryCodes;
using CountryCodes.Canada;
using CountryCodes.China;
using CountryCodes.UnitedStates;


Console.WriteLine($"USA's Two Letter Country Code is {TwoLetterISORegionCode.UnitedStates}");
Console.WriteLine($"India's Three letter Country Code is {ThreeLetterISORegionCode.India}");

Console.WriteLine($"Alabama's Two letter State code is {USAStateCode.Alabama}");
Console.WriteLine($"Ontario's Two letter Province code is {CanadaProvinceCode.Ontario}");
Console.WriteLine($"Beijing's Two letter Province code is {ChinaProvinceCode.Beijing}");

```

## Output
```console
USA's Two Letter Country Code is US
India's Three letter Country Code is IND
Alabama's Two letter State code is AL
Ontario's Two letter Province code is ON
Beijing's Two letter Province code is BJ
```