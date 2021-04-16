using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Vaca("kyra"));
            animales.Add(new Oveja("lulu"));

            foreach(var animal in animales)
            {
                animal.HacerRuido();
            }
            Console.Read();
        }
    }
    class Animal
    {
        public string Nombre { get; set; }
        public virtual void HacerRuido()
        {
            Console.WriteLine(" {0} hacer ruido", Nombre);
        }
    }
    class Vaca:Animal
    {
        public Vaca(string nombre)
        {
            Nombre = nombre;
        }
        public void HacerRuido()
        {
            Console.WriteLine("{0} dice muuu", Nombre);
        }
        public void Limpiar()
        {
            Console.WriteLine("La vaca {0}ha sido limpiada", Nombre);
        }
    }
    class Oveja:Animal
    {
        public Oveja(String nombre)
        {
            Nombre = nombre;
        }
        public void HacerRuido()
        {
            Console.WriteLine("{0} dice veee", Nombre);
        }
        public void Limpiar()
        {
            Console.WriteLine("La Obeja {0}ha sido Trasquilada", Nombre);
        }
    }
    
}
