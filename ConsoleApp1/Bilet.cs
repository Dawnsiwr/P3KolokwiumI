using System;

namespace ConsoleApp1
{
    public class Bilet
    {
        public static int IlośćBiletów = 0;
        public double Cena { get; set; }
        public string Poczatek { get; set; }
        public string Koniec { get; set; }
        public DateTime DataZakupu { get; set; }
        public DateTime DataWyjazdu { get; set; }

        public Bilet(double cena, string poczatek, string koniec, DateTime dataZakupu, DateTime dataWyjazdu)
        {
            if (WalidujBilet(cena, poczatek, koniec, dataZakupu, dataWyjazdu) == false)
                throw new ArgumentException();
            else
            {
                Cena = cena;
                Poczatek = poczatek;
                Koniec = koniec;
                DataWyjazdu = dataWyjazdu;
                DataZakupu = dataZakupu;
                IlośćBiletów++;
            }
        }

        private bool WalidujBilet(double cena, string poczatek, string koniec, DateTime dataZakupu, DateTime dataWyjazdu)
        {
            if (cena <= 0)
                return false;
            if (poczatek.Equals(koniec))
                return false;
            if (DateTime.Compare(dataZakupu, dataWyjazdu) > 0)
                return false;
            return true;
        }

    }
}