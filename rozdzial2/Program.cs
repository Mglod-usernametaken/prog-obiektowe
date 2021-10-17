using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


/*
namespace zadaniepierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;
            Console.WriteLine("podaj temperature w stopniach Celsiusza:");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = 32 + (9 * celsius) / 5;
            Console.WriteLine(fahrenheit);
            Console.ReadKey();

        }
    }
}

*/


/*
namespace zadaniedrugie
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta;
            int a, b, c;
            Console.WriteLine("podaj wspolczynnik a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj c: ");
            c = int.Parse(Console.ReadLine());

            delta = (double)b * b - 4 * a * c;
            Console.WriteLine("delta = {0}", delta);
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
            double bmi, mass, height;
            Console.WriteLine("podaj swoja wage w kilogramach: ");
            mass = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj wzrost w metrach: ");
            height = double.Parse(Console.ReadLine());
            bmi = mass / (height * height);
            Console.WriteLine("twoje BMI wynosi {0}", bmi);
            Console.ReadKey();
        }
    }
}
*/

/*
namespace zadanieczwarte
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(++x * 2); // wynikiem będzie 202, ponieważ pierszeństwo działania będzie miało ++ przed x
            // przez co mnożona będzie liczba 101
            Console.ReadKey();
        }
    }
}
*/
// zadanie piąte - wynikiem bedzie 12, gdyż y*2 wykona się przed przypisaniem wartości do x

//zadanie szóste - x przyjmie wartość 3. po pierwszej linijce x=4, y=2, po drugiej x=2 y=3, po trzeciej x=3, y=2

//zadanie siódme - 7. w pierwszej linijce do zoztaje przypisane 6, druga i trzecia w sumie nie zmieniają wartości y, w Console.WriteLine pierszeństwo nad wyświetleniem ma operator ++

//zadanie 8 - odpowiedż C, gdyż po ustaleniu, że  y==1 jest prawdziwe,  kompilator pominie resztę i operacja z++ się nie wykona

/* zadanie 9
 a) bool =0, x=2, y=4, z=2; program zakończy sprawdzanie po ustaleniu wartości logicznej x++>1

b) bool=0, x=2, y=5, z=2; kompilator zakończy tuż przed &&

c) bool 0, x=2, y=5, z=2; pojedynczy & nie przerywa sprawdzania wartości iloczynów logicznych, więc wszystkie inkrementacje będąmogły się wykonać

d) bool 1, x=1, y=3, z=4; kompilator przerwie po ustaleniu prawdziwości x==1

e) bool=1, x=1, y=4, z=4; tylko ++z >0 nie zostanie sprawdzony

f) bool=1, x=1, y=4, z=5; pojedyncze | umożliwią kompilatorowi wykonanie wszystkich operacji
 
 */

namespace zadaniedziesiate
{
    class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia; //bez (double) zachodzi zaokrąglenie do całkowitych
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}