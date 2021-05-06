﻿using System;
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
            var primerelemnto = numeros.Where(x=> x>4).Skip(2).Take(3).ToList() ;

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Hugo", Edad = 26, Salario=5 },
                new Persona(){Nombre ="Kyra", Edad=10, Salario=7},
                new Persona(){Nombre ="lulu", Edad=13, Salario=10},
                new Persona(){Nombre ="Dayron", Edad=15,Salario=5}
            };
            var nombre = personas.Where(x => x.Edad < 18).Select(x =>
            new
            {



                Edad=x.Edad,
                Nombre=x.Nombre,
                Salario=x.Salario
            }
            ).FirstOrDefault();
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
