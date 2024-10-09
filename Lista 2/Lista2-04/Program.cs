namespace Lista2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro x, y;
            x = new Carro();
            y = new Carro();

            Console.WriteLine("Escolha um carro: ");
            Console.Write("Marca: "); x.Marca = Console.ReadLine();
            Console.Write("Modelo: "); x.Modelo = Console.ReadLine();
            Console.Write("Ano: "); x.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine(Carro.Detalhes(x.Marca,x.Modelo,x.Ano));

            Console.WriteLine("Escolha outro carro: ");
            Console.Write("Marca: "); y.Marca = Console.ReadLine();
            Console.Write("Modelo: "); y.Modelo = Console.ReadLine();
            Console.Write("Ano: "); y.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine(Carro.Detalhes(y.Marca, y.Modelo, y.Ano));
        }
    }
}
