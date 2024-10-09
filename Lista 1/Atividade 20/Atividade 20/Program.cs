namespace Atividade_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine a quantidade de segundos: ");
            int seg = int.Parse(Console.ReadLine());

            Console.WriteLine(Tempo(seg));

            static string Tempo(int A) 
            {
                TimeSpan time = TimeSpan.FromSeconds(A);
                string read = time.ToString(@"hh\:mm\:ss");
                return read;
            }
        }
    }
}
