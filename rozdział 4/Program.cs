using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

/*
namespace zadaniepierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("podaj dlugosc tablicy");
            a = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[a];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("podaj {0} element tablicy ", i + 1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);



            Console.ReadKey();

        }
    }
}
*/

/*
namespace zadanietrzecie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("podaj dlugosc tablicy");
            a = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[a];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("podaj {0} element tablicy ", i + 1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for (int i = 0; i < tab.Length; i++)
            //   Console.WriteLine(tab[i]);

            int biggest = 0;    //index of the biggest elem
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] > biggest)
                    biggest = i;

            Console.WriteLine("indeks najwyzszej wartosci : {0}", biggest);

            int smallest = 0;    //index of the smallest elem
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] < smallest)
                    smallest = i;

            Console.WriteLine("indeks najnizszej wartosci : {0}", smallest);

            double sum = 0;     //avg of the table
            foreach (int i in tab)
                sum = sum + i;

            Console.WriteLine("srednia tablicy = {0}", sum / tab.Length);


            int positive = 0;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] >= 0)
                    positive += 1;
            Console.WriteLine("liczba dodatnich elementów = {0}", positive);
            Console.ReadKey();

        }
    }
}
*/

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("podaj dlugosc tablicy");
            a = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[a];
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("podaj {0} element tablicy ", i + 1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();

        }
    }
}