using System;
using System.Collections.Generic;
namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Primer Elemento Insertado:");
            Console.WriteLine("A");
            stack.Push("A");

            Console.WriteLine("Segundo Elemento Insertado:");
            Console.WriteLine("B");
            stack.Push("B");

            Console.WriteLine("Tercero Elemento Insertado:");
            Console.WriteLine("C");
            stack.Push("C");

            Console.WriteLine("Primer Elemento Extraido:");
            // metodo pop no recive parametros y nos devuelve
            // el ultimo elemento de la lista
            var primerElementoRemovido = stack.Pop();
            Console.WriteLine(primerElementoRemovido);

            Console.WriteLine("Segundo Elemento Extraido:");
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Tercero Elemento Extraido:");
            Console.WriteLine(stack.Pop());
            Console.WriteLine();
            Console.Read();
        }
    }
 
}
