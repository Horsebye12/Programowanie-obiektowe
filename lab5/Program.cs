using System;
using System.Linq;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZADANIE 1
            // static double FahrenheitToCelsius(double temperatureInFahrenheit)
            // {
            //     double temperatureInCelsius = (temperatureInFahrenheit - 32) * (5.0 / 9.0);
            //     return temperatureInCelsius;
            // }
            // Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita: ");
            // double temperatureInFahrenheit = Convert.ToDouble(Console.ReadLine());
            // double temperatureInCelsius = FahrenheitToCelsius(temperatureInFahrenheit);
            // Console.WriteLine(temperatureInCelsius);

            //ZADANIE 2
            // static bool IsInRange(double a, double b, double x)
            // {
            //     return a < x && x < b;
            // }

            // double a, b, x;

            // Console.WriteLine("Wprowadź 3 liczby (a - początek przedziału, b - koniec przedziału, x - liczba, której zawieranie się w przedziale chcemy zbadać): ");
            // a = double.Parse(Console.ReadLine());
            // b = double.Parse(Console.ReadLine());
            // x = double.Parse(Console.ReadLine());

            // bool result = IsInRange(a, b, x);

            // if (result)
            //     Console.WriteLine("x należy do przedziału otwartego (a, b)");
            // else
            //     Console.WriteLine("x nie należy do przedziału otwartego (a, b)");

            //ZADANIE3
            // static void Przesun(ref double x, ref double y, double wekX, double wekY)
            // {
            //     x += wekX;
            //     y += wekY;
            // }

            // double x, y;

            // Console.WriteLine("Wprowadź współrzędne punktu A: ");
            // x = double.Parse(Console.ReadLine());
            // y = double.Parse(Console.ReadLine());

            // double wekX = 3, wekY = 2;

            // Przesun(ref x, ref y, wekX, wekY);

            // Console.WriteLine("Współrzędne punktu A po przesunięciu: " + x + ", " + y);

            //ZADANIE 4A
            // static int[] MultiplyArray(int[] array, int multiplier)
            // {
            // int[] result = new int[array.Length];
            // for (int i = 0; i < array.Length; i++)
            // {
            //     result[i] = array[i] * multiplier;
            // }
            // return result;
            // }

            // Console.WriteLine("Ile liczb chcesz wprowadzić do tablicy? ");
            // int input = Convert.ToInt32(Console.ReadLine());
            // int[] originalArray = new int[input];
            // for(int i=0; i<input; i++)
            // {
            //     Console.Write($"Wprowadź liczbę nr {i+1}: ");
            //     originalArray[i] = Convert.ToInt32(Console.ReadLine());
            // }
            
            // Console.WriteLine("Wprowadź mnożnik tablicy: ");
            // int multiplier = Convert.ToInt32(Console.ReadLine());
            // int[] resultArray = MultiplyArray(originalArray, multiplier);
            // Console.WriteLine($"Wynik: ");
            // foreach(int item in resultArray)
            // {
            //     Console.Write($"{item}, ");
            // }

            //ZADANIE 4B
            // static void MultiplyArrayInPlace(int[] array, int multiplier)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] *= multiplier;
            //     }
            // }

            // Console.WriteLine("Ile liczb chcesz wprowadzić do tablicy? ");
            // int input = Convert.ToInt32(Console.ReadLine());
            // int[] originalArray = new int[input];
            // for(int i=0; i<input; i++)
            // {
            //     Console.Write($"Wprowadź liczbę nr {i+1}: ");
            //     originalArray[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // Console.WriteLine("Wprowadź mnożnik tablicy: ");
            // int multiplier = Convert.ToInt32(Console.ReadLine());
            // MultiplyArrayInPlace(originalArray, multiplier);
            // Console.WriteLine($"Wynik: ");
            // foreach(int item in originalArray)
            // {
            //     Console.Write($"{item}, ");
            // }

            //ZADANIE 5
            // static void Rysuj(int length, int width, char fill)
            // {
            //     for (int i = 0; i < width; i++)
            //     {
            //         for (int j = 0; j < length; j++)
            //         {
            //             Console.Write(fill);
            //         }
            //         Console.WriteLine();
            //     }
            // }
            // Console.WriteLine("Podaj dlugosc prostokata:");
            // int length = int.Parse(Console.ReadLine());
            // Console.WriteLine("Podaj szerokosc prostokata:");
            // int width = int.Parse(Console.ReadLine());
            // Console.WriteLine("Podaj znak wypelnienia prostokata:");
            // char fill = char.Parse(Console.ReadLine());

            // Rysuj(length, width, fill);

            // Console.WriteLine();

            // Rysuj(width, length, fill);

            //ZADANIE 6
            // static string[] RepeatArray(string[] array, int multiplier)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = string.Concat(Enumerable.Repeat(array[i], multiplier));
            //     }
            //     return array;
            // }

            // Console.WriteLine("Wprowadź liczbę słów które chcesz wprowadzić: ");
            // int input = Convert.ToInt32(Console.ReadLine());
            // string[] originalArray = new string[input];
            // for(int i=0; i<input; i++)
            // {
            //     originalArray[i] = Console.ReadLine();
            // }
            // Console.WriteLine("Wprowadź mnożnik: ");
            // int multiplier = Convert.ToInt32(Console.ReadLine());
            // string[] resultArray = RepeatArray(originalArray, multiplier);

            // foreach(string element in resultArray)
            // {
            //     Console.Write($"{element}, ");
            // }

            //ZADANIE 7
            // static int CalculateExpression(int x, int n)
            //     {
            //         int result = 0;
            //         for (int i = 1; i <= n; i++)
            //         {
            //             result += x + i;
            //         }
            //         return result;
            //     }

            //     Console.WriteLine("Podaj wartość x:");
            //     int x = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Podaj wartość n:");
            //     int n = int.Parse(Console.ReadLine());
            //     int result = CalculateExpression(x, n);
            //     Console.WriteLine("Wynik wyrażenia W: " + result);

            //ZADANIE 8
            // static int SumOfDigits(int x)
            // {
            //     int sum = 0;
            //     while (x > 0)
            //     {
            //         sum += x % 10;
            //         x /= 10;
            //     }
            //     return sum;
            // }
            // Console.WriteLine("Podaj liczbę naturalną x:");
            // int x = int.Parse(Console.ReadLine());
            // int sum = SumOfDigits(x);
            // Console.WriteLine("Suma cyfr liczby x: " + sum);

            //ZADANIE 9A - FIBONNACI REKURENCYJNIE
            // static int FibonacciRecursive(int n)
            // {
            //     if (n == 0 || n == 1)
            //         return n;
            //     else
            //         return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
            // }

            // Console.WriteLine("Podaj numer n-ty wyrazu ciągu Fibonacciego:");
            // int n = int.Parse(Console.ReadLine());
            // int fibonacci = FibonacciRecursive(n);
            // Console.WriteLine("n-ty wyraz ciągu Fibonacciego: " + fibonacci);

            //ZADANIE 9B - FIBONNACI ITERACYJNIE
            // static int FibonacciIterative(int n)
            // {
            //     int a = 0, b = 1, c = 0;
            //     if (n == 0)
            //         return a;
            //     for (int i = 2; i <= n; i++)
            //     {
            //         c = a + b;
            //         a = b;
            //         b = c;
            //     }
            //     return b;
            // }

            // Console.WriteLine("Podaj numer n-ty wyrazu ciągu Fibonacciego:");
            // int n = int.Parse(Console.ReadLine());
            // int fibonacci = FibonacciIterative(n);
            // Console.WriteLine("n-ty wyraz ciągu Fibonacciego: " + fibonacci);

            //ZADANIE 10
            static int Oblicz(int n)
            {
                if (n <= 1) return (1);
                else return (n + Oblicz(n -1));
            }

            Console.WriteLine(Oblicz(5));
        }
    }
}