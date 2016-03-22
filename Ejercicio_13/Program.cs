using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_13
{
    /*    
    13.  Desarrollar una clase llamada 'Conversor', que posea dos métodos 
    de clase (estáticos): 
    string DecimalBinario(double). Convierte un número de 
    decimal a binario. 
    double BinarioDecimal(string). Convierte un número binario a 
    decimal.  
    */

    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 13";

            Console.Write(Conversor.BinarioDecimal(Conversor.DecimalBinario(0)));

            Console.ReadKey();
        }
    }
}
