using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
        }
        private static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }
    
   abstract class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido generico");
        }
        protected void MetodoProtegido()
        {

        }
    }    
    class Perro: Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Woof");
            MetodoProtegido();
        }
        public void ElBaile()
        {
            Console.WriteLine(" Del Perrito");
        }
    }
    class Gato: Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miauu");
            MetodoProtegido();
        }
        public void ElBaile()
        {
            Console.WriteLine(" Del Gato");
        }
    }
}
