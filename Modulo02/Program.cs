using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listado1= new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };
            List<int> listado2 = new List<int>()
            {
                2,4,8,16,32,64
            };
            //instancias
            var sonParesTodos1 = listado1.All(x => x % 2 == 0);//no cumple ya q no todos son pares 
            var sonParesTodos2 = listado2.All(x => x % 2 == 0);// si cumple

            //Existe algun elemento que sea mayor que 1000
            var existeAlgunImpar = listado1.Any(x => x % 2 == 0);// no todos los elementos cumplen con la condicion dada -->tue
            
            var existeAlgunNumeroMayorQue100 = listado1.Any(x => x > 1000);//false   
        }
    }
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }
    }
}
