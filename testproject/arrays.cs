using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproject
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[,] array;
            int[,] array2 = new int[2, 3];
            int[,] array3 = { 
                { 2, 3, 4 },
                { 4, 5, 1 },
                { 7, 0, 9 } };

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i, j] + " ");
                }
            }
           
        }
    }
}
