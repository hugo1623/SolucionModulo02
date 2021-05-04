using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,22
            };
            var result = numeros.Where(x => x > 0).ToList();
            Console.Read();
        } 
    }
    
}