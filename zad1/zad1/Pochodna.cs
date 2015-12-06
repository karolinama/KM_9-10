using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Pochodna
    {
         public void wypisz()    
        {
            Console.WriteLine("Jestem z klasy pochodnej");
        }

      public override void wypisz()
         {
             Console.WriteLine(" Jestem z klasy pochodnej ");        
         }

        public void wypisz();  
          { 
              Console.WriteLine(" Jestem z klasy pochodnej "); 
          } 
    }
}
