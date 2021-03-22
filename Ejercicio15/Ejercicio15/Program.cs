using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valor)){
                Console.Write("El valor ingresado puede ser interpretado como número");
            }
            else
            {
                Console.Write("El valor ingresado no puede ser interpretado como número");
            }
            Console.ReadKey();
        }
    }
}
