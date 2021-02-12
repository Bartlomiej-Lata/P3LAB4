using System;

namespace P3_LAB4
{

    /*Stwórz aplikację, która pomoże lokalizować książki w bibliotece.
Stwórz klasę Książka (Ksiazka), która będzie miała pola/właściwości 
Tytuł,Autor a także dane służące lokalizacji - numer regału, numer półki i numer miejsca na półce.
Stwórz trójwymiarową tablicę prostokątną obiektów typu Książka.
Pierwszy wymiar odwzorowuje Regał, drugi Półkę a trzeci Miejsce.
Przyjmij, że w bibliotece są 3 regały po 6 półek po 10 miejsc każda.
Zapełnij tablicę książkami, wszystkie książki mogą nazywać się tak samo.
Każda książka powinna posiadać poprawne informacje o swojej lokalizacji.
Zmień tytuł i autora jednej dowolnej książki.
Pozwól użytkownikowy wpisać ciąg znaków. Spróbuj znaleźć książkę, 
której tytuł lub autor zawierają podany przez użytkownika ciąg znaków (wystarczy że choć wycinek jest zgodny).
Jeśli poszukiwana książka istnieje, wypisz użytkownikowi gdzie się znajduje. Przetestuj na zmienionej książce.

    */






    public class Ksiazka
    {

        public string Tytul { get; set; }
        public string Autor { get; set; }

        public static int NumerRegalu { get; set; }
        public static int NumerPolki { get; set; }
        public static int NumerMiejsca { get; set; }

        public Ksiazka() { }
        public Ksiazka(int NumR, int NumP, int NumM)
        {
            NumerRegalu = NumR;
            NumerPolki = NumP;
            NumerMiejsca = NumM;
        }



    }

     


    class Program
    {
        static void Main(string[] args)
        {

            Ksiazka testowa = new Ksiazka();
            bool istnieje = false;
            Console.WriteLine("Podaj dowolnego autora badz tytul ksiazki do wyszukania", Environment.NewLine);
            string podany = Console.ReadLine();

            Ksiazka[,,] tablica = new Ksiazka[3, 6, 10];


            for (int Nr = 0; Nr < 3; Nr++)
            {
                for (int Np = 0; Np < 6; Np++)
                {
                    for (int Nm = 0; Nm < 10; Nm++)
                    {
                        testowa = new Ksiazka(Nr, Np, Nm);
                        testowa.Autor = "Walter Isaacson";
                        testowa.Tytul = "Innowatorzy";


                    }

                }

            }
            testowa = new Ksiazka(1, 2, 3);
            testowa.Autor = "Stephen Hawking";
            testowa.Tytul = "Krótka historia czasu";

           

            if (testowa.Autor.Contains(podany, StringComparison.OrdinalIgnoreCase) 
                || testowa.Tytul.Contains(podany, StringComparison.OrdinalIgnoreCase))
            {
                istnieje = true;

            }

           else
            {
               istnieje = false;
            }

            void wyszukiwanie()
            {
                if (istnieje==true)
                {
                    Console.WriteLine("Wyszukiwana ksiazka istnieje i znajduje sie: "
                        + Environment.NewLine + "Na regale nr. " + (Ksiazka.NumerRegalu)
                        + Environment.NewLine + "Na polce nr. " + (Ksiazka.NumerPolki)
                        + Environment.NewLine + "Na miejscu nr. " + (Ksiazka.NumerMiejsca));
                }
                else
                {
                    Console.WriteLine("Wyszukiwana ksiazka nie istnieje");
                }
            }

            

            wyszukiwanie();


            
        }

     

    }
}