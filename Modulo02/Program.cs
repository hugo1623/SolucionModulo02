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
            List<int> numeros= new List<int>()
            {
                1,2,3,4,5
            };
            var suma = numeros.Sum();
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Hugo", Edad = 26, Salario=5 },
                new Persona(){Nombre ="Kyra", Edad=10, Salario=7},
                new Persona(){Nombre ="lulu", Edad=13, Salario=10},
                new Persona(){Nombre ="Dayron", Edad=15,Salario=5}
            };

            var totalSalario = personas.Sum(x => x.Salario);

            var miObjeto = new
            {
                TotalSalario = personas.Sum(x => x.Salario),
                Conteo= personas.Count

            };
        }
    }
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }
    }
}
