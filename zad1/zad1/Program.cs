using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bazowa B = new Bazowa();
            Pochodna P = new Pochodna();
            b.wypisz();
            p.wypisz();

            Bazowa* bptr = &p;
            bptr->wypisz();
        }
    }
}
