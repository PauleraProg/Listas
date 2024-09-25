namespace Atividade_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe suas notas: ");
            double A = double.Parse(Console.ReadLine());            
            double B = double.Parse(Console.ReadLine());           

            Console.WriteLine($"MEDIA = {Media(A,B)}");

            static string Media(double x, double y) 
            {
                x *= 3.5;
                y *= 7.5;

                double Z = (x + y)/11;
                string media = Z.ToString("F5");
                return media;
            }
        }
    }
}
