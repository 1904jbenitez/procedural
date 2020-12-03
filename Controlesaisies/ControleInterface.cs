using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlesaisies
{
    public class ControleInterface
    {
        public static bool ControleMajorite( DateTime _dateNaissance)
        {
            bool majeur;

            DateTime dateduJour = DateTime.Today;
            TimeSpan duree = dateduJour - _dateNaissance;
            double nbJour1 = duree.TotalDays;// retourne un double
            double nbJour2 = duree.Days;// retourne un int nombre de jour entier arrondi

            //Console.Write("nombre de jour 1: {0:#,###.00} et nombre de jour 2 : {1:#,###.00} \n", nbJour1, nbJour2);
            double nombreAnnee = Math.Floor((double)nbJour2 / 365.2425);
            if (nombreAnnee >= 18)
            {
                majeur = true;
            }
            else
            {
                majeur = false;
            }

            return majeur;

        }


        public static bool VerifMajorite(DateTime _dateNaissance)
        {

            DateTime datejour = DateTime.Today;
            DateTime jourNaissance = new DateTime((datejour.Year - 18), datejour.Month, datejour.Day);
            //    d2                       d3
            if (jourNaissance.CompareTo(_dateNaissance) == 1)
            {
                return true;
            }
            else if (jourNaissance.CompareTo(_dateNaissance) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
