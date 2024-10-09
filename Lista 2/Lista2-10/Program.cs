namespace Lista2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temp x, y;
            x = new Temp();
            y = new Temp();

            Console.WriteLine("Determine uma temperatura em Celsius: ");
            x.GrausC = double.Parse(Console.ReadLine());
            Console.WriteLine($"Em Fahrenheit fica: {Temp.Fahrenheit(x.GrausC)}");
            Console.WriteLine($"Em Kelvin fica: {Temp.Kelvin(x.GrausC)}");

            Console.WriteLine("Determine uma temperatura em Celsius: ");
            y.GrausC = double.Parse(Console.ReadLine());
            Console.WriteLine($"Em Fahrenheit fica: {Temp.Fahrenheit(y.GrausC)}");
            Console.WriteLine($"Em Kelvin fica: {Temp.Kelvin(y.GrausC)}");
        }
    }
}
