using System;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcion anonima q se encarga de duplicar un numero entero

            // pq int , int --> pq la funcion anonima va a resivir un

            // parametro de entrada int y va a retornar el doble de ese nro
            // Ponemos duplicar como nombre a la variable esto sera igual
            // al valor de entrada q es "X"
            //En el cuerpo de la funcion {} lo q hace el cuerpo de la funcion
            //es tomar la x q lo pase como argumento y multiplicarlo x2
            Func<int, int> duplicar = x => { return x * 2; };
            Console.WriteLine(duplicar(35));

            Func<int, int> cuadrado = y => { return (int)Math.Pow(y, 2); };
            Console.WriteLine(cuadrado(8));

            Func<int, double> raiz = z => { return Math.Sqrt(z); };
            Console.WriteLine(raiz(15));
   
            Console.Read();
        } 
    }
    
}
