using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     //class Triangulo responsavel por fazer o calculo o mesmo e retorna
     class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C)/2.0;
            return Math.Sqrt(p * (p - A ) * (p - B) * (p - C));
        }

    }
}
