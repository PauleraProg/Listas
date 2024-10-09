namespace Atividade_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga quanto seu veículo percorreu e quanto gastou de combustível: ");
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Consumo(x,y)} km/l");

            static string Consumo(int A, double B) 
            {
                double kml = A / B;
                return kml.ToString("F3");
            }
        }
    }
}
