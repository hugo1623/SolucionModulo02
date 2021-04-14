using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
        }
    }
    static class Matematicas
    {
        const double PI = 3.1415;
        public static int Suma(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        public static double AreaDelCirculo(int radio)
        {
            return radio * radio * PI;
        }
        
    }
    class Factura
    {
         public int Id { get; set; }
         public decimal Monto { get; set; }
    }
    class Facturarepositorio
    {
        public void GuardarEnBaseDeDatos(Factura factura)
        {
            //Codigo para guerdar la factura en la base de Datos
        }
    }
}
