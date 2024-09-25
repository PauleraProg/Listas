namespace Atividade_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine dois números:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int soma = A + B;

            Console.WriteLine($"SOMA = {soma}");

            
        }
    }
}
