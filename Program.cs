using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę n: ");
            int n = int.Parse(Console.ReadLine());
            int wynik = n * n + 1;
            Console.WriteLine($"Wynik n^2 + 1 to: {wynik}");
        }
    }
}
