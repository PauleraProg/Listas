namespace Torre_de_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Com quantos discos você gostaria de usar? ");
            int disc = int.Parse(Console.ReadLine());

            Hanoi(disc, 'A', 'B', 'C');

            static void Hanoi(int n, char i, char m, char f) 
            {
                if (n == 1) 
                {
                    Console.WriteLine($"Mover disco {n} da haste {i} para a haste {f}");
                }
                else
                {
                    Hanoi(n-1, i, f, m);
                    Console.WriteLine($"Mover disco {n} da haste {i} para a haste {f}");
                    Hanoi(n-1, m, i, f);
                }
            }
        }
    }
}
