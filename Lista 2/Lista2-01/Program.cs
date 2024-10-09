namespace Lista2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro x, y;
            x = new Livro();
            y = new Livro();

            Console.WriteLine("Informe os detalhes do primeiro livro:");
            x.titulo = Console.ReadLine();
            x.autor = Console.ReadLine();
            x.numeroPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine(Livro.Info(x.titulo,x.autor,x.numeroPaginas));

            Console.WriteLine("Informe os detalhes do segundo livro: ");
            y.titulo = Console.ReadLine();
            y.autor = Console.ReadLine();
            y.numeroPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine(Livro.Info(y.titulo,y.autor,y.numeroPaginas));
        }
    }
}
