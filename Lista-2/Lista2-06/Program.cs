namespace Lista2_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo x, y;
            x = new Retangulo();
            y = new Retangulo();

            Console.WriteLine("Dê as medidas de um retângulo: ");
            Console.Write("Largura: "); x.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: "); x.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Área: {Retangulo.Area(x.Largura,x.Altura)}");

            Console.WriteLine("Dê as medidas de outro retângulo: ");
            Console.Write("Largura: "); y.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: "); y.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Área: {Retangulo.Area(y.Largura, y.Altura)}");
        }

    }
}
