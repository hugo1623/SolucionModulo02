using System;
using System.Collections.Generic;
using System.Linq;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar una lista y le pase elementos , puedo pasr cuantos elementos quiera
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);

            //Arreglos de numeros y el numero de elementos que tendra el arreglo =3.
            int[] arregloDeNumeros = new int[3];
            arregloDeNumeros[0] = 15;
            arregloDeNumeros[1] = 12;
            arregloDeNumeros[2] = 26;

            //Arreglo de string, se infiere el numero de elementos dentro de los parentesis
            string[] arregloDeString = new string[] { "luis", "C#", "Angular", "...", ".NET" };
            arregloDeString[4] = "Pyton";

            //Redimencionando un arreglo de 5 elementos a 6
            Array.Resize<string>(ref arregloDeString, 6);

            arregloDeString[6] = "Magento";
        }
    }
 
}
