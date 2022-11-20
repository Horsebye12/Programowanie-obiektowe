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

    class energyUsage{
        private double first;
        private double latest;

        public energyUsage (double a, double b){
            first = a;
            latest = b;
        }

        private double usage(){
            double us = latest - first;
            return us;
        }

        public void show(){
            double showUsage = usage();
            Console.WriteLine($"Stan początkowy: {first}\nStan aktualny: {latest}\nŁączne zużycie: {showUsage}");
        }
    }

    class Punkt{
        public double cordX;
        public double cordY;

        public Punkt(double a, double b){
            cordX = a;
            cordY = b;
        }

        public double Przesun(double c, double d){
            cordX = cordX + c;
            cordY = cordY + d;
            return 0;
        }

        public void Wyswietl(){
            Console.WriteLine($"Współrzędne punktu\nX = {cordX}\nY = {cordY}");
        }

        private static double Vector(double x1, double x2, double y1, double y2){
            double vector = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1), 2));
            return vector;
        }

        public static double SingleLine(Punkt[] tab){
            double vectorAB = Vector(tab[1].cordX, tab[0].cordX, tab[1].cordY, tab[0].cordY);
            double vectorAC = Vector(tab[1].cordX, tab[0].cordX, tab[1].cordY, tab[0].cordY);
            double vectorBC = Vector(tab[1].cordX, tab[0].cordX, tab[1].cordY, tab[0].cordY);

            Console.WriteLine($"{vectorAB}, {vectorAC}, {vectorBC}");

            if(vectorAB == vectorAC + vectorBC){
                Console.WriteLine("Punkty są współliniowe");
            }
            else if(vectorAC == vectorAB + vectorBC){
                Console.WriteLine("Punkty są współliniowe");
            }
            else if(vectorBC == vectorAB + vectorAC){
                Console.WriteLine("Punkty są współliniowe");
            }
            else{
                Console.WriteLine("Punkty nie są współliniowe");
            }

            return 0;
        }
    }

    class Program{
        static void Main(string[] args){
            //ZADANIE 1, 2, 3(do zrobienia)
            // Console.Write("Ile prostokatow chcesz wprowadzic? ");
            // int liczba = Convert.ToInt32(Console.ReadLine());
            
            // Prostokat[] obiekty = new Prostokat[liczba];

            // for(int i=0; i<liczba; i++){
            //     Console.Write($"Podaj szerokość prostokąta nr {i+1}: ");
            //     double a = Convert.ToDouble(Console.ReadLine());
            //     Console.Write($"Podaj dlugosc prostokąta nr {i+1}: ");
            //     double b = Convert.ToDouble(Console.ReadLine());
                
            //     obiekty[i] = new Prostokat(a, b);
            // }

            // foreach (Prostokat pr in obiekty){
            //     pr.Prezentuj();
            // }

            

            // ZADANIE 4
            // Console.WriteLine("Podaj początkowy stan licznika: ");
            // double first = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Podaj aktualny stan licznika: ");
            // double latest = Convert.ToDouble(Console.ReadLine());

            // energyUsage e1 = new energyUsage(first, latest);

            // e1.show();

            //ZADANIE 5
            // Console.WriteLine("Podaj współrzędną punktu X: ");
            // double X = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Podaj współrzędną punktu Y");
            // double Y = Convert.ToDouble(Console.ReadLine());

            // Punkt p1 = new Punkt(X, Y);

            // Console.WriteLine("Podaj przesunięcie punktu X: ");
            // double moveX = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Podaj przesunięcie punktu Y: ");
            // double moveY = Convert.ToDouble(Console.ReadLine());

            // p1.Przesun(moveX, moveY);
            // p1.Wyswietl();

            //ZADANIE 6
            Punkt[] punkty = new Punkt[3];

            for(int i=0; i<3; i++){
                Console.WriteLine($"Podaj współrzędną X punktu {i+1}: ");
                double X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Podaj współrzędną Y punktu {i+1}");
                double Y = Convert.ToDouble(Console.ReadLine());

                punkty[i] = new Punkt(X, Y);
            }

            Console.WriteLine(Punkt.SingleLine(punkty));
        }
    }
 
}
