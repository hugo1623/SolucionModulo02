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
                10,1,12,3,4,5
            };
            var min = numeros.Min();
            var max = numeros.Max();
            var promedio = numeros.Average();

            Console.WriteLine($"El menor número de la lista es {min} \n" + 
                $"El máximo valor de la lista es: {max} \n" +
                $"El promedio de la Lista es:{promedio} \n");
            

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Hugo", Edad = 26, Salario=5 },
                new Persona(){Nombre ="Kyra", Edad=10, Salario=7},
                new Persona(){Nombre ="lulu", Edad=13, Salario=10},
                new Persona(){Nombre ="Dayron", Edad=15,Salario=5}
            };

            var SalarioMinimo = personas.Min(x => x.Salario);
            var SalarioMaximo = personas.Max(x => x.Salario);
            var promedioEdad= personas.Average(x => x.Edad);

            Console.WriteLine($"El salario mínimo de la lista es {SalarioMinimo} \n" +
                 $"El  Salario máximo  de la lista es: {max} \n" +
                 $"El promedio Edad de la Lista es:{promedioEdad} \n");
        }
    }
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }
    }
}
