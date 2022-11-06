using System;

namespace lab6{
    //ZADANIE 1 i 2
    public class Prostokat{
        private double dlugosc;
        private double szerokosc;

        public Prostokat(double a, double b){
            dlugosc = a;
            szerokosc = b;
        }

        private double powierzchnia(){
            double pow = dlugosc * szerokosc;
            return pow;
        }

        private double obwod(){
            double ob = (2 * dlugosc) + (2 * szerokosc);
            return ob;
        }

        public void Prezentuj(){
            double pow = powierzchnia();
            double ob = obwod();
            Console.WriteLine($"Powierzchnia prostokąta wynosi: {pow} \nObwód prostokąta wynosi: {ob}");
        }
        
    }
    class Program{
        static void Main(string[] args){
            //ZADANIE 1 i 2
            Console.Write("Ile prostokatow chcesz wprowadzic? ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            
            Prostokat[] obiekty = new Prostokat[liczba];

            for(int i=0; i<liczba; i++){
                Console.Write($"Podaj szerokość prostokąta nr {i+1}: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Podaj dlugosc prostokąta nr {i+1}: ");
                double b = Convert.ToDouble(Console.ReadLine());
                
                obiekty[i] = new Prostokat(a, b);
            }

            foreach (Prostokat pr in obiekty){
                pr.Prezentuj();
            }

            // Prostokat p1 = new Prostokat();
            // p1.Prezentuj();
            // Console.ReadKey();
        }
    }
 
}