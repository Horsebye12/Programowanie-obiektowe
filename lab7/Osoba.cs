using System;
using System.Linq;
using System.Collections.Generic;

namespace klasy
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public enum plec {K, M};

        public int ObliczWiek()
        {
            int aktualnyRok = Convert.ToInt32(DateTime.Now.Year);
            return aktualnyRok - this.rokUrodzenia; 
        }

        public void BMI()
        {
            double bmi = this.waga / Math.Pow(this.wzrost, 2);
            switch(bmi)
            {
                case bmi<18.5:
                    Console.Write("Niedowaga");
                    break;
                case bmi>=18.5 && bmi<=24.9:
                    Console.Write("Waga prawidłowa");
                    break;
                case bmi>=25 && bmi<=29.9:
                    Console.Write("Nadwaga");
                    break;
                case bmi>=30:
                    Console.Write("Otyłość");
                    break; 
            }
        }

        public void pokazDyrektora(string gender)
        {
            if (gender == this.plec.M)
            {
                Console.WriteLine($"Dyrektorem jest: Pan {this.imie} {this.nazwisko}");
            }
            else if (gender == this.plec.K)
            {
                Console.WriteLine($"Dyrektorem jest Pani {this.imie} {this.nazwisko}");
            }
            else
            {
                Console.WriteLine("Podano niepoprawną płeć");
            }
        }
    }
}
