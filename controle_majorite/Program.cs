using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlesaisies;
namespace controle_majorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Quelle est votre date de naissance? dd/mm/yyyy");
            string[] elementdate = (Console.ReadLine()).Split('/');
           
            DateTime datenaissance = new DateTime(int.Parse(elementdate[2]), int.Parse(elementdate[1]), int.Parse(elementdate[0]));

            if (ControleInterface.VerifMajorite(datenaissance))
            {
                Console.WriteLine("Vous êtes bien majeur!!");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas l'age de la majorité requis!!<18");
            }

            Console.ReadKey();

        }

        //static bool VerifMajorite(DateTime _dateNaissance)
        //{
         
        //    DateTime datejour = DateTime.Today;
        //    DateTime jourNaissance = new DateTime((datejour.Year-18),datejour.Month,datejour.Day);
        //    //    d2                       d3
        //    if (jourNaissance.CompareTo(_dateNaissance)==1)
        //    {
        //        return true;
        //    }
        //    else if (jourNaissance.CompareTo(_dateNaissance) == 0) 
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
                    
         
        //}
    }
}
