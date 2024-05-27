using System;
using System.IO;

namespace test
{
    class zadanie4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kwotę w PLN:");
            float PLN = float.Parse(Console.ReadLine());
            float USD = 4.01F; // kurs z dnia 06.05.2024
            float conversion = PLN / USD;
            
            Console.WriteLine(PLN + " PLN to " + conversion.ToString("n2") + " USD");
        }
    }
}