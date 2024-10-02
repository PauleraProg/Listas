using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_03
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public static int Aniversario(int A) 
        {
            return ++A;
        }
    }
}
