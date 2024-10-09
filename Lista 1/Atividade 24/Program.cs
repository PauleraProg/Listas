using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Atividade_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine 3 valores: ");
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double Delta = (B * B) - (4 * A * C);

            double raiz1 = (-B + Math.Sqrt(Delta)) / 2 * A;
            double raiz2 = (-B - Math.Sqrt(Delta)) / 2 * A;

            if (raiz1 == null || raiz2 == null)
            {
               Console.WriteLine("Impossível calcular");
            }
            else
            {
               Console.WriteLine($"Uma de suas raízes é: {raiz1.ToString("F5")}");
               Console.WriteLine($"Sua outra raíz é: {raiz2.ToString("F5")}");               
            }


        }
    }
}
