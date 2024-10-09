namespace Atividade_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int mes = dias / 30;
            int D = dias % 30;
            int ano = mes / 12;
            int M = mes % 12;
            string B = $"{D:D2}";
            string C = $"{M:D2}";
            string E = $"{ano:D2}";
            Console.WriteLine($"{E}/{C}/{B}"); 
            
            
            
            
        }
    }
}
