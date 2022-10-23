using System;
using System.Linq;
using System.Collections.Generic;

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

            int len;
            Console.Write("Podaj długość tablicy: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for (int x=0; x<len; x++){
                Console.WriteLine($"Podaj element tablicy nr {x+1}: ");
                array[x] = Convert.ToInt32(Console.ReadLine());
            }

            int[] cpArray = new int[len];

            for(int i=0; i<len; i++){
                if (i+1 == len){
                    cpArray[0] = array[len-1];
                }
                else{
                    cpArray[i+1] = array[i];
                }
            }

            foreach (int i in array){
                Console.Write($"{i}, ");
            }

            foreach (int i in cpArray){
                Console.Write($"{i}, ");
            }

           
        }
    }
}