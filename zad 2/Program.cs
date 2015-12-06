using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class Class
    {

        static void Main(string[] args)
        {
            int w;
            int a, b;
            string A, B;
            Console.WriteLine("Napisz co chesz zrobic:");
            Console.WriteLine("1.Wpisac dwie liczby:");
            Console.WriteLine("2.Wpisać dwie litery:");
            w = Convert.ToInt16(Console.ReadLine());

            if (w == 1)
            {
               
                Console.WriteLine("Wpisz dwie liczby:");

                a = Convert.ToInt16(Console.ReadLine());
                b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Twoje liczby to: ");
              
                Class<int> liczby = new Class<int>();
                liczby.Wypisz<int>(ref a, ref b);
            }

            else if (w == 2)
            {
                
                Console.WriteLine("Wpisz dwie litery:");
                A = Convert.ToString(Console.ReadLine());
                B = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Twoje litery to: ");
                Class<string> litery = new Class<string>();
                litery.Wypisz<string>(ref A, ref B);

            }
            Console.ReadKey();
        }
    }

}
