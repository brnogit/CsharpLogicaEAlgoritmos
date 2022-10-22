using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            char repetir;

            repetir = 's';
            while(repetir == 's') 
            { 
                Console.Write("Digite a tempetarua em Celsius");
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = 9.0 * c / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + f.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            }
        }
    }
}