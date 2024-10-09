using System.Security.Cryptography.X509Certificates;

namespace Atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Determine o raio da esfera:");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"VOLUME = {Volume(raio)}");

            static string Volume(double A) 
            {
                double pi = 3.14159;
                double volume = (4.0 / 3.0) * pi * Math.Pow(A, 3);
                string read = volume.ToString("F3");
                return read;
            }
        }
    }
}
