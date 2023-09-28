# Country Codes Library

The Country Code Library provides a collection of two-letter and three-letter country codes according to the ISO 3166-1 standard,
as well as it provides USA, China and Canada Province codes (State codes / adminstrative division codes).
In addition, it includes telephone calling codes, currency codes, currency Symbols for countries across the world. 

This library can be accessed with ease through static fields by any .NET framework.

## Installation

To install the Country Codes Library, use the NuGet package manager in Visual Studio or run the following command in the Package Manager Console:

```bash
Install-Package CountryCodesLib
```

## Usage

After installing the Country Codes Library, you can use it in your project to retrieve two letter, three letter country codes, Telephone calling codes and State/Province/Administrative Divion. Here are some examples:

```cs
using CountryCodes;
using CountryCodes.Canada;
using CountryCodes.China;
using CountryCodes.UnitedStates;


Console.WriteLine($"USA's Two Letter Country Code is {TwoLetterISORegionCode.UnitedStates}");
Console.WriteLine($"India's Three letter Country Code is {ThreeLetterISORegionCode.India}");

Console.WriteLine($"Germany's Telephone Code is {CountryCallingCodes.Germany}");

Console.WriteLine($"Alabama's Two letter State code is {USAStateCode.Alabama}");
Console.WriteLine($"Ontario's Two letter Province code is {CanadaProvinceCode.Ontario}");
Console.WriteLine($"Beijing's Two letter Province code is {ChinaProvinceCode.Beijing}");

Console.WriteLine($"Bangladesh Currency Code {CountryCurrencyCodes.Bangladesh}");
Console.WriteLine($"Japan Currency Symbol {CountryCurrencySymbols.Japan}");

```

## Output
```console
USA's Two Letter Country Code is US
India's Three letter Country Code is IND
Germany's Telephone Code is +49
Alabama's Two letter State code is AL
Ontario's Two letter Province code is ON
Beijing's Two letter Province code is BJ
Bangladesh Currency Code BDT
Japan Currency Symbol ¥
```