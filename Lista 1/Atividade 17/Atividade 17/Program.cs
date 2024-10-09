namespace Atividade_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Com quantos quilômetros você gostaria de fazer o cálculo?");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Tempo(km)} minutos");

            static int Tempo(int dist)
            {
                dist *= 2;
                return dist;
            }
        }
    }
}
