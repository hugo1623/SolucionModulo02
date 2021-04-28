using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Nombre = "Luis" };
            var xml_persona1 = Serializar<Persona>(persona1);
            var empresa1= new Empresa() { Direccion = "Fm" };
            var xml_empresa1 = Serializar<Empresa>(empresa1);
        }
        private static string Serializar<T>(T valor)
        {
            var serializador = new XmlSerializer(typeof(T));
            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, valor);
                    return escritorString.ToString();
                }
            }
        }     
    }
   public class Persona
    {
        public string Nombre { get; set; }
    }
   public class Empresa
    {
        public string Direccion { get; set; }
    }
}
