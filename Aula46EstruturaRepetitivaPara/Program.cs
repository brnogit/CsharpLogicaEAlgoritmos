using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, soma;

            n = int.Parse(Console.ReadLine());

            soma = 0;
            for(int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
            Console.WriteLine("---------------------- Progressiva");

            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine("Valor de i: " + i);
            }
            Console.WriteLine("---------- Regressiva");

            for(int i = 4; i >= 0; i--)
            {
                Console.WriteLine("Valor de i: " + i);
            }
        }
    }
}