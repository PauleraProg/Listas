using System.Diagnostics;

namespace Atividade_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine um número: ");
            double num = int.Parse(Console.ReadLine());

            double[] cedulas = {100, 50, 20, 10, 5, 2, 1};

            double[] countC = new double[7];

            for (int i = 0; i <= 6; i++) 
            {
                countC[i] = Math.Floor(num / cedulas[i]);
                num = num - (countC[i] * cedulas[i]);
                if (countC[i] > 0)
                {
                    Console.WriteLine($"{countC[i]} notas de {cedulas[i]}");
                }
            }
        }
    }
}
