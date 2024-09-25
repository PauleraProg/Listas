namespace Atividade_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine 3 números: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (C <= Maior(A,B)) 
            {
                Console.WriteLine($"{Maior(A, B)} eh o maior");
            }
            else 
            {
                Console.WriteLine($"{C} eh o maior");
            }

            static int Maior(int A, int B) 
            {
                int maior = (A + B + Math.Abs(A-B)) / 2;
                return maior;
            }
        }
    }
}
