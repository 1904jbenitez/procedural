using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lefinancier
{
    public class credit
    {

        public static double CalculMensualite(double _Capital, double _Interet, double _NbMois)
        {
            double a;


            double Q =( 1 - Math.Pow((1 + _Interet),- _NbMois));
            //Q = (1 - (1 + tm)puissance - n) 
            //    a = K x tm/ Q

            a = (_Capital * _Interet) / Q;
            
            return Math.Round(a,2);

        }

    }
}
