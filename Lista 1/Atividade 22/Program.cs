namespace Atividade_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine um número: ");
            double num = double.Parse(Console.ReadLine());

            double[] cedulas = {100, 50, 20, 10, 5, 2, 1};
            double[] moedas = {1, 0.50, 0.25, 0.10, 0.05, 0.01};

            double[] countC = new double[7];
            double[] countM = new double[6];

            for (int i = 0; i <= 6; i++)
            {
                countC[i] = Math.Floor(num / cedulas[i]);
                num = num - (countC[i] * cedulas[i]);
                if (countC[i] > 0)
                {
                    Console.WriteLine($"{countC[i]} notas de {cedulas[i]}");
                }

                if (Math.Floor(num / cedulas[6]) <= 0) 
                {
                    for (int j = 0; j <= 5; j++) 
                    {
                        countM[j] = Math.Floor(num / moedas[j]);
                        num = num - (countM[j] * moedas[j]);
                        if (countM[j] > 0)
                        {
                            Console.WriteLine($"{countM[j]} moedas de {moedas[j]}");
                        }
                    }
                }
                        
            }
        }
    }
}
