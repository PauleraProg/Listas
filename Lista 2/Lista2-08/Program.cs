namespace Lista2_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta x;
            x = new Conta();

            Console.WriteLine("Informe seus dados:");
            x.Numero = int.Parse(Console.ReadLine());
            x.Titular = Console.ReadLine();
            x.Saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Oque gostaria de fazer?");
            string acao = Console.ReadLine();

            if (acao == "depositar")
            {
                Console.WriteLine("Quanto gostaria de depositar?");
                double deposito = double.Parse(Console.ReadLine());
                Console.WriteLine($"Seu novo saldo é: {Conta.Depositar(x.Saldo, deposito)}");

            }
            else if (acao == "sacar") 
            {
                Console.WriteLine("Quanto gostaria de sacar?");
                double saque = double.Parse(Console.ReadLine());
                Console.WriteLine($"Seu novo saldo é: {Conta.Sacar(x.Saldo, saque)}");
            }
            
        }
    }
}
