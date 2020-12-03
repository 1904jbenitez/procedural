using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string finchaine;
            string Phrase;
            string Palindrome;
            do
            {

                Console.WriteLine("Veuillez saisir une  phrase  terminée par un point(.)...");
            Phrase = Console.ReadLine().ToLower();

            finchaine = Phrase.Substring(Phrase.Length - 1, 1);

        } while (finchaine!=".");

            if (Phrase.Length == 1 && finchaine == ".")
            {
                Console.WriteLine("La chaine est vide !!");
            }
            else
            {

                Palindrome = Phrase.Substring(0, Phrase.Length - 1);
                Palindrome = Palindrome.Replace(" ", string.Empty);

                char[] endroit = Palindrome.ToCharArray();
                char[] envers = new char[Palindrome.Length];
                //remplissage du tableau envers
                for (int i = 0; i < endroit.Length; i++)
                {
                    envers[i] = endroit[(endroit.Length - 1) - i];

                }

                //recherche de palindrome
                bool verif = true;

                for (int i = 0; i < Palindrome.Length; i++)
                {
                    if (endroit[i] != envers[i])
                    {
                        verif = false;
                        break;
                    }

                }
                if (verif==true)
                {
                    Console.WriteLine("la phrase est un palindrome");
                }
                else
                {
                    Console.WriteLine("la phrase n'est pas un palindrome");
                }

                AfficherTab(endroit);
                AfficherTab(envers);

            }

        }

         static void AfficherTab(char[] _tab)
        {
            Console.Write("[ ");
            foreach (char element in _tab)
            {
                Console.Write(element + " ");
            }
            Console.Write(" ] \n");
        }


    }
}
