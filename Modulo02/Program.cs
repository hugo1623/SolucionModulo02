using System;
using System.Collections.Generic;
namespace Modulo02
{
    class Program
    {
        static void Main(String[] arg)
        {
            var miDobleColeccion = new MiDobleColeccion<string, int>();
            miDobleColeccion.Agregar("Hugo", 26);
        }
    }
    interface IMiDoubleColeccion<T,M>
    {
        void Agregar(T valorT, M valorM);
    }

    class MiDobleColeccion<T, M>: IMiDoubleColeccion<T,M>
    {
        public List<T> MiListaDeT { get; set; }
        public List<M> MiListaDeM { get; set; }

        public MiDobleColeccion()
        {
            MiListaDeT = new List<T>();
            MiListaDeM = new List<M>();
        }
        public void Agregar(T valorT, M valorM)
        {
            MiListaDeT.Add(valorT);
            MiListaDeM.Add(valorM);
        }
    }
}
