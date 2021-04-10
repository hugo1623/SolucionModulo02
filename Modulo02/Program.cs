using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 5;
            double numero2 = 7;
            double numero3 = 10;
            double promedio = CalcularPromedio(4, 5, 6, 7, 3, 5, 7,10,100);
            
        }
        private static double CalcularPromedio(params int[] numeros)
        {
            double suma = 0;
            foreach (var numero in numeros)
            {
                suma = suma + numero;
            }
            return suma / numeros.Length;
        }

    }

}
