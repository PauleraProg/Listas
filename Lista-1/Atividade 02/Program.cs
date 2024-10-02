namespace Atividade_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine dois números");
            string A = Console.ReadLine();
            int A2 = int.Parse(A);
            string B = Console.ReadLine();
            int B2 = int.Parse(B);

            int X = A2 + B2;
            Console.WriteLine($"X= {X}");


             
        }
    }
}
