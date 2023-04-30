using System;
using CountryCodes;
using CountryCodes.Canada;
using CountryCodes.China;
using CountryCodes.UnitedStates;

namespace TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"USA's Two Letter Country Code is {TwoLetterISORegionCode.UnitedStates}");
            Console.WriteLine($"India's Three letter Country Code is {ThreeLetterISORegionCode.India}");

            Console.WriteLine($"Germany's Telephone Code is {CountryCallingCodes.Germany}");

            Console.WriteLine($"Alabama's Two letter State code is {USAStateCode.Alabama}");
            Console.WriteLine($"Ontario's Two letter Province code is {CanadaProvinceCode.Ontario}");
            Console.WriteLine($"Beijing's Two letter Province code is {ChinaProvinceCode.Beijing}");
        }
    }
}
