using System;

namespace ConsoleApp1
{
    class Program
    {
        public static double CenaProdukcji()
        {
            bool error = true;
            double cena = 0;
            do
            {
                Console.WriteLine("Podaj cene produkcji: ");
                if (double.TryParse(Console.ReadLine(), out cena))
                    error = false;
            } while (error);
            Console.WriteLine("Wybierz materiał");
            Console.WriteLine("1. Drewno - +0%");
            Console.WriteLine("2. Kamień - +10%");
            Console.WriteLine("3. Żelazo - +25%");
            Console.WriteLine("4. Stal - +50%");
            Console.WriteLine("5. Tytan - +100%");
            int opcja;
            do
            {
                if (int.TryParse(Console.ReadLine(), out opcja))
                    error = false;
            } while (error);
            switch (opcja)
            {
                case 1: return cena;
                case 2: return cena += cena * 0.1;
                case 3: return cena += cena * 0.25;
                case 4: return cena += cena * 0.5;
                case 5: return cena += cena;
            }

            return cena;
        }
        static void Main(string[] args)
        {
            Bilet bilet = new Bilet(10.00, "Bielsko", "Katowice", new DateTime(2020, 6, 1, 7, 47, 0), new DateTime(2020, 6, 1, 8, 47, 0));
            Console.WriteLine(Bilet.IlośćBiletów);

            Console.WriteLine(CenaProdukcji());

        }
    }
}
