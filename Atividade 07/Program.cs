namespace Atividade_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe suas notas: ");
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {Media(A, B, C)}");

            static string Media(double x, double y, double z)
            {
                x *= 2.0;
                y *= 3.0;
                z *= 5.0;

                double Z = (x + y + z) / 10;
                string media = Z.ToString("F1");
                return media;
            }
        }
    }
}
