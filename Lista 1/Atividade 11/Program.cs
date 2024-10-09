namespace Atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escaneie seus produtos:");
            Console.WriteLine("1: ");
            double[] peças = {double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())};
            Console.WriteLine("2: ");
            double[] peças2 = {double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())};

            Console.WriteLine($"Sua conta sai: R$ {Preço(peças[1], peças[2], peças2[1], peças2[2])}");


            static string Preço(double a, double b, double c, double d) 
            {
                a *= b;
                c *= d;
                double e = a + c;
                string preço = e.ToString("F2");

                return preço;
            }
        }
    }
}
