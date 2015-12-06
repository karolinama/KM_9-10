using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Bazowa
    {
         public void wypisz()
      {
          Console.WriteLine("Jestem z klasy bazowej");
      }
      
        public virtual void wypisz()
        {
            Console.WriteLine("Jestem z klasy bazowej");
        }
       
     
        public virtual final void wypisz()  
        {
             Console.WriteLine("Jestem z klasy bazowej");
        }
        
    }
}
