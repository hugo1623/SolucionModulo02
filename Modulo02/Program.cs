using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new vector(new List<int> { 1, 2 });
            Console.WriteLine(v2.Componentes.ToString());
            Console.WriteLine(v2.Dimension);
            v2.Nombre = "Vector 1";
            Console.WriteLine(v2.Nombre);
            Console.Read();
        }
        class vector
        {
            //campo
            private List<int> _componentes;

            public int Dimension { get { return _componentes.Count; } }

            public string Nombre { get; set; }

            public List<int> Componentes
            {
                get
                {
                    return _componentes;
                }
            }

            //Costructor
            public vector(List<int> componentes)
            {
                _componentes = componentes;
            }
        }

            
    }
}
