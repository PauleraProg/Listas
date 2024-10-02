using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_01
{
    internal class Livro
    {
        public string titulo;
        public string autor;
        public int numeroPaginas;

        public static (string, string, int) Info(string A, string B, int C) 
        {
            return (A, B, C);                       
        }

    }
}
