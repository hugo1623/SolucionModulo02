using System;
using System.Text;

namespace Modulo02
{
    class Program
    {
        delegate void DelegadoEjemplo(int c, string h);
        public delegate string DeEnteroAString(int valor);
        static void Main(string[] args)
        {
            var delegadoEjemplo = new DelegadoEjemplo(Ejemplo);
            delegadoEjemplo(4, "8");

            var deEnteroAString = new DeEnteroAString(FuncionRetornaToString);
            var deEnteroAStringMasUno = new DeEnteroAString(FuncionRetornaToStringMas1);

            //Console.WriteLine(deEnteroAString(10));
            //Console.WriteLine(deEnteroAStringMasUno(10));

            Template(deEnteroAString, 10);
            Console.Read();
        }
        public static string FuncionRetornaToString(int valor)
        {
            return valor.ToString();
        }
        public static string FuncionRetornaToStringMas1(int valor)
        {
            return (valor+1).ToString();
        }
        public static void Ejemplo(int a, string b)
        {

        }
       
        public static void Template(DeEnteroAString algororitmo, int valor)
        {
            Console.WriteLine("Hacer algo antes del algoritmo");
            Console.WriteLine(algororitmo(valor));
            //algoritmo
            Console.WriteLine("Hacer algo despues del algoritmo");
        }
    }
}
