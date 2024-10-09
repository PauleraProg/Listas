using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_05
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public static double Media(double A, double B, double C) 
        {
            double media = (A + B + C)/3;
            return media;
        } 
    }
}
