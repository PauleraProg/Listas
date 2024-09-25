namespace Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apresente seu nome, salário e montante:");
            string A = Console.ReadLine();
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            C *= 0.15;
            C += B;
            string salario = C.ToString("F2");

            Console.WriteLine($"O funcionário {A} deverá receber {salario}");

            
        }
    }
}
