﻿using System;

namespace LAB9
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt32(Console.ReadLine());

            (int wynik, int reszta) = liczba.Podziel(3);
            Console.WriteLine($"{liczba}/3={wynik}r{reszta}");


            string text = "Ala ma kota";
            Console.WriteLine(text.IloscZnakow('a'));

            Reklama reklama = new Reklama("Kup Teraz", TypOsoby.Dziecko | TypOsoby.Mlodziez | TypOsoby.Starszy, Zainteresowania.Gaming);
            reklama.test();
            Console.ReadKey();
        }
    }
}
