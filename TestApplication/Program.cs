using System;
using CountryCodes;
using CountryCodes.UnitedStates;

namespace TestApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"USA's Two Letter Country Code is {TwoLetterISORegionCode.UnitedStates}");
            Console.WriteLine($"India's Three letter Country Code is {ThreeLetterISORegionCode.India}");
            Console.WriteLine($"Alabama's Two letter State code is {USAStateCode.Alabama}");
        }
    }
}
