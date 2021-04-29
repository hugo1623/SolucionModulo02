using System;
using System.Collections.Generic;
using System.Linq;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> conjunto1 = new HashSet<int>();

            conjunto1.Add(5);
            conjunto1.Add(7);

            HashSet<int> conjunto2 = new HashSet<int>();

            conjunto2.Add(5);
            conjunto2.Add(8);
            //union=5,7,8
            HashSet<int> union_set1_set2 = new HashSet<int>(conjunto1);
            union_set1_set2.UnionWith(conjunto2);
            //interseccion=5
            HashSet<int> interseccion_set1_set2 = new HashSet<int>(conjunto1);
            interseccion_set1_set2.IntersectWith(conjunto2);
            //diferencia de aquellos elementos que no se encuentran en el conjunto1=7
            HashSet<int> diferencia_set1_set2 = new HashSet<int>(conjunto1);
            diferencia_set1_set2.ExceptWith(conjunto2);
            // Diferencia entre los 2 conjuntos= 7,8
            HashSet<int> diferencia_simetrica_set1_set2 = new HashSet<int>(conjunto1);
            diferencia_simetrica_set1_set2.SymmetricExceptWith(conjunto2);

            //Utilizando un conjunto de elementos vamos a eliminar los elementos comunes de las lista
            List<int> numeros = new List<int>() { 1, 2, 3, 5, 6, 7, 3, 2, 2, 1, 3, 42, 2, 3, 34, 2, 2, 2, 3 };
            numeros = new HashSet<int>(numeros).ToList();
        }
    }
 
}
