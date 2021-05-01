using System;
using System.Text;

namespace Modulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggeArray = new int[2][];
            jaggeArray[0] = new int[4];
            jaggeArray[0][0] = 6;
            jaggeArray[0][1] = -3;
            jaggeArray[0][2] = 9;
            jaggeArray[0][3] = -150;
            jaggeArray[1] = new int[]
            {
                15,6,3,2,6,7,8,-100
            };

            for (int i = 0; i < jaggeArray.GetLength(0); i++)
            {
                var join = string.Join(",", jaggeArray[i]);
                Console.WriteLine(join);
            }
            Console.Read();
        }
    }
}
