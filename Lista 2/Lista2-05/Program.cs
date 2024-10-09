namespace Lista2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x, y;
            x = new Aluno();
            y = new Aluno();

            Console.WriteLine("Diga seu nome e notas:");
            x.Nome = Console.ReadLine();
            x.Nota1 = double.Parse(Console.ReadLine());
            x.Nota2 = double.Parse(Console.ReadLine());
            x.Nota3 = double.Parse(Console.ReadLine());
            Console.Write("Sua média é: "); Console.WriteLine(Aluno.Media(x.Nota1,x.Nota2,x.Nota3));

            Console.WriteLine("Diga seu nome e notas:");
            y.Nome = Console.ReadLine();
            y.Nota1 = double.Parse(Console.ReadLine());
            y.Nota2 = double.Parse(Console.ReadLine());
            y.Nota3 = double.Parse(Console.ReadLine());
            Console.Write("Sua média é: "); Console.WriteLine(Aluno.Media(y.Nota1, y.Nota2, y.Nota3));
        }
    }
}
