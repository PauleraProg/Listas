using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_02
{
    internal class Produto
    {
        public string Nome;
        public double Preço;
        public int Quant;

        public static (string, double, int) Info(string A, double B, int C) 
        {           
            return (A, B, C);
        }
    }
}
