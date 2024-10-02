namespace Lista2_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Relogio x;
            x = new Relogio();

            Console.WriteLine("Informe as horas, minutos e segundos:");
            x.Hora = int.Parse(Console.ReadLine());
            x.Minuto = int.Parse(Console.ReadLine());
            x.Segundo = int.Parse(Console.ReadLine());

            Console.WriteLine($"São: {Relogio.ExibirHoras(x.Hora,x.Minuto,x.Segundo)}");

        }
    }
}
