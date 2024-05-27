using System;
using System.IO;
using System.Text;

namespace csv
{
    class zadanie3
    {
        static void Main(string[] args)
        {
            string outputFile = $"users-{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("LP,Imię,Nazwisko,Rok urodzenia");

                Random random = new Random();
                for (int i = 1; i <= 100; i++)
                {
                    string name = GetRandomFirstName(random);
                    string surname = GetRandomLastName(random);
                    int birth = random.Next(1990, 2001);

                    writer.WriteLine($"{i},{name},{surname},{birth}");
                }
            }

            Console.WriteLine($"Wygenerowany plik: {outputFile}");
        }


        static string GetRandomFirstName(Random random)
        {
            string[] names = { "Ania", "Kasia", "Basia", "Zosia" };
            return names[random.Next(names.Length)];
        }

        static string GetRandomLastName(Random random)
        {
            string[] surnames = { "Kowalska", "Nowak" };
            return surnames[random.Next(surnames.Length)];
        }
    }
}