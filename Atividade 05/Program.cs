namespace Atividade_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine dois números:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int prod = A * B;

            Console.WriteLine($"PROD = {prod}");
        }
    }
}
