using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_13
{
    class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numero">
        /// Numero a convertir.
        /// </param>
        public static string DecimalBinario(double numero)
        {
            string binario = "";

            for (int i = 63; i >= 0; i--)
            {
                if (numero >= Math.Pow(2, i))
                {
                    numero -= Math.Pow(2, i);
                    binario += "1";
                }
                else
                    binario += "0";
            }

            for (int i = 0; i < 16; i++)
            {
                if (binario.StartsWith("0000"))
                {
                    binario = binario.Substring(4);
                }
            }

            return binario;
        }

        /// <summary>
        /// Convierte un numero binario a decimal.
        /// </summary>
        /// <param name="binario">
        /// Numero a convertir.
        /// </param>
        public static double BinarioDecimal(string binario)
        {
            int numero = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                    numero += (int) Math.Pow(2, binario.Length - i - 1);
            }

            return numero;
        }
    }
}
