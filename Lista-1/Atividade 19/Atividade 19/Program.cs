namespace Atividade_19
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Determine um número: ");
            double num = int.Parse(Console.ReadLine());
 
                double[] cedulas = {100, 50, 20, 10, 5, 2, 1};

                double[] countCed = new double [7];

                for (int i = 0; i <= 6; i++ ) 
                {
                    countCed[i] = Math.Floor(num / cedulas[i]);
                    num = num - (countCed[i] * cedulas[i]);
                    if (countCed[i] > 0)
                    {
                        Console.WriteLine($"{countCed[i]} notas de {cedulas[i]}");

                    }
                }

        }
    }
}
