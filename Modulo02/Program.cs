using System;
using System.Collections.Generic;
namespace Modulo02
{
    class Program
    {
        static void Main(String[] arg)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Hugo");
            nombres.Add("Luis");
            nombres.Add("5");

            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numeros.Add(0);
            // remueve un elemento en especifico Nro 3 ahora la lista sera {1,2,4,5,6}
            numeros.Remove(3);
            // remueve el primer elemeneto de indice 0 ={2,3,4,5,6}
            numeros.RemoveAt(0);
            // remueve el ultimo elemento 
            numeros.RemoveAt(numeros.Count - 1);
            //insertar un elemento en una posicion especifica
            numeros.Insert(0, 100);
            numeros.Insert(4, -100);

            var primerelementoDeLaLista = numeros[0];

            Console.Read();
        }
    }
 
}
