using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            metodo1("valor1");
            Console.WriteLine("");
            metodo1("Felipe", "Mario");
            Console.Read();
        }
        private static void metodo1(string v1)
        {
            metodo1(v1, "valor2");
        }
        private static void metodo1( string v1, string v2 = "valor3")
        {
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
       
            
    }

}
