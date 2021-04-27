using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalito1 = new { animal = "perro", nombre = "Max", vidas = 1 };
            var animalito2 = new { animal = "gato", nombre = "Kyra", vidas = 7 };
            //dynamic es un truco de C# para permitirns utilixar tipos variables.
            List<dynamic> animalitos = new List<dynamic>();

            animalitos.Add(animalito1);
            animalitos.Add(animalito2);

            foreach (dynamic animalito in animalitos)
            {
                Console.WriteLine("El {0} de nombre {1} tiene {2} vidad",
                    animalito.animal,animalito.nombre, animalito.vidas);
            }
            Console.Read();
        }
    }
    //Clase persona
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }    
}
