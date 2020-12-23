using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesFractions;

namespace AppFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction tiers1 = new Fraction(15,300);
            Fraction tiers2 = new Fraction(11,22);

            Fraction res=tiers1.Somme(tiers2);
            Console.WriteLine(res);


            //Fraction tier = new Fraction(1, 3);

            //Fraction deux = new Fraction(2);
            //Fraction zero = new Fraction();
            //Console.WriteLine("------Les trois constructeurs test--------");

            //Console.WriteLine(moitie.ToString());
            //Console.WriteLine(deux);
            //Console.WriteLine(zero);
           /* moitie.inverse()*/
            //Console.WriteLine(moitie.ToString());
            //moitie.oppose();
            //Console.WriteLine(moitie.ToString());
            //if (tier.SuperieurA(moitie)==true)
            //{

            //    Console.WriteLine("La fraction " + tier + " est supérieure à " + moitie);
             
            //}
            //else
            //{
            //    Console.WriteLine("La fraction " + moitie + " est supérieure à " + tier);
            //}
            Console.ReadKey();
        }
    }
}
