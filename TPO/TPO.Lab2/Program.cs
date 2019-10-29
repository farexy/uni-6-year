using System;

namespace TPO.Lab1
{
    class Program
    {
        private static float[,] Gen(int n, int m)
        {
            var rnd = new Random();
            var res = new float[n * m, n * m];

            for (int i = 0; i < n; i++)
            {
                for (int l = i * m; l < i * m + m; l++)
                {
                    for (int k = i * m; k < i * m + m; k++)
                    {
                        res[l, k] = rnd.Next(1, 10);
                    }
                }
            }

            return res;
        }

        private static float[] Gen(int n)
        {
            var rnd = new Random();
            var res = new float[n];

            for (int i = 0; i < n; i++)
            {
                res[i] = rnd.Next();
            }

            return res;
        }

        private static void Show(float[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var n = 10;
            var m = 10;
            var mat = Gen(n, m);
            Show(mat);
//            Console.WriteLine("Hello World!");
        }
    }
}