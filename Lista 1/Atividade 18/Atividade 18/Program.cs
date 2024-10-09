namespace Atividade_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tempo decorrido e a velocidade do seu veículo: ");
            int T = int.Parse(Console.ReadLine());
            int Vel = int.Parse(Console.ReadLine());
            Console.WriteLine(Litros(T,Vel));

            static string Litros(int t, int v)
            {
                int dist = t * v;
                int L = dist / 12;

                return L.ToString("F3");
            }

        }
    }
}
