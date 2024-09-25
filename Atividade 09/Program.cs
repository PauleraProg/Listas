namespace Atividade_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apresente suas informações de funcionário:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            double sal = double.Parse(Console.ReadLine());

            double salario = sal * B;
            string C = salario.ToString("F2");

            Console.WriteLine($"{A} = R$ {C}");
        }
    }
}
