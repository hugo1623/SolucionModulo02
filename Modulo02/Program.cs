using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {   var v1 = new vector(new List<int> { 3, 4 });
            var v2 = new vector(new List<int> { 1, 2 });
            vector vectorSuma = v1.Suma(v2);
            Console.Read();
        }
    }
        class vector
        {   //campo
            private List<int> _componentes;
            public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }
            //Indexador
            public int this[int i]
            {
                get{ return _componentes[i];}
                set{ _componentes[i] = value;}
            }

            public int Dimension { get { return _componentes.Count; } }
             //Costructor
            public vector(List<int> componentes)
            {
                _componentes = componentes;
            }

            public vector Suma(vector v2)
            {
                if(Dimension != v2.Dimension)
                {
                    throw new ApplicationException("La dimensiones no son iguales");
                }
                List<int> resultado = new List<int>();

                for(int i=0; i< Dimension; i++)
                {
                    resultado.Add(this[i] + v2[i]);
                }

                return new vector(resultado);
            }
        }   
}
