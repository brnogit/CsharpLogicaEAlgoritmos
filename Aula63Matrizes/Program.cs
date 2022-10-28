using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A; // declarando matriz

            string[] vetorLeitor = Console.ReadLine().Split(' ');
            M = int.Parse(vetorLeitor[0]);
            N = int.Parse(vetorLeitor[1]);
            A = new int[M, N];

            for (int i=0; i<M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j<N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i<M; i++)
            {
                for(int j=0; j<N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
