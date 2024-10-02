namespace Lista2_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme x, y;
            x = new Filme();
            y = new Filme();

            Console.WriteLine("Dê os dados de um filme: ");
            x.Titulo = Console.ReadLine();
            x.Genero = Console.ReadLine();
            x.Duracao = double.Parse(Console.ReadLine());

            Console.WriteLine(Filme.ExibirInfo(x.Titulo,x.Genero,x.Duracao));

            Console.WriteLine("Dê os dados de outro filme: ");
            y.Titulo = Console.ReadLine();
            y.Genero = Console.ReadLine();
            y.Duracao = double.Parse(Console.ReadLine());

            Console.WriteLine(Filme.ExibirInfo(y.Titulo, y.Genero, y.Duracao));
        }
    }
}
