using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri_a_bulle_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien d'éléments souhaitez-vous dans le tableau ci-présent?");
            int nbrecase = int.Parse(Console.ReadLine());
            int[] tabNombre = new int[nbrecase];
            for (int i = 0; i < nbrecase; i++)
            {
                Console.WriteLine("Veuillez saisir le nombre numero: {0}/{1}", i + 1, nbrecase);
                tabNombre[i] = int.Parse(Console.ReadLine());
            }
            //fonction qui affiche le tableau...


            ManipulationTableau.AfficherTab(tabNombre);
            Console.WriteLine("Appuyer sur une touche pour trier le tableau!!");
            Console.ReadKey();
           tabNombre= ManipulationTableau.Trierbuller(tabNombre);
            ManipulationTableau.AfficherTab(tabNombre);
            Console.ReadKey();


        }
       
    }
    class ManipulationTableau
    {
        public static void AfficherTab(int[] _tab)
        {
            Console.Write("[ ");
            foreach (int element in _tab)
            {
                Console.Write(element + " ");
            }
            Console.Write(" ] \n");
        }

        public static int[] Trierbuller( int[] _tab)
        {
            bool trier;
            int temp;
            do
            {
                trier = true;
                for (int i = 0; i < _tab.Length - 1; i++)
                {

                    if (_tab[i] > _tab[i + 1])
                    {

                        trier = false;
                        temp = _tab[i];
                        _tab[i] = _tab[i + 1];
                        _tab[i + 1] = temp;
                    }
                }
            } while (trier == false);


          

            return  _tab;

        }

        public static int increment(int _n)
        {
            _n += 2;
            Console.WriteLine("valeur incrémenté :"+_n);
            return _n;
        }
    }
}
