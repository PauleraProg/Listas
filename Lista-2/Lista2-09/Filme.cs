using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_09
{
    internal class Filme
    {
        public string Titulo;
        public string Genero;
        public double Duracao;

        public static (string, string, double) ExibirInfo(string A, string B, double C) 
        {
            return (A, B, C);
        }
    }
}
