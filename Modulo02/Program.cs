using System;
using System.Collections.Generic;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = DateTime.Today;
            if(o is DateTime)
            {
                var fecha = (DateTime)o;
            }
            
            else if (o is string)
            {
                var unString = (string)o;
            }
           
            Console.Read();
        }   
        public static void ToStringObjeto(Object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
