using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Modulo02
{
    class Program
    {
        const double PI = 3.14;
        static readonly double PI_2 = RepositorioDeValores.PI;
        static void Main(string[] args)
        {
            var edad = 9;
            edad = 4;
            edad = 8;
        } 
    }
    public static class RepositorioDeValores
    {
        public static double PI = 3.1415;
    }
}
