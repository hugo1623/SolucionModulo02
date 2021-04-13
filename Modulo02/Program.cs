using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( 5.ElevadoALa(3));
            Console.WriteLine(7.ElevadoALa(2));
            Console.WriteLine(15.Double());
            Console.Read();
        }
    }

        public static class   IntegerExtensionMethods
        {
            public static double ElevadoALa(this int valor, int exponente)
                {
                    return Math.Pow(valor, exponente);
                }
            public static double Double(this int valor)
                {
                    return valor * 2;
                }

        }
       
    

}
