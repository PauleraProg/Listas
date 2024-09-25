namespace Atividade_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine 4 valores:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine($"DIFERENCA = {Diferenca(A, B, C, D)}");

            static int Diferenca(int a, int b, int c, int d) 
            {
                int diferenca = (a * b) + (c * d);

                return diferenca;
            }
        }
    }
}
