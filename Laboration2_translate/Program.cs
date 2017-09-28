using System;
using System.Collections.Generic;

namespace Laboration2_translate
{
    public class Program
    {
        static string animalSwe;
        static List<string> ListSwe;
        static List<string> ListSpa;
        private static int input;

        public static void SwedishList()
        {
            ListSwe = new List<string>();
            {
                ListSwe.Add("katt");
                ListSwe.Add("hund");
                ListSwe.Add("kanin");
                ListSwe.Add("häst");
                ListSwe.Add("ko");
                ListSwe.Add("gris");
                ListSwe.Add("höna");
            };

        }

        public static string SelectAnimal()
        {

            Console.WriteLine("Skriv in djur: ");
            animalSwe = Console.ReadLine();

            return animalSwe;
        }

        public static bool SearchSweList()
        {
            if (ListSwe.Contains(animalSwe))
                return true;
            return false;


        }

        public static void IndexPosSwe()
        {
            if (ListSwe.Contains(animalSwe))

                input = ListSwe.IndexOf(animalSwe);

        }
        public static void SpanishList()
        {
            ListSpa = new List<string>();
            {
                ListSpa.Add("gato");
                ListSpa.Add("perro");
                ListSpa.Add("conejo");
                ListSpa.Add("caballo");
                ListSpa.Add("vaca");
                ListSpa.Add("cerdo");
                ListSpa.Add("gallina");
            };
        }
        public static string IndexPosSpa(int input)
        {


            return ListSpa[input];

        }

        public static void Output()
        {

            Console.WriteLine(animalSwe + " på spanska heter " + IndexPosSpa(input) + ".");
            Console.WriteLine("Vill du översätta ett nytt djur? J/N");
            string answer = Console.ReadLine();
            if (answer == "J")
            {
                Main();
            }

            else Console.WriteLine("Tack för idag!");

        }
        public static void Main()
        {
            SwedishList();
            SelectAnimal();
            if (SearchSweList())
            {
                IndexPosSwe();
                SpanishList();
                Output();
            }
            else
            {
                Console.WriteLine("Ditt djur finns inte på listan.");
                Main();
            }
        }
    }
}
