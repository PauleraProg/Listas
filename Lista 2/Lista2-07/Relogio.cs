using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_07
{
    internal class Relogio
    {
        public int Hora;
        public int Minuto;
        public int Segundo;

        public static string ExibirHoras(int A, int B, int C) 
        {
            return A + ":" + B + ":" + C;
        }
    }
}
