namespace Atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine 3 valores: ");
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine($"Triângulo = {Triangulo(A,C)}");
            Console.WriteLine($"Círculo = {Circulo(C)}");
            Console.WriteLine($"Trapézio = {Trapezio(A,B,C)}");
            Console.WriteLine($"Quadrado = {Quadrado(B)}");
            Console.WriteLine($"Retângulo = {Retangulo(A,B)}");

            static string Triangulo(double A, double B) 
            {
                double area = A * B/2;              
                return area.ToString("F3");
            }

            static string Circulo(double A) 
            {
                double pi = 3.14159;
                double area = pi * Math.Pow(A, 2);
                return area.ToString("F3");
            }

            static string Trapezio(double A, double B, double C) 
            {
                double area = (A + B) * C / 3;
                return area.ToString("F3");
            }

            static string Quadrado(double A) 
            {
                double area = A * A;
                return area.ToString("F3");
            }

            static string Retangulo(double A, double B) 
            {
                double area = A * B;
                return area.ToString("F3");
            }
        }
    }
}
