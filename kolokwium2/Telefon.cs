using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace kolokwium2
{
    internal class Telefon
    {
        private List<Serwis> billing = new List<Serwis>();

        internal void DodajPolaczenie(string numer, int czasP)
        {
            billing.Add(new Polaczenie(DateTime.Now, numer, czasP));
        }

        internal void DodajSms(string numer)
        {
            billing.Add(new Sms(DateTime.Now, numer));
        }

        internal void DodajInternet( int dane)
        {
            billing.Add(new Internet(DateTime.Now, dane));
        }

        internal void ToString()
        {
            for(int i = 0; i < billing.Count; i++)
            {
                Console.WriteLine(billing[i].ToString());
            }
        }
        /*internal static async Task ZapiszBilling()
        {
            string lines = billing;
            using StreamWriter file = new("billing.txt");
            foreach (string line in lines)
            {
                await file.WriteLineAsync(line);
            }

        }*/
    }
}
