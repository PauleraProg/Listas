namespace Lista2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Insira seu nome e idade: ");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"No seu próximo aniversário você fará {Pessoa.Aniversario(x.Idade)} anos.");
        }
    }
}
