//W CELU URUCHOMIENIA KODU NALEŻY ODKOMENTOWAĆ KONKRETNE ZADANIE

using System;

namespace lab2 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //ZADANIE 1 - KONWERSJA STOPNI CELSJUSZA NA STOPNIE FAHRENHEITA

            // Console.WriteLine("Wprowadź temperaturę w stopniach Celsjusza: ");
            // float temperatura;
            // temperatura = Convert.ToSingle(Console.ReadLine());
            // float konwersja = 32 + ((9 * temperatura)/5);
            // Console.WriteLine($"Temperatura w stopniach Fahrenheita wynosi: {konwersja}");

            //ZADANIE 2 - DELTA RÓWNANIA KWADRATOWEGO

            // int a = 0;
            // int b = 0;
            // int c = 0;

            // Console.WriteLine("Podaj współczynnik a: ");
            // a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Podaj współczynnik b: ");
            // b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Podaj współczynnik c: ");
            // c = Convert.ToInt32(Console.ReadLine());

            // int delta = ((b * b) - (4 * a * c));
            // Console.WriteLine($"Delta wynosi: {delta}");

            //ZADANIE 3 - BMI

            // float masa;
            // float wzrost;

            // Console.WriteLine("Podaj swoją masę w kilogramach: ");
            // masa = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine("Podaj swój wzrost w metrach: ");
            // wzrost = Convert.ToSingle(Console.ReadLine());

            // float bmi = masa/wzrost;
            // Console.WriteLine($"Twoje BMI wynosi: {bmi}");
            // Console.ReadKey();

            //ZADANIE 4

            // int x = 100;
            // Console.WriteLine(++x * 2);

            //ZADANIE 5

            // int x = 2, y = 3;
            // Console.WriteLine(x *= y * 2);

            //ZADANIE 6

            // int x, y = 4;
            // x = (y -=2);
            // x = y++;
            // x = y--;
            // Console.WriteLine(x);

            //ZADANIE 7

            // int x, y = 5;
            // x = ++y * 2;
            // x = y++;
            // x = y--;
            // Console.WriteLine(++y);

            //ZADANIE 8

            // bool x;
            // int y = 1, z = 1;
            // x = (y == 1 && z++ == 1);
            // Console.WriteLine(x + " " + y + " " + z);

            //ZADANIE 9

            //a
            // int x = 1, y = 4, z = 2;
            // bool wynik =(x++ > 1 && y++ == 4 && z--> 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //b
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 & y++ == 4 && z--> 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //c
            // int x = 1, y = 4, z = 2;
            // bool wynik = (x++ > 1 & y++ == 4 & z--> 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //d
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}",wynik, x, y, z);

            //e
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //f
            // int x = 1, y = 3, z = 4;
            // bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            // Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);

            //ZADANIE 10

            // int powierzchnia = 100, osoby = 10;
            // double gestoscZaludnienia = osoby/powierzchnia;
            // Console.WriteLine(gestoscZaludnienia);


            //**WYJAŚNIENIE**
            //ZMIENNA "gestoscZaludnienia" PRZYJMIE WARTOŚĆ 0 PONIEWAŻ INT NIE JEST TYPEM ZMIENNOPRZECINKOWYM
            //PARAMETRY "powierzchnia" ORAZ "osoby" MUSZĄ MIEĆ TYP DOUBLE ABY OTRZYMAĆ WYNIK 0,1
            //JEST RÓWNIEŻ KILKA INNYCH SPOSOBÓW NA ROZWIĄZANIE ZADANIA: ZMIANA TYPU WSZYSTKICH PARAMETRÓW NA FLOAT, 
            //ZMIANA TYLKO PARAMETRÓW Z PRZYPISANĄ STAŁĄ WARTOŚCIĄ NA TYP FLOAT ORAZ ZAOKRĄGLENIE WYNIKU DO 1 MIEJSCA PO PRZECINKU 


            // double powierzchnia = 100, osoby = 10;
            // double gestoscZaludnienia = osoby/powierzchnia;
            // Console.WriteLine(gestoscZaludnienia);

        }
    }
}