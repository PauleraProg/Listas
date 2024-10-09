using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_04
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public static (string, string, int) Detalhes(string A, string B, int C) 
        {
            return (A, B, C);
        }
    }
}
