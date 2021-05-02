using System;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<Persona> predicado = EsMayorDeEdad;
            var p = new Persona()
            {
                Nombre = "Luis",
                Edad = 26
            };
            Console.WriteLine(predicado(p));
            Console.Read();
        }
        static bool EsMayorDeEdad(Persona persona)
        {
            return persona.Edad >= 18;
        }
    }
    public  class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
