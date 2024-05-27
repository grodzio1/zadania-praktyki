// zadanie 1
using System;
using System.IO;

namespace a
{
    class zadanie1
    {
        static void Main(string[] args)
        {
            string readFile = File.ReadAllText("test.txt");
            Console.WriteLine("Zawartość pliku: " + readFile);

            char letter = Convert.ToChar("a");
            int count = 0;
            foreach (char a in readFile) {
                if (a==letter) {
                    count++;
                } 
            }
            Console.WriteLine("Ilość wystąpień a w pliku : " + count);
        }
    }
}
