using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_10
{
    internal class Temp
    {
        public double GrausC;

        public static double Fahrenheit(double A) 
        {
            double Fa = (A * 1.8) + 32;
            return Fa;
        }

        public static double Kelvin(double A) 
        {
            double Kel = A + 273.15;
            return Kel;
        }
    }
}
