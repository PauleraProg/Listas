namespace Atividade_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine um número: ");
            double A = double.Parse(Console.ReadLine());

            if (0f <= A && A <= 25f)
            {
                Console.WriteLine($"{A} Intervalo [0,25]");
            }
            else if (25f <= A && A <= 50f)
            {
                Console.WriteLine($"{A} Intervalo (25,50]");
            }
            else if (50f <= A && A <= 75f)
            {
                Console.WriteLine($"{A} Intervalo (50,75]");
            }
            else if (75f <= A && A <= 100f)
            {
                Console.WriteLine($"{A} Intervalo (75,100]");
            }
            else
                Console.WriteLine("Fora de intervalo");

        }
    }
}
