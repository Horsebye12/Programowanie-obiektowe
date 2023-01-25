using System;
using System.Linq;
using System.Collections.Generic;
using static klasy.Osoba;
using static klasy2.Product;
using static klasy2.ShoppingCart;
using static zespolone.Zespolona;

namespace lab7
{
    class Program
    {
        class Car
        {
            private string marka;
            private int rok;
            private string model;
            private int iloscDrzwi;
            private double pojemnoscSilnika;
            public double srednieSpalanie;

            public Car(string a, int b, string c, int d, double e)
            {
                this.marka = a;
                this.rok = b;
                this.model = c;
                this.iloscDrzwi = d;
                this.pojemnoscSilnika = e;
            }

            public void pokazAuto()
            {
                Console.WriteLine($"Marka auta: {this.marka}, Rok produkcji: {this.rok}");
            }

            private double ObliczSpalanie(double dlugoscTrasy)
            {
                double spalanie = this.srednieSpalanie * dlugoscTrasy;
                return spalanie;
            }

            public double ObliczKosztPrzejazdu(double a, double b)
            {
                double spalanie = ObliczSpalanie(a);
                double kosztPrzejazdu = spalanie * b;
                return kosztPrzejazdu;
            }
        }

        static void Main(string[] args)
        {
            //PROGRAM 1
            // string carName = "Mój samochód";

            // Console.WriteLine(carName);
            // Console.Write("Wprowadź markę samochodu: ");
            // string a = Console.ReadLine();
            // Console.Write("Wprowadź rok produkcji: ");
            // int b = Convert.ToInt32(Console.ReadLine());
            // if(b<=1769 & b>2023)
            // {
            //     Console.Write("WPROWADZONO NIEPRAWIDŁOWY ROK!");
            // }
            // else
            // {
            //     Console.Write("Wprowadź model samochodu: ");
            //     string c = Console.ReadLine();
            //     Console.Write("Wprowadź liczbę dni: ");
            //     int d = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Wprowadź pojemność silnika: ");
            //     double e = Convert.ToDouble(Console.ReadLine());
            //     Car car1 = new Car(a, b, c, d, e);
            //     Console.Write("Podaj średnie spalanie: ");
            //     car1.srednieSpalanie = Convert.ToDouble(Console.ReadLine());
                
            //     Console.Write("Podaj długość trasy: ");
            //     double dlugosc = Convert.ToDouble(Console.ReadLine());
            //     Console.Write("Podaj koszt paliwa za litr: ");
            //     double koszt = Convert.ToDouble(Console.ReadLine());
            //     car1.ObliczKosztPrzejazdu(dlugosc, koszt);
            // }

            //PROGRAM 2
            // Osoba dyrektor = new Osoba();
            // Console.Write("Imie: ");
            // dyrektor.imie = Console.ReadLine();
            // Console.Write("Nazwisko: ");
            // dyrektor.nazwisko = Console.ReadLine();
            // Console.Write("Rok urodzenia: ");
            // dyrektor.rokUrodzenia = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Waga: ");
            // dyrektor.waga = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Wzrost: ");
            // dyrektor.wzrost = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Okulary (T/N): ");
            // string check = Console.ReadLine();
            // if(check == "T")
            // {
            //     dyrektor.okulary = true;
            // }
            // else if(check == "N")
            // {
            //     dyrektor.okulary = false;
            // }
            // else
            // {
            //     Console.Write("BŁĄD PRZY PODAWANIU OKULARÓW! PODAJ T LUB N");
            //     System.Environment.Exit(1);
            // }
            // Console.Write("Płeć (K/M): ");
            // string gender = Console.ReadLine();
            // dyrektor.pokazDyrektora(gender);

            // Osoba pacjent = new Osoba();
            // Console.Write("Imie: ");
            // pacjent.imie = Console.ReadLine();
            // Console.Write("Nazwisko: ");
            // pacjent.nazwisko = Console.ReadLine();
            // Console.Write("Wzrost: ");
            // pacjent.wzrost = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Waga: ");
            // pacjent.waga = Convert.ToInt32(Console.ReadLine());

            // pacjent.BMI();


            //PROGRAM 3
            // ShoppingCart cart = new ShoppingCart();

            // Console.WriteLine("Jeżeli chcesz zakończyć pracę programu i wyświetlić koszyk w trakcie wpisywania nazwy produktu wpisz literę N");
            // while (true)
            // {
            //     Console.WriteLine("Podaj nazwę produktu:");
            //     string name = Console.ReadLine();
            //     if (name.ToUpper() == "N") break;
            //     Console.WriteLine("Podaj cenę produktu:");
            //     double price = Double.Parse(Console.ReadLine());
            //     cart.AddProduct(new Product(name, price));
            // }
            // cart.ShowCart();


            //PROGRAM 4
            Zespolona c1 = new Zespolona(3, 2);
            Zespolona c2 = new Zespolona(1, 7);

            Console.WriteLine("Liczba zespolona 1: " + c1);
            Console.WriteLine("Liczba zespolona 2: " + c2);
            Console.WriteLine("Suma: " + (c1 + c2));
            Console.WriteLine("Różnica: " + (c1 - c2));
            Console.WriteLine("Iloczyn: " + (c1 * c2));
        }
    }
}