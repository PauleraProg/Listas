namespace Atividade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um valor para o raio:");

            string A = Console.ReadLine();
            double A2 = double.Parse(A);
           

            Console.WriteLine($"A= {Area(A2)}" );


            static string Area(double x)
            {
                double pi = 3.14159;

                double A = pi * (Math.Pow(x, 2.0));
                string B = A.ToString("N4");

                return B;
            }
         
        }
    }
}
