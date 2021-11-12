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
        static double Celsius(double fahr)
        {
            double celsius;
            celsius = (fahr/1.8)-28;
            return celsius;
        }
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("podaj temperature w F ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Celsius(a));
            Console.ReadKey();

        }
    }
}
*/

namespace zadaniedrugie
{
    class Program
    {

        static int Fibo(int wyraz) 
        { 
            //int ciag = 0;
            if (wyraz == 0)
                return 0;
            else if (wyraz == 1)
                return 1;
            else
                return Fibo(wyraz-2)+Fibo(wyraz-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(12));
        }
    }
}