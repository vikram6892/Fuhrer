using System;

namespace MuliDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] a = new int[4, 5];
            int i, j, k = 0;

            for(i = 0; i<4; i++){
                for(j = 0; j<5; j++){
                    a[i, j] = k;
                    k++;
                }
            }

            for (i=0; i<4; i++){
                for(j=0; j<5; j++){
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
