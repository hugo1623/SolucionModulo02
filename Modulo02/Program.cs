using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new vector(new List<int> { 1, 2 });
        }
        class vector
        {
            private List<int> _valores;
            //Costructor
            public vector(List<int> valores)
            {
                _valores= valores ;
            }
        }

            
    }
}
