using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };
            //obteniendo los elementos de indice par
            var numerosMayoresQueCero = numeros.Where((x, indice) => indice % 2 == 0).ToList();

            Console.Read();
        }

        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

    }
}