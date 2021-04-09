using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {   var v1 = new Vector(new List<int> { 3, 4 });
            var v2 = new Vector(new List<int> { 1, 2 });
            Vector vectorSuma = v1.Suma(v2);
            Vector vectorSuma2 = v1 + v2;
            Console.Read();
        }
    }
    class Vector
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
            get { return _componentes[i]; }
            set { _componentes[i] = value; }
        }
        public int Dimension { get { return _componentes.Count; } }
        //Costructor
        public Vector(List<int> componentes)
        {
            _componentes = componentes;
        }
        public static Vector operator +(Vector vector1, Vector vector2)
        {
         return vector1.Suma(vector2);
        }
            public Vector Suma(Vector v2)
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
                return new Vector(resultado);
            }
        }   
}
