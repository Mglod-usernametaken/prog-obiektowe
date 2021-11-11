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
            int rok = 2000;
            if (rok % 400 == 0)
                Console.WriteLine("ten rok jest przestepny.");
            else if ((rok % 4 == 0) && (rok % 100 != 0))
                Console.WriteLine(" ten rok jest rowniez przestepny");
            else
                Console.WriteLine("ten rok nie jest przestepny.");
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
            int a,b;
            Console.WriteLine("podaj liczbe a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
                Console.WriteLine("b jest dzielnikiem a");
            else
                Console.WriteLine("b nie dzieli a");
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
            int a, b, c;
            Console.WriteLine("podaj liczbe a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbe c");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                b = a;
            else if (a > c)
                b = c;

            Console.WriteLine(b);
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
            double a, b;
            string znak;
            Console.WriteLine("podaj liczbe a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("podaj znak operacji: ");
            znak = Console.ReadLine();

            if (znak == "+")
                Console.WriteLine(a + b);
            else if (znak == "-")
                Console.WriteLine(a -b);
            else if (znak == "*")
                Console.WriteLine(a * b);
            else if (znak == "/")
                Console.WriteLine(a / b);


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
            double a, b;
            string znak;
            Console.WriteLine("podaj liczbe a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("podaj znak operacji: ");
            znak = Console.ReadLine();

            
          //  if (znak == "+")
           //     Console.WriteLine(a + b);
           // else if (znak == "-")
           //     Console.WriteLine(a - b);
           // else if (znak == "*")
           //     Console.WriteLine(a * b);
           // else if (znak == "/")
           //     Console.WriteLine(a / b);
          
            switch (znak)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                        Console.WriteLine(a / b);
                        break;

                default:
                    Console.WriteLine("nie rozpoznano znaku");
                    break;
                    
            }

            Console.ReadKey();

        }
    }
}
*/ 
