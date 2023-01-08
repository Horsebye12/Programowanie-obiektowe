using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab4{
    class Program{
        static void Main (string[] args){
            //ZADANIE 1

            // int len;
            // Console.Write("Podaj długość tablicy: ");
            // len = Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[len];

            // for (int x=0; x<len; x++){
            //     Console.WriteLine($"Podaj element tablicy nr {x+1}: ");
            //     array[x] = Convert.ToInt32(Console.ReadLine());
            // }

            // for (int x=0; x<len; x++){
            //     Console.Write($"{array[x]}, ");
            // }

            //ZADANIE 2

            // int[] arr1 = new int[] {-1, -2, 5, 54, -43, -23, 43, 63, 23, 49};
            // List<int> list = new List<int>();

            // for (int x=0; x<10; x++){
            //     if(arr1[x] > 0){
            //         list.Add(arr1[x]);
            //     }
            // }

            // list.ForEach(Console.WriteLine);

            //ZADANIE 3

            // int len;
            // Console.Write("Podaj długość tablicy: ");
            // len = Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[len];

            // for (int x=0; x<len; x++){
            //     Console.WriteLine($"Podaj element tablicy nr {x+1}: ");
            //     array[x] = Convert.ToInt32(Console.ReadLine());
            // }

            // Console.WriteLine($"Największy element tablicy i jego numer indeksu: {array.Max()}, {array.ToList().IndexOf(array.Max())}");
            // Console.WriteLine($"Największy element tablicy i jego numer indeksu: {array.Min()}, {array.ToList().IndexOf(array.Min())}");
            // double sum = 0;
            // foreach(int i in array){
            //     sum += i;
            // }
            // Console.WriteLine($"Średnia tablicy: {sum/len}");
            // double quantity = 0;
            // foreach(int i in array){
            //     if(i > 0){
            //         quantity += 1;
            //     }
            // }
            // Console.WriteLine($"Ilośc elementów dodatnich: {quantity}");

            //ZADANIE 4

            // int[] array = new int[100];
            // Random rand = new Random();
            // for(int i=0; i<100; i++){
            //     array[i] = rand.Next(1, 1000);
            // }


            // int sum=0;
            // for(int i = 0; i<100; i++){
            //     for (int x=1; x<=array[i]; x++){
            //         if(array[i]%x == 0){
            //             sum += 1;
            //         }
            //     }
            //     if(sum == 2){
            //         Console.WriteLine($"Liczba pierwsza: {array[i]}");
            //     }
            //     sum = 0;
            // }

            //ZADANIE 5

            // int len;
            // Console.Write("Podaj długość tablicy: ");
            // len = Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[len];

            // for (int x=0; x<len; x++){
            //     Console.WriteLine($"Podaj element tablicy nr {x+1}: ");
            //     array[x] = Convert.ToInt32(Console.ReadLine());
            // }

            // int[] cpArray = new int[len];

            // for(int i=0; i<len; i++){
            //     if (i+1 == len){
            //         cpArray[0] = array[len-1];
            //     }
            //     else{
            //         cpArray[i+1] = array[i];
            //     }
            // }

            // foreach (int i in array){
            //     Console.Write($"{i}, ");
            // }
            // Console.Write("\n");

            // foreach (int i in cpArray){
            //     Console.Write($"{i}, ");
            // }
            // Console.Write("\n");

            //ZADANIE 6

            // int len = 5;
            // int[,] array = new int [len,len];
            
            // for(int i=0; i<len; i++){
            //     for(int y=0; y<len; y++){
            //         Console.Write($"Podaj element tablicy o indeksach ({y},{i}): ");
            //         array[y,i] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // Console.WriteLine("Twoja macierz: ");
            // for(int i=0; i<len; i++){
            //     for(int y=0; y<len; y++){
            //         Console.Write(array[y,i] + ", ");
            //     }
            //     Console.Write("\n");
            // }

            // int sum = 0;
           
            // for(int i=0; i<len; i++){
            //     sum = sum + array[i,i];
            // }

            // Console.WriteLine($"Suma głównej przekątnej: {sum}");

            //ZADANIE 7

            // int rows = 3;
            // int cols = 2;
            // int[,] arr1 = new int[rows,cols];
            // int[,] arr2 = new int[rows,cols];

            // Console.WriteLine("Wprowadź elementy pierwszej macierzy: ");
            // for(int i=0; i<rows; i++){
            //     for(int y=0; y<cols; y++){
            //         Console.Write($"Macierz 1 - Element ({i},{y}): ");
            //         arr1[i,y] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // Console.WriteLine("Wprowadź elementy drugiej macierzy: ");
            // for(int i=0; i<rows; i++){
            //     for(int y=0; y<cols; y++){
            //         Console.Write($"Macierz 2 - Element ({i},{y}): ");
            //         arr2[i,y] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // Console.WriteLine("Suma dwóch macierzy: ");
            // for(int i=0; i<rows; i++){
            //     for(int y=0; y<cols; y++){
            //         Console.Write("[" + (arr1[i,y] + arr2[i,y]) + "]");
            //     }
            //     Console.Write("\n");
            // }

            //ZADANIE 8

            // string [,] dniTygodnia;
            // dniTygodnia = new string [7,3];
            // dniTygodnia[0,0] = "poniedziałek";
            // dniTygodnia[1,0] = "wtorek";
            // dniTygodnia[2,0] = "środa";
            // dniTygodnia[3,0] = "czwartek";
            // dniTygodnia[4,0] = "piątek";
            // dniTygodnia[5,0] = "sobota";
            // dniTygodnia[6,0] = "niedziela";
            // dniTygodnia[0,1] = "monday";
            // dniTygodnia[1,1] = "tuesday";
            // dniTygodnia[2,1] = "wednesday";
            // dniTygodnia[3,1] = "thursday";
            // dniTygodnia[4,1] = "friday";
            // dniTygodnia[5,1] = "saturday";
            // dniTygodnia[6,1] = "sunday";
            // dniTygodnia[0,2] = "montag";
            // dniTygodnia[1,2] = "dienstag";
            // dniTygodnia[2,2] = "mittwoch";
            // dniTygodnia[3,2] = "donnerstag";
            // dniTygodnia[4,2] = "freitag";
            // dniTygodnia[5,2] = "samstag";
            // dniTygodnia[6,2] = "sonntag";

            // for(int i=0; i<3; i++){
            //     for(int y=0; y<7; y++){
            //         Console.Write("[" + dniTygodnia[y,i] + "]");
            //     }
            //     Console.Write("\n");
            // }

            //ZADANIE 9

            // Console.WriteLine("Wpisz zdanie");
            // string zdanie = Console.ReadLine();
            // char znak = ' ';

            // int wyrazy = zdanie.Count(f => (f == znak));

            // Console.WriteLine($"Liczba wyrazów w zdaniu '{zdanie}' = {wyrazy+1}");

            //ZADANIE 10

            // Console.WriteLine("Napisz datę w formacie: DD-MM-RRRR");
            // string data = Console.ReadLine();

            // try{
            //     if(data[2] != '-' | data[5] != '-' | data.Length != 10){
            //         Console.WriteLine("Podano nieprawidlową datę!");
            //     }
            //     else{
            //         string month = $"{data[3]}" + $"{data[4]}";
            //         try{
            //             int monthint = Convert.ToInt32(month);

            //             switch(monthint){
            //                 case 1:
            //                     Console.WriteLine("Styczeń");
            //                     break;
            //                 case 2:
            //                     Console.WriteLine("Luty");
            //                     break;
            //                 case 3:
            //                     Console.WriteLine("Marzec");
            //                     break;
            //                 case 4:
            //                     Console.WriteLine("Kwiecień");
            //                     break;
            //                 case 5:
            //                     Console.WriteLine("Maj");
            //                     break;
            //                 case 6:
            //                     Console.WriteLine("Czerwiec");
            //                     break;
            //                 case 7:
            //                     Console.WriteLine("Lipiec");
            //                     break;
            //                 case 8:
            //                     Console.WriteLine("Sierpień");
            //                     break;
            //                 case 9:
            //                     Console.WriteLine("Wrzesień");
            //                     break;
            //                 case 10:
            //                     Console.WriteLine("Październik");
            //                     break;
            //                 case 11:
            //                     Console.WriteLine("Listopad");
            //                     break;
            //                 case 12:
            //                     Console.WriteLine("Grudzień");
            //                     break;
            //                 default:
            //                     Console.WriteLine("Podano nieprawidłowy numer miesiąca!");
            //                     break;
            //             }
            //         }
            //         catch{
            //             Console.WriteLine("Podany miesiąc nie jest liczbą!");
            //         }
            //     }
            // }
            // catch{
            //     Console.WriteLine("Podano nieprawidłową datę!");
            // }

            //ZADANIE 11

            // string alpha = "abcdefghijklmnoprstuvwxyz"; 
            // int a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, r, s, t, u, v, w, x, y, z;
            // a = b = c = d = e = f = g = h = i = j = k = l = m = n = o = p = r = s = t = u = v = w = x = y = z = 0;

            // Console.WriteLine("Wpisz słowo lub zdanie, bez polskich znaków!: ");
            // string zdanie = Console.ReadLine();
            // for(int letter = 0; letter < alpha.Length; letter++){
            //     int count = 0;
            //     count = zdanie.Count(f => (f == alpha[letter]));
            //     if(count > 0){
            //         Console.WriteLine($"{alpha[letter]} - {count} ");
            //     }
            // }

            //ZADANIE 12

            // string tekst = "W parę godzin później, gdy noc zbierała siędo odejścia,\n" + 
            // "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" + 
            // "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" + 
            // "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            // "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

            // int numLines = tekst.Count(c => (c == '\n')) + 1;
            // Console.WriteLine($"Liczba wierszy: {numLines}");

            // int numLetters = 0;
            // int numLine = 0;
            // foreach (char letter in tekst){
            //     if(letter != '\n'){
            //         numLetters++;
            //     }
            //     else{
            //         Console.WriteLine($"Wers {numLine+1}: {numLetters} znaków");
            //         numLetters = 0;
            //         numLine++;
            //     }
            // }
            // Console.WriteLine($"Wers {numLine+1}: {numLetters} znaków");

            //ZADANIE 13

            // Console.WriteLine("Wprowadź tekst: ");
            // string tekst = Console.ReadLine();
            // string text = tekst.ToLower();

            // string[] words = tekst.Replace(',', ' ').ToLower().Split(' ');
            // var distinctWords = words.Distinct().ToArray();
            // foreach (string word in distinctWords){
            //     int count = 0;
            //     if(word != "-" & word != ""){
            //         for(int i=0; i<words.Length; i++){
            //             if(word == words[i]){
            //                 count++;
            //             }
            //         }
            //         if(count > 1){
            //             Console.WriteLine($"{word}: {count}");
            //         }
            //     }
            // }

            //ZADANIE 14

            // string[] ident = {"KONG-2001", "STRONG-2002", "HAHA-2007", "HEHE-2012", "OHOHO-2020"};
            // DateTime thisDay = DateTime.Today;
            // int yearNow = thisDay.Year;

            // foreach(string id in ident){
            //     for(int i=0; i<id.Length; i++){
            //         if(id[i] == '-'){
            //             string year = $"{id[i+1]}{id[i+2]}{id[i+3]}{id[i+4]}";
            //             int yearInt = Convert.ToInt32(year);
            //             Console.WriteLine($"Lat od zakupu {id}: {yearNow-yearInt}");
            //         }
            //     }
            // }

            //ZADANIE 15

            string key = "gaderypoluki";
            Console.WriteLine("Wpisz słowo do zakodowania: ");
            string word = Console.ReadLine();

            Console.Write("Twoje zakodowane słowo: ");
            foreach(char letter in word){
                bool check = false;
                for(int i=0; i<key.Length; i++){
                    if(letter == key[i]){
                        if(i%2 == 0){
                            Console.Write(key[i+1]);
                            check = true;
                            break;
                        }
                        else{
                            Console.Write(key[i-1]);
                            check = true;
                            break;
                        }
                    }
                }
                if(check == false){
                    Console.Write(letter);
                }
            }
            
        }
    }
}
