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
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };
            // OrderByDescending : para hacerlo descendente
            var numerosMayoresQueCero = numeros.Where(x => x > 0).OrderByDescending(x => x).ToList();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Hugo", Edad = 26, Salario=5 },
                new Persona(){Nombre ="Kyra", Edad=10, Salario=7},
                new Persona(){Nombre ="lulu", Edad=13, Salario=10 },
                new Persona(){Nombre ="Dayron", Edad=15,Salario=1}
            };
            //ThenBy:toma el resultado de un OrderBy y sigue ordenando en base a ese resultado 
            var listaDePersonasOrdenadas = personas.OrderBy(x => x.Salario).ThenBy(x => x.Nombre).ToString();
            Console.Read();
        }
    }
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }
    }
}
