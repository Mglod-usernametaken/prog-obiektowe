using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kolokwium2
{
    internal class Serwis
    {
        protected DateTime czas;

        protected double cena;

        internal Serwis( DateTime czas) 
        {
        this.czas = czas;
        }
        void obliczCene()
        { 
        
        }

    }

    internal class Polaczenie : Serwis
    {
        string numer = "";

        int czasP;

        public void obliczCene()
        {
            this.cena = this.czasP * 0.18;
            
        }
        public Polaczenie( DateTime start, string numr, int czasP) : base (start)
        {
            this.numer = numr;
            this.czasP = czasP;
            this.czas = start;
            obliczCene();
        }

        void toString()
        {
            Console.WriteLine("polaczenie numer: {0}, data i godzina rozmowy: {1}, dlugosc: {2}, laczny koszt: {3}", numer, czas, czasP, cena);

        }
    }

    internal class Sms : Serwis
    {
        string numer;
        void obliczCene()
        {
            this.cena = 0.08;
        }
        internal Sms(DateTime data, string numer) : base(data)
        {
            this.czas = data;
            this.numer = numer;
            obliczCene();
        }
        void toString()
        {
            Console.WriteLine("sms numer: {0}, data i godzina: {1}, laczny koszt: {3}", numer, czas, cena);

        }
    }

    internal class Internet : Serwis
    {
        int iloscMB;

        void obliczCene()
        {
            this.cena = Math.Round(((double)iloscMB / 755), 2);
        }
        internal Internet(DateTime czas, int dane) : base (czas)
        {
            this.czas = czas;
            this.iloscMB = dane;
            obliczCene();
        }
        void toString()
        {
            Console.WriteLine("internet, data i godzina: {0}, ilosc MB: {1},  laczny koszt: {2}", czas,iloscMB, cena);

        }
    }


}

