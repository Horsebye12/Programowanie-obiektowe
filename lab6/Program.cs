using System;
using System.Linq;
using System.Collections.Generic;

namespace lab6
{
    //ZADANIE 1, 2 i 3
    class Prostokat
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private double Powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private double Obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia prostokąta: " + Powierzchnia());
            Console.WriteLine("Obwód prostokąta: " + Obwod());
        }

        public static double NajwiekszaPowierzchnia(Prostokat[] tablicaProstokatow)
        {
            double maxPowierzchnia = 0;
            foreach (Prostokat prostokat in tablicaProstokatow)
            {
                double powierzchnia = prostokat.Powierzchnia();
                if (powierzchnia > maxPowierzchnia)
                {
                    maxPowierzchnia = powierzchnia;
                }
            }
            return maxPowierzchnia;
        }
    }

    //ZADANIE 4
    class LicznikEnergii
    {
        private double poczatkowyStan;
        private double biezacyStan;

        public LicznikEnergii (double stanP, double stanB)
        {
            this.poczatkowyStan = stanP;
            this.biezacyStan = stanB;
        }

        public void StanyLicznika()
        {
            Console.WriteLine($"Początkowy stan licznika: {this.poczatkowyStan}");
            Console.WriteLine($"Bieżący stan licznika: {this.biezacyStan}");
        }

        public double ZuzytaEnergia()
        {
            return biezacyStan - poczatkowyStan;
        }
    }

    //ZADANIE 5, 6 i 7
    class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punkt(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Punkt()
        {
            X = 0;
            Y = 0;
        }

        public void Przesun(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Aktualne współrzędne punktu: (" + X + "," + Y + ")");
        }

        public static bool jednaProsta(Punkt[] punkty)
        {
            double a = (punkty[1].Y - punkty[0].Y) / (punkty[1].X - punkty[0].X);
            double b = punkty[0].Y - (a * punkty[0].X);

            for (int i = 1; i < punkty.Length; i++)
            {
                double a2 = (punkty[i].Y - punkty[0].Y) / (punkty[i].X - punkty[0].X);
                double b2 = punkty[0].Y - (a2 * punkty[0].X);
                if (a2 != a || b2 != b)
                {
                    return false;
                }
            }
            return true;
        }   
    }

    //ZADANIE 8
    class Prostopadloscian
    {
        public double dlugosc;
        public double szerokosc;
        public double wysokosc;

        public Prostopadloscian(double a, double b, double c)
        {
            this.dlugosc = a;
            this.szerokosc = b;
            this.wysokosc = c;
        }

        public double objetosc()
        {
            return this.dlugosc * this.szerokosc * this.wysokosc;
        }

        public static void porownaj(Prostopadloscian[] obiekty)
        {
            if(obiekty[0].objetosc() == obiekty[1].objetosc())
            {
                Console.WriteLine("Objętości są sobie równe");
            }
            else if(obiekty[0].objetosc() > obiekty[1].objetosc())
            {
                double objetosc = obiekty[0].objetosc();
                Console.WriteLine($"Większa objętość prostopadłościanu: {objetosc} \nWymiary: {obiekty[0].dlugosc}, {obiekty[0].szerokosc}, {obiekty[0].wysokosc}");
            }
            else
            {
                double objetosc = obiekty[1].objetosc();
                Console.WriteLine($"Większa objętość prostopadłościanu: {objetosc} \nWymiary: {obiekty[1].dlugosc}, {obiekty[1].szerokosc}, {obiekty[1].wysokosc}");
            }
        }
    }

    class Odcinek
    {
        private Punkt odcinek1;
        private Punkt odcinek2;

        public Odcinek(Punkt odcinek1, Punkt odcinek2)
        {
            this.odcinek1 = odcinek1;
            this.odcinek2 = odcinek2;
        }

        public double obliczOdcinek()
        {
            double dx = this.odcinek2.X - this.odcinek1.X;
            double dy = this.odcinek2.Y - this.odcinek2.Y;
            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }
    }

    struct Prostokat2
    {
        private double dlugosc;
        private double szerokosc;

        public Prostokat2(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        private double Powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private double Obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia prostokąta: " + Powierzchnia());
            Console.WriteLine("Obwód prostokąta: " + Obwod());
        }
    }

    struct KandydatNaStudia
    {
        public string nazwisko;
        private double punktyMatematyka;
        private double punktyInformatyka;
        private double punktyJezykObcy;

        public KandydatNaStudia(string a, double b, double c, double d)
        {
            this.nazwisko = a;
            this.punktyMatematyka = b;
            this.punktyInformatyka = c;
            this.punktyJezykObcy = d;
        }

        public double wynik()
        {
            return (0.6 * this.punktyMatematyka) + (0.5 * this.punktyInformatyka) + (0.2 * this.punktyJezykObcy);
        }
    }
            
    class Program
    {
        static void Main(string[] argv)
        {
            //ZADANIE 1
            // Console.WriteLine("Podaj dlugosc prostokąta:");
            // double dlugosc = Double.Parse(Console.ReadLine());
            // Console.WriteLine("Podaj szerokosc prostokąta:");
            // double szerokosc = Double.Parse(Console.ReadLine());
            // Prostokat prostokat = new Prostokat(dlugosc, szerokosc);
            // prostokat.Prezentuj();

            //ZADANIE 2 i 3
            // Console.WriteLine("Ile chcesz utworzyć prostokątów?: ");
            // int input = Convert.ToInt16(Console.ReadLine());
            // Prostokat[] tablicaProstokatow = new Prostokat[input];
            // for (int i = 0; i < tablicaProstokatow.Length; i++)
            // {
            //     Console.WriteLine("Podaj dlugosc prostokąta:");
            //     double dlugosc = Double.Parse(Console.ReadLine());
            //     Console.WriteLine("Podaj szerokosc prostokąta:");
            //     double szerokosc = Double.Parse(Console.ReadLine());
            //     tablicaProstokatow[i] = new Prostokat(dlugosc, szerokosc);
            // }

            // foreach (Prostokat prostokat in tablicaProstokatow)
            // {
            //     prostokat.Prezentuj();
            // }

            // Console.WriteLine("Największa powierzchnia: " + Prostokat.NajwiekszaPowierzchnia(tablicaProstokatow));

            //ZADANIE 4
            // Console.WriteLine("Podaj początkowy stan licznika: ");
            // double stanP = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Podaj bieżący stan licznika: ");
            // double stanB = Convert.ToDouble(Console.ReadLine());
            // LicznikEnergii licznik = new LicznikEnergii(stanP, stanB);
            // licznik.StanyLicznika();
            // Console.WriteLine("Zużyta energia: " + licznik.ZuzytaEnergia());

            //ZADANIE 5
            // Console.WriteLine("Podaj współrzędne punktu (x/y): ");
            // double x = Convert.ToDouble(Console.ReadLine());
            // double y = Convert.ToDouble(Console.ReadLine());
            // Punkt p = new Punkt(x, y);
            // p.Wyswietl();
            // Console.WriteLine("Podaj przesunięcie punktu (x/y): ");
            // double x2 = Convert.ToDouble(Console.ReadLine());
            // double y2 = Convert.ToDouble(Console.ReadLine());
            // p.Przesun(x2, y2);
            // p.Wyswietl();

            //ZADANIE 6 i 7
            // Punkt[] punkty = new Punkt[3];
            // for(int i=0; i<3; i++)
            // {
            //     Console.WriteLine($"Podaj współrzędne punktu {i+1} (x/y): ");
            //     double x = Convert.ToDouble(Console.ReadLine());
            //     double y = Convert.ToDouble(Console.ReadLine());
            //     punkty[i] = new Punkt(x, y);
            // }

            // bool test = Punkt.jednaProsta(punkty);
            // if(test == true)
            // {
            //     Console.WriteLine("Punkty leżą na jednej prostej.");
            // }
            // else
            // {
            //     Console.WriteLine("Punkty nie leżą na jednej prostej.");
            // }

            // Console.WriteLine("Podaj numery dwóch punktów (od 1 do 3), których długość odcinka chcesz obliczyć: ");
            // int a = Convert.ToInt32(Console.ReadLine()) - 1;
            // int b = Convert.ToInt32(Console.ReadLine()) - 1;

            // Odcinek odcinek = new Odcinek(punkty[a], punkty[b]);
            // double dlugosc = odcinek.obliczOdcinek();
            // Console.WriteLine($"Długość odcinka wynosi: {dlugosc}");

            //ZADANIE 8
            // Console.WriteLine("Wprowadź wymiary pierwszego prostopadłościanu");
            // Console.Write("Długość: ");
            // double a1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Szerokość: ");
            // double b1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Wysokość: ");
            // double c1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Wprowadź wymiary drugiego prostopadłościanu");
            // Console.Write("Długość: ");
            // double a2 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Szerokość: ");
            // double b2 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Wysokość: ");
            // double c2 = Convert.ToDouble(Console.ReadLine());

            // Prostopadloscian[] obiekty = new Prostopadloscian[2];
            // obiekty[0] = new Prostopadloscian(a1, b1, c1);
            // obiekty[1] = new Prostopadloscian(a2, b2, c2);
            // Prostopadloscian.porownaj(obiekty);

            //ZADANIE 9
            // Console.WriteLine("Ile chcesz utworzyć prostokątów?: ");
            // int input = Convert.ToInt16(Console.ReadLine());
            // Prostokat2[] tablicaProstokatow = new Prostokat2[input];
            // for (int i = 0; i < tablicaProstokatow.Length; i++)
            // {
            //     Console.WriteLine("Podaj dlugosc prostokąta:");
            //     double dlugosc = Double.Parse(Console.ReadLine());
            //     Console.WriteLine("Podaj szerokosc prostokąta:");
            //     double szerokosc = Double.Parse(Console.ReadLine());
            //     tablicaProstokatow[i] = new Prostokat2(dlugosc, szerokosc);
            // }

            // foreach (Prostokat2 prostokat in tablicaProstokatow)
            // {
            //     prostokat.Prezentuj();
            // }

            //ZADANIE 10
            Console.Write("Wprowadź liczbę kandydatów na studia: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            KandydatNaStudia[] kandydaci = new KandydatNaStudia[liczba];
            for(int i=0; i<liczba; i++)
            {
                Console.Write("Podaj nazwisko: ");
                string nazwisko = Console.ReadLine();
                Console.Write("Podaj procent z matury z Matematyki: ");
                double matma = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj procent z matury z Informatyki: ");
                double infa = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj procent z matury z Języka Obcego: ");
                double jezyk = Convert.ToDouble(Console.ReadLine());

                kandydaci[i] = new KandydatNaStudia(nazwisko, matma, infa, jezyk);
            }

            foreach(KandydatNaStudia kandydat in kandydaci)
            {
                double wynik = kandydat.wynik();
                Console.WriteLine($"Kandydat: {kandydat.nazwisko}, Wynik: {wynik}");
            }
        }
    }
}