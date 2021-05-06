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
            var grupos2= numeros.GroupBy(x=>Math.Abs(x%2)) ;
            
            foreach(var clase in grupos2)
            {
                Console.WriteLine("Numeros cuyo residuo es " + clase.Key);
                foreach(var numero in clase)
                {
                    Console.WriteLine(numero);
                }
                Console.WriteLine("");
            }

            // Ejemplo2: Separando por grupos de Edad
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Hugo", Edad = 26, Salario=5 },
                new Persona(){Nombre ="Kyra", Edad=10, Salario=7},
                new Persona(){Nombre ="lulu", Edad=13, Salario=10},
                new Persona(){Nombre ="Dayron", Edad=15,Salario=5}
            };
            var GrupoDePersonas = personas.GroupBy(X =>
            {
                if(X.Edad <=20)
                { return "Menor que 20";}
                else if (X.Edad >= 21 && X.Edad <=40)
                {return "Entre 21 y 40";}
                else
                {return "Mayores que 41";}
            });
            foreach (var grupoPersona in GrupoDePersonas)
            {
                Console.WriteLine("Grupo de:" + grupoPersona.Key + "---cantidad : "+ grupoPersona.Count());
                foreach (var persona in grupoPersona)
                {
                    Console.WriteLine(persona.Nombre);
                }
                Console.WriteLine("");
            }
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
