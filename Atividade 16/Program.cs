namespace Atividade_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine os pontos de duas variáveis em um plano: ");
            Console.Write("X: "); List<double> X = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.Write("Y: "); List<double> Y = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(Dist(X[0], X[1], Y[0], Y[1]));

            static string Dist(double A, double B, double C, double D) 
            {
                double distancia = Math.Sqrt(Math.Pow((B - A), 2) + Math.Pow((D - C), 2));
                return distancia.ToString("F4");
            }
        }
    }
}
