using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;


/* namespace zadaniepierwsze
{ 
    class DivNumbers { 
        int result;

    DivNumbers()
    {
        result = 0;
    
    }
    
    public void division(int a, int b)
    {
        try
        {
            result = a / b;
        } catch (DivideByZeroException e)
        {
            Console.WriteLine( "exception caught: {0}", e);
        } finally
        {
            Console.WriteLine("Result = {0}", result);
        }
    }
    static void Main(string[] args)
    {
        DivNumbers d = new DivNumbers();
            d.division(125, 0);
            Console.ReadKey();
    }
    }
}
*/

namespace zadaniedrugie
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            car mazda = new();
            Console.WriteLine("marka : ", mazda.marka);
           // mazda.pojemnoscSilnika = 13;
            Console.WriteLine(mazda.pojemnoscSilnika);
            car maluch = new(1.1, "fiat");
            Console.WriteLine(maluch.marka);
            car.shomi(maluch);

        }
    }
    public class car
    {
        public double pojemnoscSilnika;
        public string marka;
        int iloscKol = 4;
        
        public car()
        {
            this.pojemnoscSilnika = 0;
            this.marka = "x";
        }
        public car(double objetosc, string mark)
        {
            this.pojemnoscSilnika=objetosc;
            this.marka = mark;
            Console.WriteLine("przeciazenie");
        }

        public static void shomi(car samochod)
        {
            Console.WriteLine(samochod.marka);
            Console.WriteLine(samochod.pojemnoscSilnika);
            Console.WriteLine(samochod.iloscKol);

        }
         ~car()
        {
            MessageBox.Show("zwalniam pamiec");
        }
    }
}
