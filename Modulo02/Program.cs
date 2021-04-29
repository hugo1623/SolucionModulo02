using System;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 2];
            matriz[0, 0] = 5;
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 5;

            int[,] matrizB = new int[2, 2]
            {
                {3,2 },{1,3}
            };

            string[,] matrizC = new string[3, 2]
            {
                { "valor1","valor2"},
                { "valor3", "valor4"},
                { "valor5","valor6"},
            };
            EscribirArregloBidimencionalEnPantalla(matriz);
            Console.Read();
        }
         //Metodo para visualizar la matriz
        public static void EscribirArregloBidimencionalEnPantalla(int[,] matriz)
        {
        //Obteniendo las dimensiones de las filas y las columna utitizando el metodo GerLength,
        //0->Dimencion de las Filas y 1-> dimencion de las columnas, cuantas filas y columnas tiene
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);// 

            //inicializamos un stringBuilder,nos ayuda a construir paso a paso un string, nos sirve
            //para ir costruyendo fila a fila el resultado de la lectura
            var sb = new StringBuilder();

            //hacemos una variable temporal
            var tmpFila = new int[matriz.GetLength(1)];

            //realizamos un for para iterar por fila
            for(int i=0;i<filas;i++)
            {
                //realizamos un for para iterar las columnas
                for (int j=0;j<columnas;j++)
                {
                    //llenamos la fila temporal con los valores de la fila actual
                    tmpFila[j] = matriz[i, j];
                }
                // a la fila actual le hacemos un Join para que nos escriba los valores en secuenci
                sb.AppendLine(string.Join("\t", tmpFila));
                //agregamos una fila vacia
                sb.AppendLine("");
            }
            //escribo en consola
            Console.WriteLine(sb.ToString());
        }
    }
 
}
