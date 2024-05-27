using System;
using System.IO;

namespace zamiana
{
    class zadanie2
    {
        static void Main(string[] args)
        {
            string readFile = File.ReadAllText("praca.txt");
            Console.WriteLine("Oryginalny plik: " + readFile);

            readFile = readFile.Replace("praca", "job");
            File.WriteAllText("praca_changed.txt", readFile);
            Console.WriteLine("Zmieniony plik : " + File.ReadAllText("praca_changed.txt"));
        }
    }
}