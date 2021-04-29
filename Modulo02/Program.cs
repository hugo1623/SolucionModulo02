using System;
using System.Collections.Generic;
namespace Modulo02
{
    class Program
    {
        static void Main(String[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.WriteLine("Primer Elemento Insertado:");
            Console.WriteLine("Primero");
            queue.Enqueue("Primero");

            Console.WriteLine("Segundo Elemento Insertado:");
            Console.WriteLine("Segundo");
            queue.Enqueue("Segundo");

            Console.WriteLine("Tercero Elemento Insertado:");
            Console.WriteLine("Tercero");
            queue.Enqueue("Tercero");
            /*Podemos iterar el queue para leer su contenido*/
            /*el queue esta vacio en este momento*/
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
 
}
