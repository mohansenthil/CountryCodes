using System;
using CountryCodes;

namespace TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"USA's Two Letter Country Code is {TwoLetterISORegionCode.UnitedStates}");
            Console.WriteLine($"India's Three letter Country Code is {ThreeLetterISORegionCode.India}");
        }
    }
}
