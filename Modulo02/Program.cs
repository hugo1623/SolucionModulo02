using System;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz = new Matriz(2, 2);
            matriz[0, 0] = 5;
            matriz[0, 1] = -5;
            matriz[1, 0] = 1;
            matriz[1, 1] = 4;

            Matriz matrizB = new Matriz(2, 2);
            matrizB[0, 0] = 1;
            matrizB[0, 1] = 6;
            matrizB[1, 0] = 3;
            matrizB[1, 1] = 10;

            Console.WriteLine("Matriz 1");
            Console.WriteLine(matriz.ToString());

            Console.WriteLine("");
            Console.WriteLine("Matriz 2");
            Console.WriteLine(matrizB.ToString());

            Console.WriteLine("");
            Console.WriteLine("Matriz Resultante");
            Matriz matrizSuma = matriz + matrizB;
            Console.WriteLine(matrizSuma.ToString());

            Console.Read();
        }
         //Metodo para visualizar la matriz
        public static void EscribirArregloBidimencionalEnPantalla<T>(T[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpFila = new T[matriz.GetLength(0)];

            for(int i=0;i<filas;i++)
            {
                for (int j=0;j<columnas;j++)
                {
                    tmpFila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }
    }
 
}
