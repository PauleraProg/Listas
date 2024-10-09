using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_08
{
    internal class Conta
    {
        public int Numero;
        public string Titular;
        public double Saldo;

        public static double Depositar(double A, double B) 
        {
            double novoSaldo = A + B;
            return novoSaldo;
        }

        public static double Sacar(double A, double B) 
        {
            double novoSaldo = A - B;
            return novoSaldo;
        }
    }
}
