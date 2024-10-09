namespace Lista2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto x, y;
            x = new Produto();
            y = new Produto();

            Console.WriteLine("Produto 1");
            Console.Write("Nome: "); x.Nome = Console.ReadLine();
            Console.Write("Preço: "); x.Preço = double.Parse(Console.ReadLine());//se usar vírgula ele escreve o preço certinho
            Console.Write("Quantidade: "); x.Quant = int.Parse(Console.ReadLine());
            Console.WriteLine(Produto.Info(x.Nome,x.Preço,x.Quant));

            Console.WriteLine("Produto 2");
            Console.Write("Nome: "); y.Nome = Console.ReadLine();
            Console.Write("Preço: "); y.Preço = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: "); y.Quant = int.Parse(Console.ReadLine());
            Console.WriteLine(Produto.Info(y.Nome,y.Preço,y.Quant));
        }
    }
}
