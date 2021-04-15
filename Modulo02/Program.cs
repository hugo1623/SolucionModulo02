using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var iteradordeLista = new IteradorDeLista();
            iteradordeLista._lista = new List<int>() { 1, 2, 3 };
            iteradordeLista.EscribirLista();
            Console.Read();

        }

    }
    class IteradorDeLista
    {
        public IteradorDeLista()
        {
            _lista=new List<int>();
        }
        public List<int> _lista;
        public void EscribirLista()
        {
            foreach(var item in _lista)
                {
                    Console.WriteLine(item);
                }
        }
            
    }

    
}
