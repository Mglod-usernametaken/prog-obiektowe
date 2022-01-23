using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium2
{
    public interface IBilling
    {
        void ZapiszBilling();
    }

    public class Billing : IBilling
    { 
        public void ZapiszBilling()
        {

        }
    }
    public interface IDodaj
    {
        void DodajPolaczenie(string numer, int czasP);
        void DodajSms(string numer);
        void DodajInternet(int iloscMB);
    }

    public class Dodaj : IDodaj
    {
        public void DodajPolaczenie(string numer, int czasP) { }
        public void DodajSms(string numer) { }
        public void DodajInternet(int iloscMB) { }
    }
}
