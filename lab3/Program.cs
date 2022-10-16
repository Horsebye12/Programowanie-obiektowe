using System;
using System.Linq;

namespace lab3{
    class Program{
        static void Main (string[] args){
        //ZADANIE 1

        //     Console.WriteLine("Podaj rok");
        //     int rok;
        //     rok = Convert.ToInt32(Console.ReadLine());
        //     if (rok % 4 == 0){
        //         if(rok % 100 != 0){
        //             Console.Write("Podany rok jest przestępny");
        //         }
        //         else{
        //             if(rok % 400 == 0){
        //                 Console.Write("Podany rok jest przestępny");
        //             }
        //             else{
        //                 Console.Write("Podany rok nie jest przestępny");
        //             }
        //         }
        //     }
        //     else{
        //         Console.Write("Podany rok nie jest przestępny");
        //     }
        // }

        //ZADANIE 2

        //     int a, b;
        //     Console.WriteLine("Podaj pierwszą liczbę: ");
        //     a = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Podaj drugą liczbę: ");
        //     b = Convert.ToInt32(Console.ReadLine());

        //     if (a % b == 0){
        //         Console.WriteLine($"Liczba {b} jest dzielnikiem {a}");
        //     }
        //     else{
        //         Console.WriteLine($"Liczba {b} nie jest dzielnikiem {a}");
        //     }
        // }

        //ZADANIE 3

            // int[] AnArray = new int [3];

            // for(int x = 0; x < 3; x++){
            //     Console.WriteLine($"Podaj liczbę nr {x+1}");
            //     int b = Convert.ToInt32(Console.ReadLine());
            //     AnArray[x] = b;
            // }

            // int maxValue = AnArray.Max();
            // Console.WriteLine($"Maksymalna podana wartość to: {maxValue}");

        //ZADANIE 4

        // double a, b;
        // Console.WriteLine("Podaj liczbę nr 1: ");
        // a = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Podaj liczbę nr 2: ");
        // b = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Podaj działanie z podanych znaków: '+', '-', '*' '/'");
        // string equation = Console.ReadLine();
        
        // switch (equation){
        //     case "+":
        //         Console.WriteLine($"Wynik dodawania: {a + b}");
        //         break;
        //     case "-":
        //         Console.WriteLine($"Wynik odejmowania: {a - b}");
        //         break;
        //     case "*":
        //         Console.WriteLine($"Wynik mnożenia: {a * b}");
        //         break;
        //     case "/":
        //         Console.WriteLine($"Wynik dzielenia: {a / b}");
        //         break;
        //     default:
        //         Console.WriteLine("Podano nieprawidłowy znak");
        //         break;
        // }

        //ZADANIE 5

        // double[] digits = new double[3];
        // string[] param = {"a", "b", "c"};
        // for (int x = 0; x < 3; x++){
        //     Console.WriteLine($"Podaj wartość współczynnika {param[x]}:");
        //     digits[x] = Convert.ToInt32(Console.ReadLine());
        // }

        // double delta = (digits[1] * digits[1]) - (4 * digits[0] * digits[2]);

        // if (delta == 0){
        //     Console.WriteLine("Równanie ma tylko jeden pierwiastek");
        // }
        // else if (delta < 0){
        //     Console.WriteLine("Równanie nie ma pierwiastków");
        // }
        // else{
        //     Console.WriteLine("Równanie ma dwa pierwiastki");
        // }

        //ZADANIE 6

        // double masa, wzrost;
        // Console.WriteLine("Podaj swoją masę w kg: ");
        // masa = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Podaj swoją wzrost w m: ");
        // wzrost = Convert.ToDouble(Console.ReadLine());

        // double bmi = masa/(wzrost*wzrost);
        // Console.WriteLine($"Twoje BMI wynosi: {bmi}");

        // switch (bmi){
        //     case < 16.0:
        //         Console.WriteLine("Wygłodzenie");
        //         break;
        //     case >= 16.0 and <= 16.0:
        //         Console.WriteLine("Wychudzenie");
        //         break;
        //     case >= 17.0 and <= 18.5:
        //         Console.WriteLine("Niedowaga");
        //         break;
        //     case >= 18.6 and <= 24.9:
        //         Console.WriteLine("Waga prawidłowa");
        //         break;
        //     case >= 25.0 and <= 29.9:
        //         Console.WriteLine("Nadwaga");
        //         break;
        //     case >= 30.0 and <= 34.9:
        //         Console.WriteLine("Otyłość I stopnia");
        //         break;
        //     case >= 35.0 and <= 39.9:
        //         Console.WriteLine("Otyłość II stopnia");
        //         break;
        //     case >= 40.0:
        //         Console.WriteLine("Otyłość III stopnia");
        //         break;
        // }   

        //ZADANIE 7

        // Console.WriteLine("Wpisz numer dnia tygodnia: ");
        // string numer = Console.ReadLine();
        // switch(numer){
        //     case "1":
        //         Console.WriteLine("Poniedziałek");
        //         break;
        //     case "2":
        //         Console.WriteLine("Wtorek");
        //         break;
        //     case "3":
        //         Console.WriteLine("Środa");
        //         break;
        //     case "4":
        //         Console.WriteLine("Czwartek");
        //         break;
        //     case "5":
        //         Console.WriteLine("Piątek");
        //         break;
        //     case "6":
        //         Console.WriteLine("Sobota");
        //         break;
        //     case "7":
        //         Console.WriteLine("Niedziela");
        //         break;
        //     default:
        //         Console.WriteLine("Nie ma takigeo dnia tygodnia");
        //         break;
        // }

        //ZADANIE 8

        // Console.WriteLine("Podaj swoją średną ocen: ");
        // double avg = Convert.ToDouble(Console.ReadLine());

        // switch(avg){
        //     case >= 2.00 and <= 3.99:
        //         Console.WriteLine("Nie należy się stypednium");
        //         break;
        //     case >= 4.00 and <= 4.79:
        //         Console.WriteLine("Kwota stypendium: 350.00zł");
        //         break;
        //     case >= 4.80 and <= 5.00:
        //         Console.WriteLine("Kwota stypendium: 550.00zł");
        //         break;
        //     default:
        //        Console.WriteLine("Średnia została nieprawidłowo wpisana");
        //        break; 
        // }

        // //ZADANIE 9

        // static void treeOne(int a){
        //     for (int x = 1; x <= a; x++){
        //         for(int y = 1; y <= x; y++){
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        // }

        // static void treeTwo(int a){
        //     for (int x = 1; x<=a; x++){
        //         for (int y = (a - x); y >= 0; y--){
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        // }

        // static void treeThree(int a){
        //     for (int x = 1; x <= a; x++){
        //         for (int y = (a - x); y > 0; y--){
        //             Console.Write(" ");
        //         }
        //         for(int y = 1; y <= x; y++){
        //             Console.Write("*");
        //         }
        //         Console.Write("\n");
        //     }
        // }

        // static void treeFour(int a){
        //     for(int x = 1; x <= a; x++){
        //         Console.Write("*");
        //     }
        //     Console.Write("\n");
        //     for(int y = 1; y <= (a - 2); y++){
        //         Console.Write("*");
        //         for(int z = 1; z <= (a - 2); z++){
        //             Console.Write(" ");
        //         }
        //         Console.Write("*\n");
        //     }
        //     for(int x = 1; x <= a; x++){
        //         Console.Write("*");
        //     }
        //     Console.Write("\n");
        // }

        // Console.Write("Podaj ilość linii: ");
        // int param = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Wybierz wariant drzewka: (1, 2, 3 lub 4): ");
        // int tree = Convert.ToInt32(Console.ReadLine());

        // switch(tree){
        //     case 1:
        //         treeOne(param);
        //         break;
        //     case 2:
        //         treeTwo(param);
        //         break;
        //     case 3:
        //         treeThree(param);
        //         break;
        //     case 4:
        //         treeFour(param);
        //         break;
        //     default:
        //         Console.WriteLine("Drzewko spoza podanego zakresu");
        //         break;
        // }

        //ZADANIE 10

        // Console.Write("Podaj liczbę: ");
        // double factorial = Convert.ToDouble(Console.ReadLine());

        // double start = 1;
        // for (double x = 1; x<=factorial; x++){
        //     start = start * x;
        // }
        // Console.WriteLine(start);

        //ZADANIE 11

        // int start = 0;
        // int increment = 0;
        // for (int x=1; x<=100; x++){
        //     start += x;
        //     if (start >= 100){
        //         Console.Write(increment);
        //         break;
        //     }
        //     else{
        //         increment++;
        //     }
        // }

        //ZADANIE 12

        // double x=1;
        // while(x != 0){
        //     Console.WriteLine("Wpisz liczbę: ");
        //     x = Convert.ToDouble(Console.ReadLine());
        // }

        //ZADANIE 13

        // Console.WriteLine("Podaj liczbę: ");
        // int a = Convert.ToInt32(Console.ReadLine());

        // int start = 0;

        // for (int x=1; x<=a; x++){
        //     if (x % 2 == 0){
        //         start -= x;
        //     }
        //     else{
        //         start += x;
        //     }
        // }
        // Console.WriteLine($"Wynik szeregu: {start}");

        //ZADANIE 14

        // Console.WriteLine("Podaj ostatnią liczbę z zakresu: ");
        // int range = Convert.ToInt32(Console.ReadLine());

        // for (int x = 1; x<=range; x++){
        //     int inc = 0;
        //     for (int y = 1; y<x; y++){
        //         if ((x % y == 0) && (x != y)){
        //             inc+=y;
        //         }
        //     }
        //     if (inc == x){
        //         Console.WriteLine($"Liczba doskonała: {x}");
        //     }
        // }
    }
    }
}
