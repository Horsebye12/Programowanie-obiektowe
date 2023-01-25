using System;
using System.Linq;
using System.Collections.Generic;

namespace lab8
{
    class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {
        }
    }
    class Obliczenia
    {
        private double _liczba1;
        private double _liczba2;

        public Obliczenia(double liczba1, double liczba2)
        {
            _liczba1 = liczba1;
            _liczba2 = liczba2;
        }

        public double Dodawanie()
        {
            return _liczba1 + _liczba2;
        }

        public double Odejmowanie()
        {
            return _liczba1 - _liczba2;
        }

        public double Mnozenie()
        {
            return _liczba1 * _liczba2;
        }

        public double Dzielenie()
        {
            try
            {
                if (_liczba2 == 0) throw new CalculatorException("Nie można dzielić przez zero!");
                return _liczba1 / _liczba2;
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public double Potegowanie()
        {
            return Math.Pow(_liczba1, _liczba2);
        }

        public double Pierwiastkowanie()
        {
            try
            {
                if (_liczba1 < 0) throw new CalculatorException("Nie można pierwiastkować liczby ujemnej!");
                return Math.Pow(_liczba1, 1 / _liczba2);
            }
            catch (CalculatorException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Podaj pierwszą liczbę do obliczeń: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Podaj drugą liczbę do obliczeń: ");
        double b = double.Parse(Console.ReadLine());

        Obliczenia obliczenia = new Obliczenia(a, b);
            try
            {
                Console.WriteLine("Wynik dodawania: " + obliczenia.Dodawanie());
                Console.WriteLine("Wynik odejmowania: " + obliczenia.Odejmowanie());
                Console.WriteLine("Wynik mnożenia: " + obliczenia.Mnozenie());
                Console.WriteLine("Wynik dzielenia: " + obliczenia.Dzielenie());
                Console.WriteLine("Potęga: " + obliczenia.Potegowanie());
                Console.WriteLine("Pierwiastek: " + obliczenia.Pierwiastkowanie());
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Koniec obliczeń");
            }
        }
    }
}