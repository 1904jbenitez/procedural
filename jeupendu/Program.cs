using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mot;
            do
            {
                Console.WriteLine("Joueur 1, veuillez saisir un mot français de 5 lettres minimum");
                 Mot = Console.ReadLine();

            } while ( Mot.Length<5 );

            // char[] MotRecherche = new char[Mot.Length]; declaration tableau classique;
            
            char[] MotRecherche = Mot.ToCharArray();

            Console.Clear();
            Console.WriteLine("Joueur 2 voici le mot à rechercher :");
            Jeu_tableau.MasqueLettre(ref MotRecherche);
            int Essai = 0;
            bool gagne = false;


            do
            {
               

                Console.WriteLine("Veuillez choisir une lettre masquée qui compose le mot ou pas!!!");
                char lettre = char.Parse(Console.ReadLine());
                if (Jeu_tableau.Jouer(ref MotRecherche,lettre,Mot) == false)
                {
                    Essai++;
                    if((6-Essai)>=0) { 
                    Console.WriteLine("Raté!!Il ne vous reste que : {0} coups à jouer", 6 - Essai);
                    }
                }
                else
                {

                    gagne = true;

                    Jeu_tableau.AfficherTableau( MotRecherche);

                    for (int i = 0; i < MotRecherche.Length; i++)
                    {
                        if (MotRecherche[i] == 95)
                        {
                            gagne = false;

                        }
                    }
                    


                }


            } while (Essai<=6 && gagne==false);

            if (gagne == true)
            {
                Console.WriteLine("Bravo vous avez gagné !! le mot est  bien :"+Mot+" avec un nombre d'erreur de :"+Essai);
               // Jeu_tableau.AfficherTableau(MotRecherche);
            }
            else
            {
                Console.WriteLine("vous avez dépasser les 6 ESSAIS, vous êtes \"pendu\" :");

                Console.WriteLine("le mot caché était: " + Mot);
            }

            Console.ReadKey();
        }

    }
   class Jeu_tableau
    {
        public static void MasqueLettre(ref char[] _tableau)
        {
            for (int i = 1; i < _tableau.Length-1; i++)
            {
                _tableau[i] = '_';
            }

            AfficherTableau(_tableau);
                
        }
        public static void AfficherTableau(char[] _tableauAffiche)

        {
            Console.Write("[ ");
            foreach (char element in _tableauAffiche)
            {
                Console.Write(element + " ");
            }
            Console.Write(" ] \n");
        }

        public static bool Jouer(ref char[] _tableauRecherhe, char _lettre,string _Mot)
        {
            bool Win = false;

            for (int i = 1; i < _tableauRecherhe.Length-1; i++)
            {
                if (_Mot[i].CompareTo(_lettre) == 0)
                {

                    _tableauRecherhe[i] =_lettre;
                    Win = true;

                }


            }

            return Win;
        }

    }
}
