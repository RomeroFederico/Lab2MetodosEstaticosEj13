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
            double pruebaDecimal = 12;
            string pruebaBinario = "0011";

            Console.Title = "Ejercicio Nro. 13";

            Console.WriteLine("{0} == {1}", pruebaDecimal, Conversor.DecimalBinario(pruebaDecimal));
            Console.WriteLine("{0} == {1}", pruebaBinario, Conversor.BinarioDecimal(pruebaBinario));
            Console.Write(Conversor.BinarioDecimal(Conversor.DecimalBinario(1)));

            Console.ReadKey();
        }
    }
}