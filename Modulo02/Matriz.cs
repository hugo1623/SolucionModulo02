using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo02
{
    public class Matriz
    {
        private int[,] _data;
        public Matriz(int Filas, int Columnas)//ctor
        {
            _data = new int[Filas, Columnas];
        }

        public int Filas { get { return _data.GetLength(0); } }
        public int Columnas { get { return _data.GetLength(1); } }
        public int this[int fila, int columna]
        {
            get
            {
                return _data[fila, columna];
            }
            set
            {
                _data[fila, columna] = value;
            }
        }
        public static Matriz operator +(Matriz matrizA, Matriz matrizB)
        {
            if(matrizA.Filas != matrizB.Filas || matrizA.Columnas != matrizB.Columnas)
            {
                throw new ApplicationException("Las matrices deben ser de la misma dimención");
            }
            Matriz resultado = new Matriz(matrizA.Filas, matrizA.Columnas);
            for(int i=0; i< matrizA.Filas;i++)
            {
                for(int j=0;j< matrizA.Columnas;j++)
                {
                    resultado[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            return resultado;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var tmpFila = new int[Filas];

            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    tmpFila[j] = this[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }
            return sb.ToString();            
        }

    }
}
