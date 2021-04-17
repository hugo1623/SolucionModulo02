﻿using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.Read();

        }
        public static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }
    class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido Generico");
        }
    }
    class Perro:Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("woof");
        }
    }
    class Gato:Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }
    class Pelicano : Animal
    {
        public override void HacerRuido()
        {
            base.HacerRuido();
        }
    }
    class Gusano:Animal
    {

    }

}
